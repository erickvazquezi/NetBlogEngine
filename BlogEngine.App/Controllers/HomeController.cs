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
        private readonly ILogger<HomeController> _logger;
        private readonly IPostRepository _postRepository;

        public HomeController(ILogger<HomeController> logger, IPostRepository postRepository)
        {
            _logger = logger;
            _postRepository = postRepository;
        }

        public IActionResult Index()
        {
            HomeViewModel vm = new HomeViewModel(_postRepository);
            var allPosts = _postRepository.GetAllPosts().Where(p => p.Order == 0).ToList();
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