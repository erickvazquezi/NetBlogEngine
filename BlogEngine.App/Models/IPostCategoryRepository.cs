namespace BlogEngine.App.Models
{
    public interface IPostCategoryRepository
    {
        List<PostCategory> GetAll();
    }
}