using Hantverksboden1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using Xunit;

namespace Hantverksboden1.Tests
{
    public class CraftRepositoryTests
    {
        [Fact]
        public void GetCraftsByCategoryTest()
        {
            // Arrange
            MockCraftRepository craftRepository = new MockCraftRepository();
            int categoryToGet = 1;
            int categoryToCheck = 1;

            // Act
            IEnumerable<Craft> crafts = craftRepository.GetCraftByCategory(categoryToGet);

            // Asert
            Assert.All(crafts, craft => Assert.Equal(categoryToCheck, craft.CategoryId));
        }

        [Fact]
        public void GetCraftByIdTest()
        {
            //Arrange
            MockCraftRepository craftRepository = new MockCraftRepository();
            int craftIdToGet = 3;
            int craftIdToCheck = 3;

            // Act
            var retrievedCraft = craftRepository.GetCraftById(craftIdToGet);

            // Assert
            Assert.Equal(craftIdToCheck, retrievedCraft.CraftId);
        }
    }
}
