using BlogEngine.App.Models;
using BlogEngine.App.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BlogEngine.App.Controllers
{
    public class PostController : Controller
    {
        private readonly IPostRepository _postRepository;

        public PostController(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }
        public IActionResult Index(int IdPost)
        {
            PostViewModel viewModel = new PostViewModel(_postRepository, IdPost);
            return View(viewModel);
        }
    }
}
