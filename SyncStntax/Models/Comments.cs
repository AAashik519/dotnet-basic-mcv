using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace SyncStntax.Models
{
    public class Comments
    {   
        [Key]
        public int Id { get; set; }
        [Required]
        public required string Username { get; set; }
        [Required(ErrorMessage = "Comment is required")]
      
        public string? Comment { get; set; }
        [DataType(DataType.Date)]
        public DateTime CommentDate { get; set; }
        [ForeignKey("Post")]
        public int PostId { get; set; }
        public Post? Post { get; set; }
    }
}