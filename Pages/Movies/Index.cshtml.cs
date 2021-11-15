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
    public class IndexModel : PageModel
    {
        private readonly razor_movies.Data.ApplicationDbContext _context;

        public IndexModel(razor_movies.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<movie> movie { get;set; }

        public async Task OnGetAsync()
        {
            movie = await _context.movie.ToListAsync();
        }
    }
}
