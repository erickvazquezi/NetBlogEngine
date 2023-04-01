using BlogEngine.App.Components;
using BlogEngine.App.Models;
using BlogEngine.App.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Diagnostics;

namespace BlogEngine.App.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPostRepository _postRepository;

        public HomeController(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        public IActionResult Index()
        {
            HomeViewModel vm = new HomeViewModel(_postRepository);
            vm.HeaderPost = _postRepository.GetAllPosts().FirstOrDefault(p => p.Order == 1);
            vm.SecondPost = _postRepository.GetAllPosts().FirstOrDefault(p => p.Order == 2);
            vm.ThirdPost = _postRepository.GetAllPosts().FirstOrDefault(p => p.Order == 3);
            return View(vm);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult GetPostComponent(int page, int totalPages, string caller)
        {
            switch (caller)
            {
                case "Siguiente":
                    page = page >= totalPages ? 1 : page += 1;
                    break;
                case "Anterior":
                    page = page == 1 ? totalPages : page -= 1;
                    break;
                default: page = 1;
                    break;
            }
            return ViewComponent("ListPager", page);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }       
    }
}