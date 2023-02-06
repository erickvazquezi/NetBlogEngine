using Microsoft.EntityFrameworkCore;

namespace BlogEngine.App.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly BlogEngineDbContext _dbContext;

        public CategoryRepository(BlogEngineDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<Category> GetAllCategories()
        {
            return _dbContext.Categories.Include(p => p.PostCategories).ToList();
        }

        public Category? GetCategoryById(int id)
        {
            return _dbContext.Categories.FirstOrDefault(c => c.Id == id);
        }
    }
}