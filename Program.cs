using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using GrassyWomen.Services;
using GrassyWomen.Data;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Authentication.Cookies;
using GrassyWomen.Migrations;
using GrassyWomen.Models;

namespace GrassyWomen
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
            builder.Services.AddDbContext<GrassyWomenDbContext>(options =>
                options.UseSqlServer(connectionString));
            builder.Services.AddDatabaseDeveloperPageExceptionFilter();

            builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<Migrations.GrassyWomenDbContext>();
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<GrassyWomenContext>(options =>


            //builder.Services.AddScoped<IProductServices, ProductService>());
            //builder.Services.AddScoped<IOrderServices, OrderService>();
            //builder.Services.AddScoped<IShoppingCartServices, ShoppingCartService>();


            // builder.Services.AddSingleton<IAlbumService, AlbumService>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseMigrationsEndPoint();
                //var dbContext = new GrassyWomenDbContext();
                //dbContext.SeedData();
                //dbContext.SaveChanges();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
            app.MapRazorPages();

            app.Run();


        }
    } 
}