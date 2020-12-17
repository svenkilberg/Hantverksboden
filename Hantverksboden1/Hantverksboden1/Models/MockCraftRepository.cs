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
                new Craft {CraftId = 1, Name = "Vägghängd näverkorg", Price = 0.0M, ShortDescription = "Näverkorg att hänga på väggen. Passar bra för till exempel torkade blommor", LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam elit.", ImageLargeUrl = "", ImageThumbnailUrl = "/images/Craft1_small.jpg" , InStock = true},
                new Craft {CraftId = 2, Name = "Näverkorg med handtag", Price = 0.0M, ShortDescription = "Fin näverkorg med handtag. Passar bra som frukt- eller brödkorg.", LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam elit.", ImageLargeUrl = "", ImageThumbnailUrl = "/images/Craft2_small.jpg" , InStock = true},
                new Craft {CraftId = 3, Name = "Hållare för kaffefilter", Price = 0.0M, ShortDescription = "Kaffefilterhållar i näver att hänga på väggen.", LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam elit.", ImageLargeUrl = "", ImageThumbnailUrl = "/images/Craft3_small.jpg" , InStock = true},
                new Craft {CraftId = 4, Name = "Grytunderlägg", Price = 0.0M, ShortDescription = "Grytunderlägg i näver.", LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam elit.", ImageLargeUrl = "", ImageThumbnailUrl = "/images/Craft4_small.jpg" , InStock = true},
                new Craft {CraftId = 5, Name = "Keps", Price = 0.0M, ShortDescription = "Keps tillverkad av näver. Skyddar mot solen samtidigt som den är ventilerad.", LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam elit.", ImageLargeUrl = "", ImageThumbnailUrl = "/images/Craft5_small.jpg" , InStock = true},
            };

        public IEnumerable<Craft> GetCraftByCategory(int categoryID)
        {
            throw new NotImplementedException();
        }

        public Craft GetCraftById(int craftId)
        {
            return AllCrafts.FirstOrDefault(c => c.CraftId == craftId);
        }
    }
}
