using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RazorPagesNorthwind.Models
{
    public class RazorPagesNorthwindContext : DbContext
    {
        public RazorPagesNorthwindContext (DbContextOptions<RazorPagesNorthwindContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesNorthwind.Models.Products> Products { get; set; }
        
    }
}
