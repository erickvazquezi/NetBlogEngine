namespace BlogEngine.App.Models
{
    public interface IPostRepository
    {
        List<Post> GetAllPosts();
        Post? GetPostById(int id);
    }
}
