using Microsoft.EntityFrameworkCore;

namespace BlogEngine.App.Models
{
    public class PostRepository : IPostRepository
    {
        private readonly BlogEngineDbContext _dbContext;
        public PostRepository(BlogEngineDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<Post> GetAllPosts()
        {
            return _dbContext.Posts.Include(p => p.PostCategories).ThenInclude(c => c.Category).ToList();
        }

        public Post? GetPostById(int id)
        {
            return _dbContext.Posts.Include(c => c.PostCategories).ThenInclude(c => c.Category).FirstOrDefault(p => p.Id == id);
        }
    }
}