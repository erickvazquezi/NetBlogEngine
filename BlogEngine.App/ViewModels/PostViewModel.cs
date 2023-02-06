using BlogEngine.App.Models;

namespace BlogEngine.App.ViewModels
{
    public class PostViewModel
    {
        public Post? HeaderPost { get; set; }
        public Post? SecondPost { get; set; }
        public Post? ThirdPost { get; set; }
        private IPostRepository _postRepository { get; set; }
        public PostViewModel(IPostRepository postRepository) 
        {
            _postRepository = postRepository;
            HeaderPost = _postRepository.GetAllPosts().FirstOrDefault(p => p.Order == 1);
            SecondPost = _postRepository.GetAllPosts().FirstOrDefault(p => p.Order == 2);
            ThirdPost = _postRepository.GetAllPosts().FirstOrDefault(p => p.Order == 3);
        }
    }
}
