using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using aspnet_core_unit_1.Controllers;
using Microsoft.AspNetCore.Mvc;


namespace unit_1_tests
{
    public class HomeControllerTests
    {
        [Fact]
        public void Home_returnsException()
        {
            var controller = new HomeController(null);
            var result = controller.CheckCountValue(500);
            
            Assert.Throws<Exception>(() => result);

        }

        [Fact]
        public void Home_returnsView()
        {
            var controller = new HomeController(null);
            var result = controller.CheckCountValue(2);
            var viewResult = Assert.IsType<ViewResult>(result); 
            Assert.Null(viewResult.ViewName);

        }
    }
}
