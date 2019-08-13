using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MockProject.Data.Interface;
using MockProject.Models;
using MockProject.Models.ViewModels;

namespace MockProject.Controllers
{
    public class UserController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public UserController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET
        public IActionResult Index(int? id)
        {
            ViewBag.Title = "Profile";
            ViewData["FacultyId"] = new SelectList(_unitOfWork.FacultyRepository.GetAll().ToList(), "Name", "Name");

            var user = _unitOfWork.UserRepository.Get(id);
            return View(user);
        }


        public IActionResult EditProfile(int? id)
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

            return View(user);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditProfile(int id,
            [Bind("Id,Username,Password,Code,Name,Birthday,Address,Gender,IsActive,IsGraduated,FacultyId,RoleId")]User user)
        {
            if (id != user.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _unitOfWork.UserRepository.Update(user);
                    _unitOfWork.Save();
                }
                catch (DbUpdateConcurrencyException)
                {
                }

                return RedirectToAction(nameof(Index));
            }
            return View(user);
        }
        [HttpGet]
        public IActionResult ChangePass(int? id)
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

            var userVm = new UserEditProfile
            {
                Id = user.Id,
                PasswordNew = user.Password
            };

            return View(userVm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ChangePass(int id, UserEditProfile userVm)
        {
            var user = _unitOfWork.UserRepository.Get(userVm.Id);
            if (ModelState.IsValid)
            {
                try
                {
                    if (userVm.PasswordCurrent != user.Password)
                    {
                        ViewBag.Message = "Old password is not correct";
                        return View(nameof(ChangePass));
                    }
                    else
                    {
                        user.Password = userVm.PasswordNew;
                        _unitOfWork.UserRepository.Update(user);
                        _unitOfWork.Save();
                    }
                }
                catch (DbUpdateConcurrencyException)
                {
                }

                return RedirectToAction("Index", "Home");
            }

            return View();
        }
    }
} 