using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using razor_movies.Data;
using razor_movies.Models;

namespace razor_movies.Pages.Movies
{
    public class DetailsModel : PageModel
    {
        private readonly razor_movies.Data.ApplicationDbContext _context;

        public DetailsModel(razor_movies.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public movie movie { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            movie = await _context.movie.FirstOrDefaultAsync(m => m.ID == id);

            if (movie == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
