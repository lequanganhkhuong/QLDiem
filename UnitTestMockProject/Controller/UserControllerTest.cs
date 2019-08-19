using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MockProject.Areas.Admin.Controllers;
using MockProject.Controllers;
using MockProject.Data.Interface;
using MockProject.Data.Repository;
using MockProject.Models;
using MockProject.Models.ViewModels;
using Xunit;

namespace UnitTestMockProject.Controller
{
    public class UserControllerTest
    {
        private readonly IUnitOfWork _unitOfWork;

        [Fact]
        public void ChangePassTest()
        {
            var change = new UserEditProfile();

            
            
            var controller = new UserEditProfile();
            
            
        }
    }
}