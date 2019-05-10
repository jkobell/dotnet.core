using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesNorthwind.Models;

namespace RazorPagesNorthwind.Pages.Products
{
    public class DeleteModel : PageModel
    {
        private readonly RazorPagesNorthwind.Models.RazorPagesNorthwindContext _context;

        public DeleteModel(RazorPagesNorthwind.Models.RazorPagesNorthwindContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Models.Products Product { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Product = await _context.Products.FirstOrDefaultAsync(m => m.ProductID == id);

            if (Product == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Product = await _context.Products.FindAsync(id);

            if (Product != null)
            {
                _context.Products.Remove((Models.Products)Product);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
