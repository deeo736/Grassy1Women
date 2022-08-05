using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using GrassyWomen.Data;
using GrassyWomen.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace GrassyWomen.Migrations
{
    public class GrassyWomenDbContext : IdentityDbContext<IdentityUser>
    {
        public DbSet<Product> Cakes { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        public GrassyWomenDbContext(DbContextOptions<GrassyWomenDbContext> options)
            : base(options)
        {

        }

        internal Task SaveChangesAsync()
        {
            throw new NotImplementedException();
        }
    }
}