using Microsoft.EntityFrameworkCore;
using Selu383.SP25.P03.Api.Data;
using Selu383.SP25.P03.Api.Features.Food;

namespace Selu383.SP25.P03.Api.Data
{
    public static class SeedFood
    {
        public static void Initalize(IServiceProvider serviceProvider)
        {
            using (var context = new DataContext(serviceProvider.GetRequiredService<DbContextOptions<DataContext>>()))
            {
                if (context.Foods.Any())
                {
                    return;
                }

                var foods = new List<Food>
                {
                // Snacks
                new Food { Name = "Popcorn", Description = "Classic buttery popcorn", ImageUrl = "https://images.unsplash.com/photo-1588854337236-f9c1f1f24b1f", Price = 5.99m, Category = "Snacks" },
                new Food { Name = "Nachos", Description = "Cheesy nachos with jalapeños", ImageUrl = "https://images.unsplash.com/photo-1600891964599-f61ba0e24092", Price = 6.99m, Category = "Snacks" },
                new Food { Name = "Hotdog", Description = "Grilled hotdog with mustard", ImageUrl = "https://images.unsplash.com/photo-1552332386-f8dd00dc2f85", Price = 4.99m, Category = "Snacks" },
                new Food { Name = "Soft Pretzel", Description = "Warm salted soft pretzel", ImageUrl = "https://images.unsplash.com/photo-1604908177340-e9099b4f50ce", Price = 3.99m, Category = "Snacks" },
                new Food { Name = "Cheese Sticks", Description = "Crispy fried mozzarella sticks", ImageUrl = "https://images.unsplash.com/photo-1587241321927-9d8e1ff3aefb", Price = 5.49m, Category = "Snacks" },
                new Food { Name = "Chicken Tenders", Description = "Golden fried chicken tenders", ImageUrl = "https://images.unsplash.com/photo-1604908554161-c017fdbb0450", Price = 7.49m, Category = "Snacks" },
                    
                // Candy
                new Food { Name = "M&M's", Description = "Milk chocolate candy", ImageUrl = "https://images.unsplash.com/photo-1615332587121-72d7a9c2a308", Price = 2.99m, Category = "Candy" },
                new Food { Name = "Skittles", Description = "Fruit-flavored candy", ImageUrl = "https://images.unsplash.com/photo-1601221328884-e7f2b863e2ce", Price = 2.99m, Category = "Candy" },
                new Food { Name = "Twizzlers", Description = "Strawberry flavored licorice", ImageUrl = "https://images.unsplash.com/photo-1626947343469-7e149924c7d2", Price = 2.99m, Category = "Candy" },
                new Food { Name = "Reese’s Pieces", Description = "Peanut butter candy", ImageUrl = "https://images.unsplash.com/photo-1625937320210-2bb4bc944af8", Price = 3.49m, Category = "Candy" },

                    // Drinks
                new Food { Name = "Coke", Description = "Chilled Coca-Cola", ImageUrl = "https://images.unsplash.com/photo-1573140247632-f8fd74997d5c", Price = 3.49m, Category = "Drinks" },
                new Food { Name = "Sprite", Description = "Refreshing lemon-lime soda", ImageUrl = "https://images.unsplash.com/photo-1604908177965-8d6c77b6ac44", Price = 3.49m, Category = "Drinks" },
                new Food { Name = "Water", Description = "Bottled spring water", ImageUrl = "https://images.unsplash.com/photo-1587213811864-c5cfec9f0f9a", Price = 2.49m, Category = "Drinks" },
                new Food { Name = "Iced Tea", Description = "Cold sweetened iced tea", ImageUrl = "https://images.unsplash.com/photo-1550510537-64c99c54f17b", Price = 3.49m, Category = "Drinks" }
                };

                context.Foods.AddRange(foods);
                context.SaveChanges();

            }
        }
    }
}

