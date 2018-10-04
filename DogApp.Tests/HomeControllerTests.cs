using DogApp.Controllers;
using Microsoft.AspNetCore.Mvc;
using NSubstitute;
using System;
using Xunit;

namespace DogApp.Tests
{
    public class HomeControllerTests
    {
        [Fact]
        public void Index_Returns_A_View()
        {
            var dogRepo = Substitute.For<IDogRepository>();
            var underTest = new HomeController(dogRepo);

            var result = underTest.Index();

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Index_Gets_All_Dogs()
        {
            var dogRepo = Substitute.For<IDogRepository>();
            var underTest = new HomeController(dogRepo);

            underTest.Index();

            dogRepo.Received().GetAll();

        }
    }
}
