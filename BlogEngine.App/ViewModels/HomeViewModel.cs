using BlogEngine.App.Models;

namespace BlogEngine.App.ViewModels
{
    public class HomeViewModel
    {
        public Post? HeaderPost { get; set; }
        public Post? SecondPost { get; set; }
        public Post? ThirdPost { get; set; }
        public List<Post> AllPost { get; set; }
        private IPostRepository _postRepository { get; set; }

        public HomeViewModel(IPostRepository postRepository)
        {
            _postRepository = postRepository;
            HeaderPost = _postRepository.GetAllPosts().FirstOrDefault(p => p.Order == 1);
            SecondPost = _postRepository.GetAllPosts().FirstOrDefault(p => p.Order == 2);
            ThirdPost = _postRepository.GetAllPosts().FirstOrDefault(p => p.Order == 3);
            AllPost = _postRepository.GetAllPosts().Where(p => p.Order == 0).ToList();
        }
    }
}
