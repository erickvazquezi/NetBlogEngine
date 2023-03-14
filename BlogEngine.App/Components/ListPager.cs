using BlogEngine.App.Models;
using BlogEngine.App.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlogEngine.App.Components
{
    public class ListPager : ViewComponent
    {
        private readonly IPostRepository _postRepository;

        public ListPager(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        public IViewComponentResult Invoke(int page = 1)
        {
            var allPosts = _postRepository.GetAllPosts().Where(p => p.Order == 0).ToList();
            var paginatedList = PaginatedList<Post>.CreateAsync(allPosts, page, 2);
            return View(paginatedList);
        }
    }
}
