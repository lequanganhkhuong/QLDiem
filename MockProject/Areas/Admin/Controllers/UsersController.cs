using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MockProject.Data.Interface;
using MockProject.Models;

namespace MockProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "admin")]
    public class UsersController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public UsersController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult InfoUser(int? id)
        { 
            ViewBag.Pages = "User";
            var user =  _unitOfWork.UserRepository.Get(id);
            return View(user);
        }

        // GET: Users
        public async Task<IActionResult> Index( string filter)
        {
            ViewBag.Pages = "User";
           
            ViewBag.Filter = filter ?? "0";
            
            IQueryable<User> users = _unitOfWork.UserRepository.GetAll();
            if (!string.IsNullOrEmpty(filter))
            {
                int role = int.Parse(filter);
                if (role != 1 && role != 2 && role != 3 && role != 0)
                {
                    return View("NotFound");
                }
                if (role != 0)
                {
                    users = users.Where(x => x.RoleId == role);
                   
                }
                
            }
            
            return View(await users.Include(u => u.Faculty).Include(u => u.Role).ToListAsync());
        }

        // GET: Users/Details/5
        public  IActionResult Details(int? id)
        {
            ViewBag.Pages = "User";
            if (id == null)
            {
                return NotFound();
            }

            var user =  _unitOfWork.UserRepository.Get(id);
           
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // GET: Users/Create
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Pages = "User";
            ViewData["FacultyId"] = new SelectList(_unitOfWork.FacultyRepository.GetAll().ToList(), "Id", "Id");
            ViewData["RoleId"] = new SelectList(_unitOfWork.RoleRepository.GetAll().ToList(), "Id", "Id");
            return View();
        }

        // POST: Users/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public  IActionResult Create([Bind("Id,Username,Password,Code,Name,Birthday,Address,Gender,IsActive,FacultyId,RoleId")] User user)
        {
            ViewBag.Pages = "User";
            if (ModelState.IsValid)
            {
                PasswordHasher<User> hasher = new PasswordHasher<User>();
                user.Password = hasher.HashPassword(user,user.Name);
                
                _unitOfWork.UserRepository.Insert(user);
                _unitOfWork.Save();
                return RedirectToAction(nameof(Index));
            }
            ViewData["FacultyId"] = new SelectList(_unitOfWork.FacultyRepository.GetAll().ToList(), "Name", "Name", user.FacultyId);
            ViewData["RoleId"] = new SelectList(_unitOfWork.RoleRepository.GetAll().ToList(), "Name", "Name", user.RoleId);
            return View(user);
        }

        // GET: Users/Edit/5
        public  IActionResult Edit(int? id)
        {
            ViewBag.Pages = "User";
            if (id == null)
            {
                return NotFound();
            }

            var user = _unitOfWork.UserRepository.Get(id);
            if (user == null)
            {
                return NotFound();
            }
            ViewData["FacultyId"] = new SelectList(_unitOfWork.FacultyRepository.GetAll().ToList(), "Id", "Id", user.FacultyId);
            ViewData["RoleId"] = new SelectList(_unitOfWork.RoleRepository.GetAll().ToList(), "Id", "Id", user.RoleId);
            return View(user);
        }

        // POST: Users/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("Id,Username,Password,Code,Name,Birthday,Address,Gender,IsActive,IsGraduated,FacultyId,RoleId")] User user)
        {
            ViewBag.Pages = "User";
            if (id != user.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    PasswordHasher<User> hasher = new PasswordHasher<User>();
                    user.Password = hasher.HashPassword(user,user.Password);
                    
                    _unitOfWork.UserRepository.Update(user);
                    _unitOfWork.Save();
                }
                catch (DbUpdateConcurrencyException)
                {
                   
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["FacultyId"] = new SelectList(_unitOfWork.FacultyRepository.GetAll().ToList(), "Name", "Name", user.FacultyId);
            ViewData["RoleId"] = new SelectList(_unitOfWork.RoleRepository.GetAll().ToList(), "Name", "Name", user.RoleId);
            return View(user);
        }

        

        
    }
}
