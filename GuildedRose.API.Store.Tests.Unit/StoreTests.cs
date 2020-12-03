using System.Collections.Generic;
using Xunit;
using GuildedRose.API.Store.Models;
using GuildedRose.API.Store.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace GuildedRose.API.Store.Tests.Unit
{
    public class StoreTests
    {
        const string singleItem = "A11111";
        const string listofItems = "A11111&id=B22222";

        [Fact]
        public void Get_ReturnsListOfStoreItems()
        {
            var options = new DbContextOptionsBuilder<StoreItemContext>().UseInMemoryDatabase(databaseName: "StoreItems").Options;

            using (var context = new StoreItemContext(options))
            {
                StoreRepository _controller = new StoreRepository(context);
                var ok = _controller.GetItems();

                var items = Assert.IsAssignableFrom<List<StoreItem>>(ok.Result.Value);

                Assert.Equal(6, items.Count);
            }
        }

        [Fact]
        public void Get_ReturnsOneStoreItems()
        {
            var options = new DbContextOptionsBuilder<StoreItemContext>().UseInMemoryDatabase(databaseName: "StoreItems").Options;

            using (var context = new StoreItemContext(options))
            {
                StoreRepository _controller = new StoreRepository(context);
                var ok = _controller.GetStoreItem(singleItem);

                Assert.IsType<ActionResult<StoreItem>>(ok.Result);

                Assert.Equal("Widget One", ok.Result.Value.Name);

            }
        }
    }
}
