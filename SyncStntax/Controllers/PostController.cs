using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using SyncStntax.Data;
using SyncStntax.Models;
using SyncStntax.Models.ViewModels;

namespace SyncStntax.Controllers
{
    [Route("[controller]")]
    public class PostController : Controller
    {
        private readonly AppDbContext _context;

        public PostController(AppDbContext context)
        {
            _context = context;
        }
        [HttpGet("create")]
        public IActionResult Create()
        {
            var postViewModal = new PostViewModel();
            postViewModal.Categories = _context.Categories.Select(c => new SelectListItem
            {
                Value = c.Id.ToString(),
                Text = c.Name
            });
            return View(postViewModal );
        }
    }
}  