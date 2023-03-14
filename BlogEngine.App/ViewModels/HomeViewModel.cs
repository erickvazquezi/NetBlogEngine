using BlogEngine.App.Components;
using BlogEngine.App.Models;

namespace BlogEngine.App.ViewModels
{
    public class HomeViewModel
    {
        public Post? HeaderPost { get; set; }
        public Post? SecondPost { get; set; }
        public Post? ThirdPost { get; set; }
        public PaginatedList<Post>? AllPost { get; set; }
        private IPostRepository _postRepository { get; set; }
        public bool HasNextPage { get; set; }
        public bool HasPreviousPage { get; set; }

        public HomeViewModel(IPostRepository postRepository)
        {
            _postRepository = postRepository;
            HeaderPost = _postRepository.GetAllPosts().FirstOrDefault(p => p.Order == 1);
            SecondPost = _postRepository.GetAllPosts().FirstOrDefault(p => p.Order == 2);
            ThirdPost = _postRepository.GetAllPosts().FirstOrDefault(p => p.Order == 3);
        }
    }
}
