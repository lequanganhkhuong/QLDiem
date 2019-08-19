using Microsoft.AspNetCore.Mvc;
using MockProject.Controllers;
using Xunit;

namespace UnitTestMockProject.Controller
{
    public class HomeControllerTest
    {
       
        [Fact(DisplayName = "Index should return default view")]
        public void Index_should_return_default_view()
        {
            var controller = new HomeController();
            var viewResult = (ViewResult)controller.Index();
            var viewName = viewResult.ViewName;

            Assert.True(string.IsNullOrEmpty(viewName) || viewName == "Index");
        }
  
    }
}