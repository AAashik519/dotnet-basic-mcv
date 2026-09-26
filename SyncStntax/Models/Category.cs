using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SyncStntax.Models
{
    public class Category
    {
        [Key]
        public required int Id { get; set; }
        [Required(ErrorMessage = "Category name is required")]
        public required string Name { get; set; }
        [Required(ErrorMessage = "Category description is required")]
        public required string Description { get; set; }

        public ICollection<Post>? Posts { get; set; }
    }
}