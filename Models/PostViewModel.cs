using System.ComponentModel.DataAnnotations;

namespace ForumApp.Models
{
    public class PostViewModel:AddPostViewModel
    {
        public int Id { get; set; }
    }
}
