using Microsoft.EntityFrameworkCore;

namespace BlogEngine.App.Models
{
    public class BlogEngineDbContext : DbContext
    {
        public BlogEngineDbContext(DbContextOptions<BlogEngineDbContext> options) : base(options) { }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<PostCategory> PostCategories { get; set; }
    }
}