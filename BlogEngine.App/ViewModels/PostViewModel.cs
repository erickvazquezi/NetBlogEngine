using BlogEngine.App.Models;

namespace BlogEngine.App.ViewModels
{
    public class PostViewModel
    {
        public Post? CurrentPost { get; set; }
        private IPostRepository _postRepository { get; set; }
        public PostViewModel(IPostRepository postRepository, int IdPost) 
        {
            _postRepository = postRepository;
            CurrentPost = _postRepository.GetPostById(IdPost);
        }
    }
}
