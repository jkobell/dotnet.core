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
    public class DetailsModel : PageModel
    {
        private readonly RazorPagesNorthwind.Models.RazorPagesNorthwindContext _context;

        public DetailsModel(RazorPagesNorthwind.Models.RazorPagesNorthwindContext context)
        {
            _context = context;
        }

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
    }
}
