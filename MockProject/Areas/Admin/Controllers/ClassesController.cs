using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MockProject.Data.Interface;
using MockProject.Models;

namespace MockProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ClassesController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public ClassesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET
        public async Task<IActionResult> Index()
        {
            ViewBag.Pages = "Class";

            IQueryable<Class> classes = _unitOfWork.ClassRepository.GetAll();
            return View(await classes.Include(f => f.Faculty).ToListAsync());
        }

        public IActionResult Create()
        {
            ViewBag.Pages = "Class";

            ViewData["FacultyId"] = new SelectList(_unitOfWork.FacultyRepository.GetAll().ToList(), "Id", "Name");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Class model)
        {
            ViewBag.Pages = "Class";
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (ModelState.IsValid)
            {
                _unitOfWork.ClassRepository.Insert(model);
                _unitOfWork.Save();
                return RedirectToAction(nameof(Index));
            }

            ViewData["FacultyId"] = new SelectList(_unitOfWork.FacultyRepository.GetAll().ToList(), "Id", "Name");
            return View();
        }

        public IActionResult Details(int? id)
        {
            ViewBag.Pages = "Class";
            ViewData["FacultyId"] = new SelectList(_unitOfWork.FacultyRepository.GetAll().ToList(), "Id", "Name");
            if (id == null)
            {
                return NotFound();
            }

            var classes = _unitOfWork.ClassRepository.Get(id);
            if (classes == null)
            {
                return NotFound();
            }
            var listStudent = _unitOfWork.UserRepository.GetAll(filter: x => x.ClassesId == id);
            ViewBag.CC = listStudent;
            
            return View(classes);
            
        }
        // GET: Faculties/Edit/5

        public IActionResult Edit(int? id)

        {
            ViewBag.Pages = "Class";
            if (id == null)
            {
                return NotFound();
            }

            var classes = _unitOfWork.ClassRepository.Get(id);
            if (classes == null)
            {
                return NotFound();
            }
            return View(classes);
        }

        // POST: Faculties/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Edit(int id, [Bind("Id,NameClass,Year,FacultyId")] Class classes)

        {
            ViewBag.Pages = "Class";
            if (id != classes.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _unitOfWork.ClassRepository.Update(classes);
                    _unitOfWork.Save();
                }
                catch (DbUpdateConcurrencyException)
                {
                    
                }
                return RedirectToAction(nameof(Index));
            }
            return View(classes);
        }
    }
}