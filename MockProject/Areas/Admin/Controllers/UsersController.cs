using System;
using System.Linq;
using System.Threading.Tasks;
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
        
        //generate code
        public IActionResult GenerateCode(int role)
        { 
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            
            
            var listCode = _unitOfWork.UserRepository.GetAll().Select(x => x.Code);
            
            string rs = "";

            do
            {
                string code = new string(Enumerable.Repeat(chars, 8)
                    .Select(s => s[random.Next(s.Length)]).ToArray());


                switch (role)
                {
                    case 1:
                        rs = "AD" + code;
                        break;
                    case 2:
                        rs = "GV" + code;
                        break;
                    case 3:
                        rs = "SV" + code;
                        break;
                }
            } while (listCode.Contains(rs));
            

            
           
            
            return Content(rs);
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
            ViewData["FacultyId"] = new SelectList(_unitOfWork.FacultyRepository.GetAll().ToList(), "Name", "Name");
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
            ViewData["FacultyId"] = new SelectList(_unitOfWork.FacultyRepository.GetAll(filter:x => x.IsActive).ToList(), "Id", "Name");
            ViewData["RoleId"] = new SelectList(_unitOfWork.RoleRepository.GetAll().ToList(), "Id", "Name");
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
            
            //validate code
            if (user.Code.Length < 10)
            {
                return Content("Invalid code");
            }
            //check if code match the role
            var codeCheck = user.Code.Substring(0, 2);
            switch (user.RoleId)
            {
                case 1:
                    if (!codeCheck.Equals("AD")) return Content("Invalid admin code");
                    break;
                case 2:
                    if (!codeCheck.Equals("GV")) return Content("Invalid teacher code");
                    break;
                case 3:
                    if (!codeCheck.Equals("SV")) return Content("Invalid student code");
                    break;
            }
            //check if code existed
            var codeList = _unitOfWork.UserRepository.GetAll().Select(x => x.Code);
            if (codeList.Contains(user.Code)) return Content("This code already exists");
            
            
            
            if (ModelState.IsValid)
            {
                //PasswordHasher<User> hasher = new PasswordHasher<User>();
                //user.Password = hasher.HashPassword(user,user.Name);
                
                _unitOfWork.UserRepository.Insert(user);
                _unitOfWork.Save();
                return RedirectToAction(nameof(Index));
            }
            ViewData["FacultyId"] = new SelectList(_unitOfWork.FacultyRepository.GetAll(filter:x => x.IsActive).ToList(), "Id", "Name", user.FacultyId);
            ViewData["RoleId"] = new SelectList(_unitOfWork.RoleRepository.GetAll().ToList(), "Id", "Name", user.RoleId);
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

            var userVm = new UsersEditVm
            {
                Id = user.Id,
                Address = user.Address,
                Birthday = user.Birthday,
                Code = user.Code,
                FacultyId = user.FacultyId,
                Gender = user.Gender,
                IsActive = user.IsActive,
                Name = user.Name,
                RoleId = user.RoleId
            };
            ViewData["FacultyId"] = new SelectList(_unitOfWork.FacultyRepository.GetAll(filter:x => x.IsActive).ToList(), "Id", "Name", user.FacultyId);
            ViewData["RoleId"] = new SelectList(_unitOfWork.RoleRepository.GetAll().ToList(), "Id", "Name", user.RoleId);
            return View(userVm);
        }

        // POST: Users/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("Id,Code,Name,Birthday,Address,Gender,IsActive,FacultyId,RoleId")] UsersEditVm userVm)
        {
            ViewBag.Pages = "User";
            if (id != userVm.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
//                    PasswordHasher<User> hasher = new PasswordHasher<User>();
//                    user.Password = hasher.HashPassword(user,user.Password);
                    var user = _unitOfWork.UserRepository.Get(userVm.Id);
                    if (user == null)
                    {
                        return NotFound();
                    }
                    user.Code = userVm.Code;
                    user.Name = userVm.Name;
                    user.Birthday = userVm.Birthday;
                    user.Address = userVm.Address;
                    user.Gender = userVm.Gender;
                    user.IsActive = userVm.IsActive;
                    user.FacultyId = userVm.FacultyId;
                    user.RoleId = userVm.RoleId;
                    _unitOfWork.UserRepository.Update(user);
                    _unitOfWork.Save();
                }
                catch (DbUpdateConcurrencyException)
                {
                   
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["FacultyId"] = new SelectList(_unitOfWork.FacultyRepository.GetAll(filter:x => x.IsActive).ToList(), "Id", "Name", userVm.FacultyId);
            ViewData["RoleId"] = new SelectList(_unitOfWork.RoleRepository.GetAll().ToList(), "Id", "Name", userVm.RoleId);
            return View(userVm);
        }

        

        
    }
}
