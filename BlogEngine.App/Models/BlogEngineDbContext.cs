using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BlogEngine.App.Models
{
    public class BlogEngineDbContext : IdentityDbContext
    {
        public BlogEngineDbContext(DbContextOptions<BlogEngineDbContext> options) : base(options) { }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<PostCategory> PostCategories { get; set; }
    }
}