using ExeGuide;
using ExeGuide.Controllers;
using ExeGuide.Core.Services.Exercises;
using ExeGuide.Core.Services.Users;
using ExeGuide.DataBase.Data.Entities;
using FakeItEasy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Testing;



namespace ExeGuide.UnitTests
{
    public class HomeControllerTests
    {
        private readonly WebApplicationFactory<ExeGuide.Controllers.HomeController> _factory;

        public HomeControllerTests(WebApplicationFactory<ExeGuide.Controllers.HomeController> factory)
        {
            _factory = factory;
        }

        [Fact]
        public async void TestHomeControllerIndex()
        {
            var client = _factory.CreateClient();
            var response = await client.GetAsync("/Home/Index");
            int code = (int)response.StatusCode;

            Assert.Equal(200, code);
        }

       
       
    }
}
