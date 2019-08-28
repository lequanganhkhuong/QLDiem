using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Drawing;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MockProject.Data.Interface;
using MockProject.Models;
using MockProject.Models.ViewModels;
using OfficeOpenXml;

namespace MockProject.Controllers
{
    [Authorize(Roles = "teacher, admin")]
    public class TeacherController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public TeacherController( IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [Route("Teacher")]

        public IActionResult List(int? year, string name, string search)
        {
            ViewBag.HK = name ?? "0";
            ViewBag.Year = year ?? 0;
            ViewBag.search = search;

            int id = int.Parse(User.Identity.Name) ;

            var years = _unitOfWork.SemesterRepository.GetAll().Select(x => x.Year).Distinct();
            var namehk = _unitOfWork.SemesterRepository.GetAll().Select(x => x.Name).Distinct();
            ViewBag.ListYear = years;
            ViewBag.ListName = namehk;

            int yearCheck = year ?? 0;

            var list = _unitOfWork.ScheduleRepository.GetAll();
            if (yearCheck != 0)
            {
                list = list.Where( x => x.Semester.Year == yearCheck);
            }
            if (!list.Any())
            {
                return NotFound();
            }                                                         
            list = list.Where(x => x.UserId == id)
                .Include(x => x.Subject)
                .Include(x =>x.User);
            
            if (!string.IsNullOrEmpty(name) && !name.Equals("0"))
            {
                //int semId = int.Parse(name);
                list = list.Where(x => x.Semester.Name == name);
            }
            
            List<TeacherViewModel> rs = new List<TeacherViewModel>();
            
                foreach (var x in list)
                {
                    TeacherViewModel vm = new TeacherViewModel();
                    vm.SubName = x.Subject.Name;
                    vm.Id = x.Id;
                    
                    rs.Add(vm);
                }
            
            return View(rs.AsEnumerable());
        } 
        public IActionResult Details(int? id)
        {

            ViewBag.Pages = "Teacher";
            if (id == null)
            {
                return NotFound();
            }

            var schedule = _unitOfWork.ScheduleRepository.GetAll(filter: x=>x.Id == id)
                .Include(x=>x.Subject)
                .SingleOrDefault();
            
            if (schedule == null)
            {
                Response.StatusCode = 404;
                return NotFound();
            }

            var liststudent = _unitOfWork.TranscriptRepository
                .GetAll(filter: x => x.ScheduleId == id, includeProperties: "User,Schedule"); 
            
            ViewBag.LS = liststudent.ToList();

            return View(schedule);
        }

        public IActionResult ExportToExcel()
        {
            byte[] fileContents;
            List<Transcript> emplist = _unitOfWork.TranscriptRepository.GetAll(filter: x => x.ScheduleId == 6 ).Select(x => new Transcript
            {
                User = x.User,
                Mark = x.Mark
            }).ToList();

            ExcelPackage pck = new ExcelPackage();
            ExcelWorksheet ws = pck.Workbook.Worksheets.Add("Report");


            ws.Cells["A1"].Value = "Name1111";
            ws.Cells["B1"].Value = "Mark111";



            int rowStart = 2;
            foreach (var item in emplist)
            {
                ws.Cells[string.Format("A{0}", rowStart)].Value = item.User.Name;
                ws.Cells[string.Format("B{0}", rowStart)].Value = item.Mark;
                rowStart++;
            }

            ws.Cells["A:AZ"].AutoFitColumns();
            fileContents = pck.GetAsByteArray();
            if (fileContents == null || fileContents.Length == 0)
            {
                return NotFound();
            }

            return File(
                fileContents: fileContents,
                contentType: "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                fileDownloadName: "test.xlsx"
            );
        }

        public IActionResult EditMark(int? id)
        {

            ViewBag.Pages = "Semester";

            var transcript = _unitOfWork.TranscriptRepository.GetAll(filter:x => x.Id == id)
                .Include(x => x.User)
                .Include(x => x.Schedule.User)
                .Include(x => x.Schedule.Subject)
                .Include(x => x.Schedule.Semester)
                .FirstOrDefault();
            if (transcript == null)
            {
                return NotFound();
            }

            if (!transcript.IsActive)
            {
                return NotFound();
            }
            return View(transcript);
        }

        [HttpPost]
        public IActionResult EditMark(int? id, string mark)
        {
            ViewBag.Pages = "Semester";


            var transcript = _unitOfWork.TranscriptRepository.GetAll(filter: x=> x.Id ==id).Include(x=>x.Schedule).SingleOrDefault();

            if (transcript == null)
            {
                return NotFound();
            }
            double m ;
            if (double.TryParse(mark, out m))
            {
                m = double.Parse(mark);
            }
            
            transcript.Mark = m;
            transcript.IsActive = false;
            if(transcript.Mark < 0 || transcript.Mark >10)
            {
                return Content("Fail");
            }
            if (transcript.Mark < 5)
            {
                transcript.IsPassed = false;
            }
            else
            {
                transcript.IsPassed = true;
            }
            _unitOfWork.Save();
            return RedirectToAction("Details", new {id = transcript.Schedule.SubjectId});
        }
    }
} 