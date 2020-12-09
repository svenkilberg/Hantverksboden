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
                new Craft {CraftId = 1, Name = "Craft 1", Price = 0.0M, ShortDescription = "Lorem Ipsum", LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam elit.", ImageLargeUrl = "", ImageThumbnailUrl = "" , InStock = true},
                new Craft {CraftId = 2, Name = "Craft 2", Price = 0.0M, ShortDescription = "Lorem Ipsum", LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam elit.", ImageLargeUrl = "", ImageThumbnailUrl = "" , InStock = true},
                new Craft {CraftId = 3, Name = "Craft 3", Price = 0.0M, ShortDescription = "Lorem Ipsum", LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam elit.", ImageLargeUrl = "", ImageThumbnailUrl = "" , InStock = true},
                new Craft {CraftId = 4, Name = "Craft 4", Price = 0.0M, ShortDescription = "Lorem Ipsum", LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam elit.", ImageLargeUrl = "", ImageThumbnailUrl = "" , InStock = true},
                new Craft {CraftId = 5, Name = "Craft 5", Price = 0.0M, ShortDescription = "Lorem Ipsum", LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam elit.", ImageLargeUrl = "", ImageThumbnailUrl = "" , InStock = true},
            };

        public Craft GetCraftById(int craftId)
        {
            return AllCrafts.FirstOrDefault(c => c.CraftId == craftId);
        }
    }
}
