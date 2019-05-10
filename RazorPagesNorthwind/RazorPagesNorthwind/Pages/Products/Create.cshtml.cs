using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorPagesNorthwind.Models;

namespace RazorPagesNorthwind.Pages.Products
{
    public class CreateModel : PageModel
    {
        private readonly RazorPagesNorthwind.Models.RazorPagesNorthwindContext _context;

        public CreateModel(RazorPagesNorthwind.Models.RazorPagesNorthwindContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public RazorPagesNorthwind.Models.Products Product { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Products.Add((Models.Products)Product);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}