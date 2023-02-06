using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlogEngine.App.Models
{
    [PrimaryKey("CategoryId","PostId")]
    public class PostCategory
    {
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
        public int PostId { get; set; }
        public Post? Post { get; set; }
        public bool IsActive { get; set; }
    }
}