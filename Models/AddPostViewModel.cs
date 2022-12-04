using System.ComponentModel.DataAnnotations;

namespace ForumApp.Models
{
    public class AddPostViewModel
    {
        [Display(Name = "Title")]
        [Required(ErrorMessage = "The field {0} is required")]
        [StringLength(50, MinimumLength = 10, ErrorMessage = "The field {0} has to be between {2} {1} characters")]
        public string Title { get; set; } = null!;

        [Display(Name = "Content")]
        [Required(ErrorMessage = "The field {0} is required")]
        [StringLength(1500, MinimumLength = 30, ErrorMessage = "The field {0} has to be between {2} {1} characters")]

        public string Content { get; set; } = null!;
    }
}
