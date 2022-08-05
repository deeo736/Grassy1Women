using GrassyWomen.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;
using GrassyWomen.Migrations;


namespace GrassyWomen.Services
{
    public class Dbinitializer
    {
        public static void SeedDatabase(
        GrassyWomenDbContext context,
        UserManager<IdentityUser> userManager,
        RoleManager<IdentityRole> roleManager,
        IConfiguration configuration)
        {
            System.Console.WriteLine("Seeding... - Start");




            var products = new List<Product>
        {
              new Product
                {
                    Name ="SOAK-BATH SOAK",
                    Price = 80.00M,
                    ShortDescription ="The health benefits of soaking in an Epsom Salt bath have been long known and relied on for millennia",
                    LongDescription ="Soaking in one of our medicated bath soaks-full of skin beneficial oils, leaves hair and skin feeling soothed and nourished. The medical cannabis that has been infused in GrassyWomen’s Medical Cannabis Bath Soak promotes a state of deep relaxation and offers relief from the aches, pains, and cramping associated with the menstrual cycle.",
                    ImageUrl ="/img/Soak-1.jpg",
                    IsProductOfTheWeek = true,
              },

              new Product
              {
                    Name ="RUB-BODY BALM",
                    Price = 100.50M,
                    ShortDescription ="GrassyWomen Medical Cannabis Rub has been specially formulated for menstrual relief",
                    LongDescription ="The CB1 & CB2 receptors located within the skin epidermis gratefully absorb the sun grown cannabinoids, and receive valuable support and assistance from the cannabis plant when applied topically.",
                    ImageUrl ="",
                    IsProductOfTheWeek = false,


              },

               new Product
                {
                    Name ="RELAX-HERBAL TINCTURE",
                    Price=135.00M,
                    ShortDescription ="GrassyWomen Relax herbal tincture is a discreet medicinal option featuring a fusion of organic cane alcohol",
                    LongDescription ="Herbs like Red Raspberry Leaf, Motherwort and Cramp Bark offer benefits for the female reproductive system, while the Passionflower and Chamomile ease your body and mind.It aids the immune system and provides natural energy without any added sugars, making it ideal for daily use.",
                    ImageUrl ="img",
                    IsProductOfTheWeek = true,
                },
                new Product
                {
                    Name ="SAVOR-ORGANIC RAW CACAO",
                    Price = 30.50M,
                    ShortDescription ="Creamy ganache and sun-grown cannabis extract.",
                    LongDescription =" Best described as the love child of premium raw cacao,Savor’s healing ingredients and indulgent flavor pack the perfect trifecta of tastiness, versatility and wellness benefits",
                    ImageUrl ="img",
                    IsProductOfTheWeek =true,
                }

        };
        }
        



    }


     }