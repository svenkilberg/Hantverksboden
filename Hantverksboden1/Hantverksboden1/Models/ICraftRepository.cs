using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hantverksboden1.Models
{
    public interface ICraftRepository
    {
        public IEnumerable<Craft> AllCrafts { get; }        
        Craft GetCraftById(int craftId);
        IEnumerable<Craft> GetCraftByCategory(int categoryID);
    }
}
