using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MockProject.Areas.Admin.Controllers;
using MockProject.Data.Interface;
using MockProject.Models;
using Moq;
using Xunit;

namespace UnitTest
{

    public class FacultiesControllerTest
    {

        [Fact]
        public void Test_Detail_when_id_true_result_view()
        {
            // Arrange
            int testSessionId = 1;
            var mockRepo = new Mock<IUnitOfWork>();
            mockRepo.Setup(x => x
                    .FacultyRepository.Get(testSessionId))
                    .Returns(GetTestFaculty().FirstOrDefault(
                    s => s.Id == testSessionId));

            var controller = new FacultiesController(mockRepo.Object);

            // Act
            var result = controller.Details(testSessionId);

            // Assert  
            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsType<Faculty>(viewResult.ViewData.Model);
            Assert.Equal(testSessionId, model.Id);

        }
        [Fact]
        public void Test_Detail_when_faculty_equal_null()
        {
            // Arrange
            int testSessionId = 1;
            var mockRepo = new Mock<IUnitOfWork>();
            mockRepo.Setup(repo => repo.FacultyRepository.Get(testSessionId))
                .Returns((Faculty)null);
            var controller = new FacultiesController(mockRepo.Object);

            // Act
            var result =  controller.Details(testSessionId);

            // Assert
            var contentResult = Assert.IsType<ContentResult>(result);
            Assert.Equal("Session not found.", contentResult.Content);
        }
        [Fact]
        public void Test_Detail_when_id_equal_null()
        {
            // Arrange
            var controller = new FacultiesController( null);

            // Act
            var result = controller.Details(id: null);

            // Assert
            var redirectToActionResult = 
                Assert.IsType<NotFoundResult>(result);
            Assert.NotNull(redirectToActionResult);
        }

        private List<Faculty> GetTestFaculty()
       {
           var sessions = new List<Faculty>();
           sessions.Add(new Faculty()
           {
               Id = 1,
               Name = "Test One",
               Credits = 20,
               Code = "TPM",       

           });
           sessions.Add(new Faculty()
           {
               Id = 2,
               Name = "Test Two",
               Credits = 20,
               Code = "TPM1"
           });
           return sessions;
       }

        [Fact]
        public void Test_Create_when_InvalidFaculty()
        {
            // Arrange & Act
            var mockRepo = new Mock<IUnitOfWork>();
            var controller = new FacultiesController(mockRepo.Object);
            controller.ModelState.AddModelError("error", "some error");

            // Act
            var result = controller.Create(faculty: null);

            // Assert
            Assert.IsType<ViewResult>(result);
        }
        [Fact]
        public void Test_Create_when_NewCreateFaculty()
        {
            int Id = 3;
            string Name = "Khoa Công Nghệ Thông Tin";
            int Credits = 20;
            string Code = "TPM";
            //var testFaculty = GetTestSessions().FirstOrDefault();
            var faculty = new Faculty
            {
                Id = Id,
                Name = Name,
                Credits = Credits,
                Code = Code

            };
            var mockRepo = new Mock<IUnitOfWork>();
            mockRepo.Setup(x => x.FacultyRepository.Insert(faculty));
            var controller = new FacultiesController(mockRepo.Object);

            var result = controller.Create(faculty);

             Assert.IsType<RedirectToActionResult>(result);
        }
        [Fact]
        public void Test_Edit_when_Valid_faculty()
        {
            var faculty = new Faculty
            {
                Id = 3,
                Name = "asd",
            };

            var mockRepo = new Mock<IUnitOfWork>();
            mockRepo.Setup(repo => repo.FacultyRepository
                .Get(faculty.Id)).Returns(GetTestFaculty().Where(x=>x.Id==faculty.Id).FirstOrDefault);
            var controller = new FacultiesController(mockRepo.Object);

            // Act
            var result = controller.Edit(faculty.Id,faculty);

            // Assert
            Assert.IsType<RedirectToActionResult>(result);
        }
        [Fact]
        public void Test_Edit_when_id_other_facultyid()
        {
            var faculty = new Faculty
            {
                Id = 3,
                Name = "asd",
            };

            var mockRepo = new Mock<IUnitOfWork>();
            mockRepo.Setup(repo => repo.FacultyRepository
                .Get(faculty.Id)).Returns(GetTestFaculty().Where(x=>x.Id == faculty.Id).FirstOrDefault);
            var controller = new FacultiesController(mockRepo.Object);

            // Act
            var result = controller.Edit(1,faculty);

            // Assert
            Assert.IsType<NotFoundResult>(result);
        }

    }
} 