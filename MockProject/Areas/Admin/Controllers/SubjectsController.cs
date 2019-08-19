using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MockProject.Data.Interface;
using MockProject.Models;

namespace MockProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "admin")]
    public class SubjectsController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public SubjectsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: Subjects
        public async Task<IActionResult> Index()
        {
            ViewBag.Pages = "Subject";
            return View(await _unitOfWork.SubjectRepository.GetAll().ToListAsync());
        }

        // GET: Subjects/Details/5
        public IActionResult Details(int? id)
        {
            ViewBag.Pages = "Subject";
            if (id == null)
            {
                return NotFound();
            }

            var subject = _unitOfWork.SubjectRepository.Get(id);
            if (subject == null)
            {
                return NotFound();
            }

            var listTeacher = _unitOfWork.ScheduleRepository.GetAll(filter:x=>x.SubjectId ==id).Include(x=>x.User);
            ViewBag.TC = listTeacher;
            
            var listStudent = _unitOfWork.TranscriptRepository.GetAll(filter:x=>x.Schedule.SubjectId ==id && x.User.RoleId==3).Include(x=>x.Schedule).Include(x=>x.User);
            ViewBag.ST = listStudent;

            return View(subject);
        }

        // GET: Subjects/Create
        public IActionResult Create()
        {
            ViewBag.Pages = "Subject";
            return View();
        }

        // POST: Subjects/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Id,Name,Credits,IsActive")] Subject subject)
        {
            ViewBag.Pages = "Subject";
            if (ModelState.IsValid)
            {
                _unitOfWork.SubjectRepository.Insert(subject);
                _unitOfWork.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(subject);
        }

        // GET: Subjects/Edit/5
        public IActionResult Edit(int? id)
        {
            ViewBag.Pages = "Subject";
            if (id == null)
            {
                return NotFound();
            }

            var subject = _unitOfWork.SubjectRepository.Get(id);
            if (subject == null)
            {
                return NotFound();
            }
            return View(subject);
        }

        // POST: Subjects/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("Id,Name,Credits,IsActive")] Subject subject)
        {
            ViewBag.Pages = "Subject";
            if (id != subject.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _unitOfWork.SubjectRepository.Update(subject);
                    _unitOfWork.Save();
                }
                catch (DbUpdateConcurrencyException)
                {
                    
                }
                return RedirectToAction(nameof(Index));
            }
            return View(subject);
        }


       
    }
}
