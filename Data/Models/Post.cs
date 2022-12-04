using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static ForumApp.Constants.DataConstants.Post;
namespace ForumApp.Data.Models
{
    [Comment("Published posts")]
    public class Post
    {
        [Key]
        [Comment("Posts Identifier")]
        public int Id { get; set; }

        [Comment("Post Title")]
        [Required]
        [MaxLength(TitleMaxLength)]
        public string Title { get; set; } = null!;

        [Comment("Content")]
        [Required]
        [MaxLength(ContextMaxLength)]
        public string Content { get; set; } = null!;

        [Comment("Marks record as removed")]
        [Required]
        public bool IsDeleted { get; set; } = false;
    }
}
