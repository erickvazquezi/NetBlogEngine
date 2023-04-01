using BlogEngine.App.Controllers;
using BlogEngine.App.ViewModels;
using BlogEnginte.Tests.Mocks;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogEnginte.Tests.Controllers
{
    public class HomeControllerTests
    {
        [Fact]
        public void Index_GetAllPosts_ReturnAllPosts()
        {
            //arrange
            var mockRepository = RepositoryMocks.GetPostRepository();
            var homeController = new HomeController(mockRepository.Object);

            //act
            var result = homeController.Index();

            //assert
            var viewResult = Assert.IsType<ViewResult>(result);
            var homeViewModel = Assert.IsAssignableFrom<HomeViewModel>(viewResult.ViewData.Model);
            Assert.NotNull(homeViewModel.HeaderPost);
        }
    }
}
