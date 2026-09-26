using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SyncStntax.Models
{
    public class Post
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Title is required")]
        [MaxLength(200, ErrorMessage = "Title cannot exceed 200 characters")]
        public required string Title { get; set; }
        [Required(ErrorMessage = "Content is required")]
        [MaxLength(2000, ErrorMessage = "Content cannot exceed 2000 characters")]
        public required string Content { get; set; }
        [Required(ErrorMessage = "Author is required")]
        public required string Author { get; set; }
   
        public string? image { get; set; }

        [DataType(DataType.Date)]
        public DateTime PublishedDate { get; set; }
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
        public ICollection<Comments>? Comments { get; set; }

    }
}