using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MockProject.Data.Interface;
using MockProject.Models.ViewModels;

namespace MockProject.Controllers
{
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
            ViewBag.ListYear = years;

            int yearCheck = year ?? 0;

            var list = _unitOfWork.ScheduleRepository.GetAll(filter: x => x.Semester.Year == yearCheck 
                                                                        && x.UserId == id);

            if (!string.IsNullOrEmpty(name) && !name.Equals("0"))
            {
                int semId = int.Parse(name);
                list = list.Where(x => x.SemesterId == semId).Include(x=>x.Semester).Include(x=>x.Subject);
            }

            List<TeacherViewModel> rs = new List<TeacherViewModel>();
            foreach (var x in list)
            {
                TeacherViewModel vm = new TeacherViewModel();
                vm.SubName = x.Subject.Name;
                vm.Id = x.SubjectId;
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

            var schedule = _unitOfWork.SubjectRepository.Get(id);
            if (schedule == null)
            {
                Response.StatusCode = 404;
                return NotFound();
            }

            var liststudent = _unitOfWork.TranscriptRepository.GetAll(filter:x=> x.Schedule.SubjectId == id).Include(x=> x.User).Include(x=>x.Schedule);
            ViewBag.LS = liststudent;

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
            foreach (char c in mark)
            {
                if (c < '0' || c > '9')
                    return Content("Number only");
            }
            int m = int.Parse(mark);
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