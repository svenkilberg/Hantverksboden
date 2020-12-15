using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Hantverksboden1.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            this.Database.EnsureCreated();
        }

        public DbSet<Craft> Crafts { get; set; }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //seed categories
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Näverslöjd" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Svepaskar" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Virkning" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 4, CategoryName = "Tavlor" });
            
            //seed crafts
            modelBuilder.Entity<Craft>().HasData(new Craft
                {
                CraftId = 1,
                Name = "Vägghängd näverkorg",
                Price = 0.0M,
                ShortDescription = "Näverkorg att hänga på väggen. Passar bra för till exempel torkade blommor",
                LongDescription = "",
                ImageLargeUrl = "",
                ImageThumbnailUrl = "/images/Craft1_small.jpg",
                InStock = true,
                CategoryId = 1
            });

            modelBuilder.Entity<Craft>().HasData(new Craft 
            {
                CraftId = 2,
                Name = "Näverkorg med handtag",
                Price = 0.0M,
                ShortDescription = "Fin näverkorg med handtag. Passar bra som frukt- eller brödkorg.",
                LongDescription = "",
                ImageLargeUrl = "",
                ImageThumbnailUrl = "/images/Craft2_small.jpg",
                InStock = true,
                CategoryId = 1
            });

            modelBuilder.Entity<Craft>().HasData(new Craft 
            {
                CraftId = 3,
                Name = "Hållare för kaffefilter",
                Price = 0.0M,
                ShortDescription = "Kaffefilterhållar i näver att hänga på väggen.",
                LongDescription = "",
                ImageLargeUrl = "",
                ImageThumbnailUrl = "/images/Craft3_small.jpg",
                InStock = true,
                CategoryId = 1
            });

            modelBuilder.Entity<Craft>().HasData(new Craft 
            {
                CraftId = 4,
                Name = "Grytunderlägg",
                Price = 0.0M,
                ShortDescription = "Grytunderlägg i näver.",
                LongDescription = "",
                ImageLargeUrl = "",
                ImageThumbnailUrl = "/images/Craft4_small.jpg",
                InStock = true,
                CategoryId = 1
            });

            modelBuilder.Entity<Craft>().HasData(new Craft 
            {
                CraftId = 5,
                Name = "Keps",
                Price = 0.0M,
                ShortDescription = "Keps tillverkad av näver. Skyddar mot solen samtidigt som den är ventilerad.",
                LongDescription = "",
                ImageLargeUrl = "",
                ImageThumbnailUrl = "/images/Craft5_small.jpg",
                InStock = true,
                CategoryId = 1
            });

            modelBuilder.Entity<Craft>().HasData(new Craft
            {
                CraftId = 6,
                Name = "Test test",
                Price = 0.0M,
                ShortDescription = "Test eli test test.",
                LongDescription = "",
                ImageLargeUrl = "",
                ImageThumbnailUrl = "",
                InStock = true,
                CategoryId = 1
            });
        }
    }
}
