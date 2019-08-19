using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MockProject.Data.Interface;
using MockProject.Models;
using MockProject.Models.ViewModels;

namespace MockProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "admin")]
    public class SemestersController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public SemestersController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: Semesters
        public IActionResult Index()
        {
            ViewBag.Pages = "Semester";
            var semesters = _unitOfWork.SemesterRepository.GetAll(includeProperties: "Faculty");
            return View(semesters.ToList());
        }
        [HttpGet]
        public IActionResult AddSchedule(int? id)
        {
            ViewBag.Pages = "Semester";
            //check if id is valid
            if (id == null)
            {
                return NotFound();
            }
            
            //get semester info
            var semester = _unitOfWork.SemesterRepository.GetAll(filter:x => x.Id == id).Include(x=>x.Faculty).SingleOrDefault();
            if (semester == null)
            {
                return NotFound();
            }
            
            //get schedules in this semester
            var schedules = _unitOfWork.ScheduleRepository
                .GetAll(filter: x => x.SemesterId == id, includeProperties:"Subject,User")
                .ToList();
            
            //get teacher list and subject list
            var teachers = _unitOfWork.UserRepository.GetAll(filter:x => x.RoleId == 2 && x.IsActive);
            var subjects = _unitOfWork.SubjectRepository.GetAll(filter: x =>x.IsActive).ToList();

            var teacherList = new List<TeacherListVm>();
            foreach (var t in teachers)
            {
                var item = new TeacherListVm
                {
                    Id = t.Id,
                    Name = t.Name
                };
                teacherList.Add(item);
            }

            ViewBag.Teachers = teacherList;
            ViewBag.Subjects = subjects;
            
            
            //return view
            return View(Tuple.Create(semester,schedules));
        }

        [HttpPost]
        public IActionResult AddSchedule(string teacherId, string subjectId, string semesterId)
        {
            
            //check if id is number
            var check = teacherId + subjectId + semesterId;
            foreach (char c in check)
            {
                if (c < '0' || c > '9')
                    return Content("Number only");
            }
            
            //check if user have chosen teacher or subject yet
            if (teacherId.Equals("0") )
            {
                return Content("Please choose teacher");
            }

            if (subjectId.Equals("0"))
            {
                return Content("Please choose subject");
            }
            
            //int parse user input
            int semId = int.Parse(semesterId);
            int teaId = int.Parse(teacherId);
            int subId = int.Parse(subjectId);
                
            //validate input
            var sem = _unitOfWork.SemesterRepository.Get(semId);
            var teacher = _unitOfWork.UserRepository.Get(teaId);
            var subject = _unitOfWork.SubjectRepository.Get(subId);
            
            if (sem == null || teacher == null || subject == null)
            {
                return Content("invalid null value");
            }
            //check if schedule already existed
            var checkSchedule = _unitOfWork.ScheduleRepository.GetAll(filter:x => x.UserId == teaId && x.SubjectId == subId && x.SemesterId == semId && x.IsActive);
            if (checkSchedule == null)
            {
                return Content("This schedule already exists");
            }
            
            //check if subject and teacher is active
            if (!teacher.IsActive)
            {
                return Content("The teacher is blocked");
            }
            if (!subject.IsActive)
            {
                return Content("The subject is blocked");
            }
            
            
            //create schedule and add to db
            var sch = new Schedule
            {
                SubjectId = subId,
                SemesterId = semId,
                IsActive = true,
                UserId = teaId
            };
            _unitOfWork.ScheduleRepository.Insert(sch);
            _unitOfWork.Save();
            
            //automatically create transcript for all students who havent completed this subject
            //get all student, check if they have completed that subject yet, 
            //
            var students = _unitOfWork.UserRepository
                .GetAll(filter:x => x.RoleId == 3 && x.FacultyId == sch.Semester.FacultyId).ToList();
            var transcripts = _unitOfWork.TranscriptRepository
                .GetAll(filter:x => x.Schedule.SubjectId == sch.SubjectId
                                    && x.Schedule.Semester.FacultyId == sch.Semester.FacultyId
                                    && x.IsPassed == true && x.IsActive);
            var passedstudents = from a in students
                join b in transcripts on a.Id equals b.UserId
                select a;
            foreach (var s in passedstudents)
            {
                if (students.Contains(s))
                {
                    students.Remove(s);
                }
            }
            //create transcripts for all students from the list
            foreach (var student in students)
            {
                var transcript = new Transcript
                {
                    ScheduleId = sch.Id,
                    UserId = student.Id,
                    IsActive = true,
                    IsPassed = false
                };
                _unitOfWork.TranscriptRepository.Insert(transcript);
            }

            _unitOfWork.Save();
            return RedirectToAction("AddSchedule");
        }
