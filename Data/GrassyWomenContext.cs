using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GrassyWomen.Models;

namespace GrassyWomen.Data
{
    public class GrassyWomenContext : DbContext
    {
        public GrassyWomenContext (DbContextOptions<GrassyWomenContext> options)
            : base(options)
        {
        }

        public DbSet<GrassyWomen.Models.Product> Product { get; set; } = default!;
    }
}


