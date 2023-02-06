using Microsoft.AspNetCore.Mvc;

namespace BlogEngine.App.Controllers
{
    public class PostController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
