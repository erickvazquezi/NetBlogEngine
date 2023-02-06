namespace BlogEngine.App.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string? Title { get;set; }
        public string? Description { get; set; }
        public string? Author { get; set; }
        public string? Content { get; set; }
        public DateTime CreateDate { get; set; }
        public string? HeaderImage { get; set; }
        public string? PostImage { get; set; }
        public int Order { get;set; }
        public bool IsActive { get; set; }
        public virtual ICollection<PostCategory>? PostCategories { get; }
    }
}
