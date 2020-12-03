using System;
namespace GuildedRose.API.Store.Models
{
    public static class StoreItemSeed
    {
       public static void InitializeData(StoreItemContext context)
        {
            _ = context.Items.Add(new StoreItem
            {
                Id = "A11111",
                Price = "9.99",
                Name = "Widget One",
                Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit.",
                url = "http://placehold.it/700x400",
                Rating = 3M,
                InventoryCount = 1
            });

            _ = context.Items.Add(new StoreItem
            {
                Id = "B22222",
                Price = "35.00",
                Name = "Whoozit Two",
                Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit.",
                url = "http://placehold.it/700x400",
                Rating = 1M,
                InventoryCount = 2

            });

            _ = context.Items.Add(new StoreItem
            {
                Id = "C33333",
                Price = "59.99",
                Name = "Fizbit Three",
                Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Amet numquam aspernatur! Lorem ipsum dolor sit amet.",
                url = "http://placehold.it/700x400",
                Rating = 4M,
                InventoryCount = 3

            });

            _ = context.Items.Add(new StoreItem
            {
                Id = "D44444",
                Price = "54.00",
                Name = "Fizbit One",
                Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Amet numquam aspernatur! Lorem ipsum dolor sit amet.",
                url = "http://placehold.it/700x400",
                Rating = 3M,
                InventoryCount = 5

            });

            _ = context.Items.Add(new StoreItem
            {
                Id = "E55555",
                Price = "19.99",
                Name = "Widget Two",
                Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit.",
                url = "http://placehold.it/700x400",
                Rating = 5M,
                InventoryCount = 5

            });

            _ = context.Items.Add(new StoreItem
            {
                Id = "F66666",
                Price = "9.99",
                Name = "Widget Three",
                Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit.",
                url = "http://placehold.it/700x400",
                Rating = 4M,
                InventoryCount = 5

            });

            context.SaveChanges();
        }
    }
}
