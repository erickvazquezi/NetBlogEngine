using Microsoft.EntityFrameworkCore;

namespace BlogEngine.App.Models
{
    public class PostCategoryRepository : IPostCategoryRepository
    {
        private readonly BlogEngineDbContext _dbContext;
        public PostCategoryRepository(BlogEngineDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<PostCategory> GetAll()
        {
            return _dbContext.PostCategories.Include(p => p.Post).Include(c => c.Category).ToList();
        }
    }
}
