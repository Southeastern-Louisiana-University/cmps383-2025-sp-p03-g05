using Selu383.SP25.P03.Api.Data.Models; 

namespace Selu383.SP25.P03.Api.Data
{
    public static class FoodSeeder
    {
        public static void SeedFood(ApplicationDbContext context)
        {
            if (!context.Foods.Any())
            {
                var foods = new List<Food>
                {
                    
                    new Food { Name = "Popcorn", Description = "Classic buttery popcorn", ImageUrl = "https://images.unsplash.com/photo-1588854337236-f9c1f1f24b1f", Price = 5.99m },
                    new Food { Name = "Nachos", Description = "Cheesy nachos with jalapeños", ImageUrl = "https://images.unsplash.com/photo-1600891964599-f61ba0e24092", Price = 6.99m },
                    new Food { Name = "Hotdog", Description = "Grilled hotdog with mustard", ImageUrl = "https://images.unsplash.com/photo-1552332386-f8dd00dc2f85", Price = 4.99m },
                    new Food { Name = "Soft Pretzel", Description = "Warm salted soft pretzel", ImageUrl = "https://images.unsplash.com/photo-1604908177340-e9099b4f50ce", Price = 3.99m },
                    new Food { Name = "Cheese Sticks", Description = "Crispy fried mozzarella sticks", ImageUrl = "https://images.unsplash.com/photo-1587241321927-9d8e1ff3aefb", Price = 5.49m },
                    new Food { Name = "Chicken Tenders", Description = "Golden fried chicken tenders", ImageUrl = "https://images.unsplash.com/photo-1604908554161-c017fdbb0450", Price = 7.49m },

                    
                    new Food { Name = "M&M's", Description = "Milk chocolate candy", ImageUrl = "https://images.unsplash.com/photo-1615332587121-72d7a9c2a308", Price = 2.99m },
                    new Food { Name = "Skittles", Description = "Fruit-flavored candy", ImageUrl = "https://images.unsplash.com/photo-1601221328884-e7f2b863e2ce", Price = 2.99m },
                    new Food { Name = "Twizzlers", Description = "Strawberry flavored licorice", ImageUrl = "https://images.unsplash.com/photo-1626947343469-7e149924c7d2", Price = 2.99m },
                    new Food { Name = "Reese’s Pieces", Description = "Peanut butter candy", ImageUrl = "https://images.unsplash.com/photo-1625937320210-2bb4bc944af8", Price = 3.49m },

                    // Drinks
                    new Food { Name = "Coke", Description = "Chilled Coca-Cola", ImageUrl = "https://images.unsplash.com/photo-1573140247632-f8fd74997d5c", Price = 3.49m },
                    new Food { Name = "Pepsi", Description = "Refreshing Pepsi", ImageUrl = "https://images.unsplash.com/photo-1581622311783-0d7a85b2c83a", Price = 3.49m },
                    new Food { Name = "Sprite", Description = "Lemon-lime soda", ImageUrl = "https://images.unsplash.com/photo-1620329421088-3cfbfc78e1eb", Price = 3.49m },
                    new Food { Name = "Iced Tea", Description = "Sweet iced tea", ImageUrl = "https://images.unsplash.com/photo-1572569511254-d8f925fe4f40", Price = 2.99m },
                    new Food { Name = "Water Bottle", Description = "Chilled bottled water", ImageUrl = "https://images.unsplash.com/photo-1612197525345-df36599d8f65", Price = 1.99m },
                    new Food { Name = "Slushie", Description = "Frozen flavored drink", ImageUrl = "https://images.unsplash.com/photo-1601915074086-c6aece99f1f2", Price = 4.29m }
                };

                context.Foods.AddRange(foods);
                context.SaveChanges();
            }
        }
    }
}
