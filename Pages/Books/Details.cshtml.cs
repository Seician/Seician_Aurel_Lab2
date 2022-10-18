using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Seician_Aurel_Lab2.Data;
using Seician_Aurel_Lab2.Models;

namespace Seician_Aurel_Lab2.Pages.Books
{
    public class DetailsModel : PageModel
    {
        private readonly Seician_Aurel_Lab2.Data.Seician_Aurel_Lab2Context _context;

        public DetailsModel(Seician_Aurel_Lab2.Data.Seician_Aurel_Lab2Context context)
        {
            _context = context;
        }

      public Book Book { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Book == null)
            {
                return NotFound();
            }

            var book = await _context.Book.FirstOrDefaultAsync(m => m.Id == id);
            if (book == null)
            {
                return NotFound();
            }
            else 
            {
                Book = book;
            }
            return Page();
        }
    }
}