//        [HttpGet]
//        public IActionResult Addstudent()
//        {
//            int[] khoa = {1, 2, 3, 4};
//            Random r = new Random();
//            for (int i = 0; i < 10; i++)
//            {
//                var s = new User
//                {
//                    Code = "SV000" + i,
//                    Birthday = new DateTime(1995,1,1),
//                    Address = "abcxyz" + i,
//                    FacultyId = khoa[r.Next(khoa.Length)],
//                    Gender = true,
//                    Name = "SV" + i,
//                    IsActive = true,
//                    Username = "SV" + i,
//                    Password = "SV" + i,
//                    RoleId = 3
//                    
//                };
//                _context.Users.Add(s);
//                
//            }
//            _context.SaveChanges();
//            return Content("OK");
//        }
        public IActionResult ScheduleDetail(int? id)
        {
            ViewBag.Pages = "Semester";
            var schedule = _unitOfWork.ScheduleRepository
                .GetAll(filter:x => x.Id == id,includeProperties:"User,Subject").SingleOrDefault();
            if (schedule == null)
            {
                return NotFound();
            }
            var transcripts = _unitOfWork.TranscriptRepository
                .GetAll(filter:x => x.ScheduleId == id , includeProperties:"User")
                .ToList();
            
            return View(Tuple.Create(schedule,transcripts));
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
            
            return View(transcript);
        }

        [HttpPost]
        public IActionResult EditMark(int? id, string mark)
        {
            ViewBag.Pages = "Semester";
            
            
            var transcript = _unitOfWork.TranscriptRepository.Get(id);
            
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
            if (transcript.Mark < 5)
            {
                transcript.IsPassed = false;
            }
            else
            {
                transcript.IsPassed = true;
            }
            _unitOfWork.Save();
            return RedirectToAction("ScheduleDetail", new { id = transcript.ScheduleId});
        }

        // GET: Semesters/Create
        public IActionResult Create()
        {
            ViewBag.Pages = "Semester";
            ViewData["FacultyId"] = new SelectList(_unitOfWork.FacultyRepository.GetAll(filter: x => x.IsActive), "Id", "Id");
            return View();
        }

        // POST: Semesters/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Id,Name,FacultyId,Year,IsActive")] Semester semester)
        {
            ViewBag.Pages = "Semester";
            
            //check if faculty is active
            var fac = _unitOfWork.FacultyRepository.GetAll(filter: x => x.Id == semester.FacultyId && !x.IsActive);
            if (fac.Any())
            {
                return Content("This faculty is no longer valid");
            }
            
            //
            if (ModelState.IsValid)
            {
                _unitOfWork.SemesterRepository.Insert(semester);
                _unitOfWork.Save();
                return RedirectToAction(nameof(Index));
            }
            ViewData["FacultyId"] = new SelectList(_unitOfWork.FacultyRepository.GetAll(filter: x => x.IsActive), "Id", "Id", semester.FacultyId);
            return View(semester);
        }

        // GET: Semesters/Edit/5
        public IActionResult Edit(int? id)
        {
            ViewBag.Pages = "Semester";
            if (id == null)
            {
                return NotFound();
            }

            var semester = _unitOfWork.SemesterRepository.Get(id);
            if (semester == null)
            {
                return NotFound();
            }
            ViewData["FacultyId"] = new SelectList(_unitOfWork.FacultyRepository.GetAll(filter: x => x.IsActive), "Id", "Name", semester.FacultyId);
            return View(semester);
        }

        // POST: Semesters/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("Id,Name,FacultyId,Year,IsActive")] Semester semester)
        {
            
            ViewBag.Pages = "Semester";
            
            //check if faculty is active
            var fac = _unitOfWork.FacultyRepository.GetAll(filter: x => x.Id == semester.FacultyId && !x.IsActive);
            if (fac.Any())
            {
                return Content("This faculty is no longer valid");
            }
            
            //
            if (id != semester.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _unitOfWork.SemesterRepository.Update(semester);
                    _unitOfWork.Save();
                }
                catch (DbUpdateConcurrencyException)
                {
                    
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["FacultyId"] = new SelectList(_unitOfWork.FacultyRepository.GetAll(filter: x => x.IsActive), "Id", "Name", semester.FacultyId);
            return View(semester);
        }
        // GET: Semesters/Edit/5
        public IActionResult EditSchedule(int? id)
        {
            ViewBag.Pages = "Semester";
            if (id == null)
            {
                return NotFound();
            }

            var schedule = _unitOfWork.ScheduleRepository.Get(id);
            if (schedule == null)
            {
                return NotFound();
            }
            ViewData["SubjectId"] = new SelectList(_unitOfWork.SubjectRepository.GetAll(filter: x => x.IsActive), "Id", "Name", schedule.SubjectId);
            ViewData["UserId"] = new SelectList(_unitOfWork.UserRepository.GetAll(filter: x => x.RoleId == 2 && x.IsActive), "Id", "Name", schedule.UserId);
            return View(schedule);
        }

        // POST: Semesters/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditSchedule(int id, [Bind("Id,SubjectId,UserId,SemesterId,IsActive")] Schedule schedule)
        {
            
            ViewBag.Pages = "Semester";
            
            //check if subject is active
            var subjects = _unitOfWork.SubjectRepository.GetAll(filter: x => x.Id == schedule.SubjectId && !x.IsActive).SingleOrDefault();
            if (subjects != null)
            {
                return Content("This subject is no longer valid");
            }
            //check if user is active and is teacher
            var user = _unitOfWork.UserRepository.GetAll(filter: x => x.Id == schedule.UserId).SingleOrDefault();
            if (user != null)
            {
                if (!user.IsActive ) 
                {
                    return Content("This user is no longer valid");
                }
                if (user.RoleId != 2)
                {
                    return Content("This user is not a teacher");
                } 
            }
           
            

            
            //
            if (id != schedule.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _unitOfWork.ScheduleRepository.Update(schedule);
                    _unitOfWork.Save();
                }
                catch (DbUpdateConcurrencyException)
                {
                    
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["SubjectId"] = new SelectList(_unitOfWork.SubjectRepository.GetAll(filter: x => x.IsActive), "Id", "Name", schedule.SubjectId);
            ViewData["UserId"] = new SelectList(_unitOfWork.UserRepository.GetAll(filter: x => x.RoleId == 2 && x.IsActive), "Id", "Name", schedule.UserId);
            return View(schedule);
        }
    }
}
