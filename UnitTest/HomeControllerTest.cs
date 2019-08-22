using Microsoft.AspNetCore.Mvc;
using MockProject.Controllers;
using Xunit;

namespace UnitTest
{
    public class HomeControllerTest
    {
        [Fact]
        public void  IndexActionReturnsIndexView(){
            var controller = new HomeController();


            var result = controller.Index() as ViewResult;


            Assert.NotNull(result);
        }
    }
}