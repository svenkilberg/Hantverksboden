using Hantverksboden1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using Xunit;

namespace Hantverksboden1.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void GetCraftsByCategoryTest()
        {
            // Arrange
            List<Craft> craftList = new List<Craft>();

            craftList.Add(new Craft
            {
                CraftId = 1,
                Name = "Craft 1",                
                CategoryId = 1
            });

            craftList.Add(new Craft
            {
                CraftId = 2,
                Name = "Craft 2",                
                CategoryId = 1
            });

            craftList.Add(new Craft
            {
                CraftId = 3,
                Name = "Craft 3",                
                CategoryId = 2
            });

            MockCraftRepository craftRepository = new MockCraftRepository();
            // Act

            IEnumerable<Craft> crafts = craftRepository.GetCraftByCategory(2, craftList);

            // Asert
            int numberOfCrafts = 0;

            foreach(var craft in crafts)
            {
                numberOfCrafts++;
            }

            Assert.Equal(1, numberOfCrafts);
        }
    }
}
