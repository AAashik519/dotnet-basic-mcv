using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace SyncStntax.Models.ViewModels
{
    public class PostViewModel
    {
      public Post? Post { get; set; }

      public IEnumerable<SelectListItem> Categories { get; set; } = Array.Empty<SelectListItem>();

      public IFormFile? Image { get; set; }
      
    }
}