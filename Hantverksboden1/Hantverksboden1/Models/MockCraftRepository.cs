using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hantverksboden1.Models
{
    public class MockCraftRepository : ICraftRepository
    {
        public IEnumerable<Craft> AllCrafts =>
            new List<Craft>
            {
                new Craft {CraftId = 1,
                Name = "Vägghängd näverkorg",
                Price = 0.0M,
                ShortDescription = "Näverkorg att hänga på väggen. Passar bra för till exempel torkade blommor",
                LongDescription = "",
                ImageLargeUrl = "",
                ImageThumbnailUrl = "/images/Craft1_small.jpg",
                InStock = true,
                CategoryId = 1},
                new Craft {CraftId = 2,
                Name = "Näverkorg med handtag",
                Price = 0.0M,
                ShortDescription = "Fin näverkorg med handtag. Passar bra som frukt- eller brödkorg.",
                LongDescription = "",
                ImageLargeUrl = "",
                ImageThumbnailUrl = "/images/Craft2_small.jpg",
                InStock = true,
                CategoryId = 1},
                new Craft {CraftId = 3,
                Name = "Svepask oval",
                Price = 0.0M,
                ShortDescription = "Oval svepask med lock.",
                LongDescription = "",
                ImageLargeUrl = "",
                ImageThumbnailUrl = "/images/Svepteknik1_small.jpg",
                InStock = true,
                CategoryId = 2},
                new Craft {CraftId = 4,
                Name = "Svepask rund",
                Price = 0.0M,
                ShortDescription = "Rund svepask med lock.",
                LongDescription = "",
                ImageLargeUrl = "",
                ImageThumbnailUrl = "/images/Svepteknik2_small.jpg",
                InStock = true,
                CategoryId = 2 },
                new Craft {CraftId = 5,
                Name = "Svepkorg oval",
                Price = 0.0M,
                ShortDescription = "Oval svepkorg med handtag.",
                LongDescription = "",
                ImageLargeUrl = "",
                ImageThumbnailUrl = "/images/Svepteknik3_small.jpg",
                InStock = true,
                CategoryId = 2},
            };
        
        public IEnumerable<Craft> GetCraftByCategory(int categoryId)
        {
            return AllCrafts.Where(cr => cr.CategoryId == categoryId);
        }

        public Craft GetCraftById(int craftId)
        {
            return AllCrafts.FirstOrDefault(c => c.CraftId == craftId);
        }
    }
}
