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
    public class FacultiesController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public FacultiesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: Faculties
      
        public async Task<ViewResult> Index()
        {
            ViewBag.Pages = "Faculty";
            return View(await _unitOfWork.FacultyRepository.GetAll().ToListAsync());
        }

        // GET: Faculties/Details/5

        public IActionResult ListSubject(int? id)
        {
            ViewBag.Pages = "Faculty";
            if (id == null)
            {
                return NotFound();
            }

            var faculty = _unitOfWork.FacultyRepository.Get(id);
            if (faculty == null)
            {
                return NotFound();
            }

            var listSubject = _unitOfWork.ScheduleRepository.GetAll(filter:x
                => x.Semester.FacultyId == id).Include(x=>x.Semester).Include(x=>x.Subject);
            
            ViewBag.CC = listSubject;

            return View(faculty);
        }

        public IActionResult Details(int? id)
        {
            ViewBag.Pages = "Faculty";
            if (id == null)
            {
               return NotFound(); 
            }

            var faculty = _unitOfWork.FacultyRepository.Get(id);
            if (faculty == null)
            {
                //return NotFound();
                return Content("Session not found.");
            }
//            var liststudent = _unitOfWork.UserRepository.GetAll(filter:x=> x.FacultyId == id && x.RoleId == 3);
//            ViewBag.LS = liststudent;
            return View(faculty);
        }

        // GET: Faculties/Create
  
        public IActionResult Create()
        {
            ViewBag.Pages = "Faculty";
            return View();
        }

        // POST: Faculties/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Create([Bind("Id,Name,Credits,Code,IsActive")] Faculty faculty)

        {
            ViewBag.Pages = "Faculty";
            if (ModelState.IsValid)
            {
                _unitOfWork.FacultyRepository.Insert(faculty);
                _unitOfWork.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(faculty);
        }

        // GET: Faculties/Edit/5

        public IActionResult Edit(int? id)

        {
            ViewBag.Pages = "Faculty";
            if (id == null)
            {
                return NotFound();
            }

            var faculty = _unitOfWork.FacultyRepository.Get(id);
            if (faculty == null)
            {
                return NotFound();
            }
            return View(faculty);
        }

        // POST: Faculties/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Edit(int id, [Bind("Id,Name,Credits,Code,IsActive")] Faculty faculty)

        {
            ViewBag.Pages = "Faculty";
            if (id != faculty.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _unitOfWork.FacultyRepository.Update(faculty);
                    _unitOfWork.Save();
                }
                catch (DbUpdateConcurrencyException)
                {
                    
                }
                return RedirectToAction(nameof(Index));
            }
            return View(faculty);
        }

        

        
    }
}
