using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MockProject.Data.Interface;
using MockProject.Models.ViewModels;

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
            var nameHk = _unitOfWork.SemesterRepository.GetAll().Select(x => x.Name).Distinct();
            ViewBag.ListYear = years;
            ViewBag.ListName = nameHk;

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
            int currentUser = int.Parse(User.Identity.Name);
            ViewBag.Pages = "Teacher";
            if (id == null)
            {
                return NotFound();
            }

            var schedule = _unitOfWork.ScheduleRepository
                .GetAll(filter: x=>x.Id == id)
                .Include(x=>x.Subject)
                .SingleOrDefault();
            if (schedule == null)
            {
                Response.StatusCode = 404;
                return NotFound();
            }
            
            //check 
            if (schedule.UserId != currentUser)
            {
//                return Content("You are not allowed to access this action");
                return Unauthorized();
            }
            

            var liststudent = _unitOfWork.TranscriptRepository
                .GetAll(filter:x=> x.ScheduleId == id, includeProperties:"User,Schedule");

            
            ViewBag.LS = liststudent.ToList();

            return View(schedule);
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
                if(m < 0 || m >10)
                {
                    return Content("Mark can only be from 0 to 10");
                }
            }
            

            transcript.Mark = m;
            transcript.IsActive = false;
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
