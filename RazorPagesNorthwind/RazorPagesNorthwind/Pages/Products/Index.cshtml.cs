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
    public class IndexModel : PageModel
    {
        private readonly RazorPagesNorthwind.Models.RazorPagesNorthwindContext _context;

        public IndexModel(RazorPagesNorthwind.Models.RazorPagesNorthwindContext context)
        {
            _context = context;
        }

        public IList<Models.Products> Products { get;set; }

        public async Task OnGetAsync()
        {
            Products = await _context.Products.ToListAsync();
        }
    }
}
