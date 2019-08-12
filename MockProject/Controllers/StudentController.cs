﻿using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MockProject.Data.Interface;
using MockProject.Models.ViewModels;

namespace MockProject.Controllers
{
    [Authorize(Roles = "student, admin")]
    public class StudentController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public StudentController( IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [Route("Students")]

        public IActionResult List(int? year, string name, string search)
        {
            ViewBag.HK = name ?? "0";
            ViewBag.Year = year ?? 0;
            ViewBag.search = search;

            int id = int.Parse(User.Identity.Name) ;


            var years = _unitOfWork.SemesterRepository.GetAll().Select(x => x.Year).Distinct();
            ViewBag.ListYear = years;

            int yearCheck = year ?? 0;
            
            
            var list = _unitOfWork.TranscriptRepository.GetAll();
            if (yearCheck != 0)
            {
                list = list.Where( x => x.Schedule.Semester.Year == yearCheck);
            }
            
            list = list.Where(x => x.UserId == id)
                .Include(x => x.Schedule.Subject)
                .Include(x =>x.Schedule.User);

//            if (yearCheck != 0 && yearCheck != 2015 && yearCheck != 2016 )
//            {
//                return Content("CLGT??");
//            }

            if (!string.IsNullOrEmpty(name) && !name.Equals("0"))
            {
                int semId = int.Parse(name);
                list = list.Where(x => x.Schedule.SemesterId == semId);
            }


            List<StudentViewModel> rs = new List<StudentViewModel>();
            foreach (var x in list)
            {

                StudentViewModel vm = new StudentViewModel();
                vm.SubjectName = x.Schedule.Subject.Name;
                vm.TeacherName = x.Schedule.User.Name;
                vm.Mark = x.Mark;
                vm.Id = x.Schedule.Subject.Id;
                rs.Add(vm);
            }
            return View(rs.AsEnumerable());
        }    
        public IActionResult Details(int? id)
        {

            ViewBag.Pages = "Student";
            if (id == null)
            {
                return NotFound();
            }

            var subject = _unitOfWork.SubjectRepository.Get(id);
            if (subject == null)
            {
                Response.StatusCode = 404;
                return View("IdNotFound",id.Value);
            }

            return View(subject);
        }
    }
} 