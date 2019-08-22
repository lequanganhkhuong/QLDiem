using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MockProject.Areas.Admin.Controllers;
using MockProject.Data.Interface;
using MockProject.Models;
using Xunit;
using Moq;

namespace UnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void Index()
        {
            // Arrange
           
            var mockRepo = new Mock<IUnitOfWork>();
            mockRepo.Setup(repo => repo.FacultyRepository
                .GetAll(null,null,""));
            var controller = new FacultiesController(mockRepo.Object);

            // Act
            var result = controller.Index();

            // Assert
            Assert.IsType<ViewResult>(result);
        }
        [Fact]
        public void Detail()
        {
            // Arrange
            int id = 1;
            var mockRepo = new Mock<IUnitOfWork>();
            mockRepo.Setup(repo => repo.FacultyRepository
                .Get(id)).Returns(GetTestSessions().Where(x=>x.Id==id).FirstOrDefault);
            var controller = new FacultiesController(mockRepo.Object);

            // Act
            var result = controller.Details(id: id);

            // Assert
            //var viewResult = Assert.IsType<ViewResult>(result);
            Assert.IsType<ViewResult>(result);
        }
        [Fact]
        public void Edit()
        {
            // Arrange
            //int id = 1;
            var faculty = new Faculty
            {
                Id = 3,
                Name = "asd",
            };
            
            var mockRepo = new Mock<IUnitOfWork>();
            mockRepo.Setup(repo => repo.FacultyRepository
                .Get(faculty.Id)).Returns(GetTestSessions().Where(x=>x.Id==faculty.Id).FirstOrDefault);
            var controller = new FacultiesController(mockRepo.Object);

            // Act
            var result = controller.Edit(faculty.Id,faculty);

            // Assert
            Assert.IsType<ViewResult>(result);
        }
        private List<Faculty> GetTestSessions()
        {
            var sessions = new List<Faculty>();
                sessions.Add(new Faculty()
                {
                    Id = 1,
                    Name = "Test One",
                    Code = "asdasd",
                    Credits = 22,
                    IsActive = true
                });
                sessions.Add(new Faculty()
                {
                    Id = 2,
                    Name = "Test Two",
                    Code = "asdasdfdgdf",
                    Credits = 22,
                    IsActive = true
                });
                return sessions;
        }
    }
    
}