using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SyncSyntex.Models
{
    public class Comment
    {
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage = "The UserName is Required")]
        [MaxLength(100, ErrorMessage = "The Username cannot exceed 100 characters")]
        public string Username  { get; set; }
        [DataType(DataType.Date)]
        public DateTime CommentDate { get; set; }
        [Required]
        public string Content { get; set; }
        [ForeignKey("Post")]
        public int PostId { get; set; }

        public Post Post { get; set; }
    }
}
