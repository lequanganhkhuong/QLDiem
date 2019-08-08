using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MockProject.Models;

namespace MockProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "admin")]
    public class SemestersController : Controller
    {
        private readonly AppDbContext _context;

        public SemestersController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Semesters
        public async Task<IActionResult> Index()
        {
            ViewBag.Pages = "Semester";
            var appDbContext = _context.Semesters.Include(s => s.Faculty);
            return View(await appDbContext.ToListAsync());
        }
        [HttpGet]
        public IActionResult AddSchedule(int? id)
        {
            ViewBag.Pages = "Semester";
            if (id == null)
            {
                return NotFound();
            }

            var semester = _context.Semesters
                .Include(s => s.Faculty)
                .FirstOrDefault(m => m.Id == id);
            if (semester == null)
            {
                return NotFound();
            }

            var schedules = _context.Schedules.Where(x => x.SemesterId == id)
                .Include(a => a.Subject)
                .Include(a => a.User)
                .ToList();
            return View(Tuple.Create<Semester,List<Schedule>>(semester,schedules));
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

            int semId = int.Parse(semesterId);
            int teaId = int.Parse(teacherId);
            int subId = int.Parse(subjectId);
                
            //validate input
            var sem = _context.Semesters.FirstOrDefault(x => x.Id == semId);
            var teacher = _context.Users.FirstOrDefault(x => x.Id == teaId);
            var subject = _context.Subjectses.FirstOrDefault(x => x.Id == subId);
            
            if (sem == null || teacher == null || subject == null)
            {
                return Content("invalid null value");
            }
            //check if schedule already existed
            var checkSchedule = _context.Schedules.SingleOrDefault(x => x.UserId == teaId && x.SubjectId == subId && x.SemesterId == semId);
            if (checkSchedule == null)
            {
                return Content("This schedule already exists");
            }
            //create schedule and add to db
            var sch = new Schedule
            {
                SubjectId = subId,
                SemesterId = semId,
                IsActive = true,
                UserId = teaId
            };
            _context.Schedules.Add(sch);
            _context.SaveChanges();
            
            //automatically create transcript for all students who havent completed this subject
            //get all student, check if they have completed that subject yet, 
            //
            var students = _context.Users.Where(x => x.RoleId == 3).ToList();
            var transcripts = _context.Transcripts.Where(x => x.Schedule.SubjectId == sch.SubjectId && x.IsPassed == true && x.IsActive);
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
                _context.Transcripts.Add(transcript);
            }

            _context.SaveChanges();
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
            var schedule = _context.Schedules.Where(x => x.Id == id)
                .Include(x=>x.User)
                .Include(x=>x.Subject)
                .FirstOrDefault();
            if (schedule == null)
            {
                return NotFound();
            }
            var transcripts = _context.Transcripts.Where(x => x.ScheduleId == id && x.IsActive)
                .Include(x=>x.User).ToList();
            
            return View(Tuple.Create<Schedule,List<Transcript>>(schedule,transcripts));
        }

        public IActionResult EditMark(int? id)
        {
            ViewBag.Pages = "Semester";

            var transcript = _context.Transcripts.Where(x => x.Id == id)
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
        public IActionResult EditMark(int? id, string Mark)
        {
            ViewBag.Pages = "Semester";
            
            
            var transcript = _context.Transcripts
                .FirstOrDefault(x => x.Id == id);
            
            if (transcript == null)
            {
                return NotFound();
            }
            foreach (char c in Mark)
            {
                if (c < '0' || c > '9')
                    return Content("Number only");
            }
            int mark = int.Parse(Mark);
            transcript.Mark = mark;
            _context.SaveChanges();
            return RedirectToAction("ScheduleDetail", new {id = id});
        }

        // GET: Semesters/Create
        public IActionResult Create()
        {
            ViewBag.Pages = "Semester";
            ViewData["FacultyId"] = new SelectList(_context.Faculties, "Id", "Id");
            return View();
        }

        // POST: Semesters/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,FacultyId,Year,IsActive")] Semester semester)
        {
            ViewBag.Pages = "Semester";
            if (ModelState.IsValid)
            {
                _context.Add(semester);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["FacultyId"] = new SelectList(_context.Faculties, "Id", "Id", semester.FacultyId);
            return View(semester);
        }

        // GET: Semesters/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            ViewBag.Pages = "Semester";
            if (id == null)
            {
                return NotFound();
            }

            var semester = await _context.Semesters.FindAsync(id);
            if (semester == null)
            {
                return NotFound();
            }
            ViewData["FacultyId"] = new SelectList(_context.Faculties, "Id", "Id", semester.FacultyId);
            return View(semester);
        }

        // POST: Semesters/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,FacultyId,Year,IsActive")] Semester semester)
        {
            ViewBag.Pages = "Semester";
            if (id != semester.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(semester);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["FacultyId"] = new SelectList(_context.Faculties, "Id", "Id", semester.FacultyId);
            return View(semester);
        }

    }
}
