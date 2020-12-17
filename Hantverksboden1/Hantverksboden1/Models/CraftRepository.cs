using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hantverksboden1.Models
{
    public class CraftRepository : ICraftRepository
    {
        private readonly AppDbContext _appDbContext;
        
        public CraftRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Craft> AllCrafts
        { 
            get
            {
                return _appDbContext.Crafts.Include(c => c.Category);
            }
        }       

        public IEnumerable<Craft> CraftsByCategory;

        public Craft GetCraftById(int craftId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Craft> GetCraftByCategory(int categoryId, IEnumerable<Craft> allCrafts)
        {
            return allCrafts.Where(cr => cr.CategoryId == categoryId);            
        }        
    }
}
