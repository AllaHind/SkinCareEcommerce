using SkinCareEcommerce.Service.ProductAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using static System.Net.Mime.MediaTypeNames;

namespace SkinCareEcommerce.Service.ProductAPI.DbContexts
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions options  ):base(options)
        {
                

        }
        //cree products dans bdd
        public DbSet<Product> Products { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // cree des produit statique avec modelbuilder 
            modelBuilder.Entity<Product>().HasData(new Product

            {
                ProductId = 1,
                ProductName = "ChaiseBoisMassif",
                Price=15,
                CategoryName="categorie1",
                ImageURL= "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQrnd2XJIKTIcFojhx2yEY56Gn8Q-h0IprUAA&usqp=CAU"

            }) ;
            modelBuilder.Entity<Product>().HasData(new Product

            {
                ProductId = 2,
                ProductName = "CLEANSE And Polish",
                Price = 15,
                CategoryName = "categorie1",
                ImageURL = "https://images.ctfassets.net/qfo47mrl3zhx/76QmX0yOLyTl8vNVWpiRvC/e36535dd123b08af7125069c7c845f58/CVS_SH_proactive_1-bybanner.jpg"

            });
        }

    }
}
