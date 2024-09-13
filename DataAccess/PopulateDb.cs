using Microsoft.EntityFrameworkCore;
using DomainModels;
using DomainModels.Enums;

namespace DataAccess
{
    public static class PopulateDb
    {
        public static void Seed(ModelBuilder builder)
        {
            builder.Entity<Beverage>()
                .HasData(new List<Beverage>
                {
                    new Beverage
                    {
                        Id = 1,
                        Name = "Jameson",
                        Type = BeverageType.Alcohol,
                        Quantity = 100,
                        Price = 29.99m,
                        Description = "Jameson Irish Whiskey, triple distilled for a smooth taste.",
                        ImageUrl = "https://example.com/images/jameson.jpg"
                    },
                    new Beverage
                    {
                        Id = 2,
                        Name = "Jack Daniel's",
                        Type = BeverageType.Alcohol,
                        Quantity = 150,
                        Price = 35.99m,
                        Description = "Jack Daniel's Tennessee Whiskey, a classic American favorite.",
                        ImageUrl = "https://example.com/images/jackdaniels.jpg"
                    },
                    new Beverage
                    {
                        Id = 3,
                        Name = "Johnnie Walker",
                        Type = BeverageType.Alcohol,
                        Quantity = 120,
                        Price = 39.99m,
                        Description = "Johnnie Walker Black Label, a refined blend of Scotch whisky.",
                        ImageUrl = "https://example.com/images/johnniewalker.jpg"
                    },
                    new Beverage
                    {
                        Id = 4,
                        Name = "Absolut Vodka",
                        Type = BeverageType.Alcohol,
                        Quantity = 200,
                        Price = 19.99m,
                        Description = "Absolut Vodka, pure and smooth, perfect for cocktails.",
                        ImageUrl = "https://example.com/images/absolutvodka.jpg"
                    },
                    new Beverage
                    {
                        Id = 5,
                        Name = "Havana Club",
                        Type = BeverageType.Alcohol,
                        Quantity = 80,
                        Price = 25.99m,
                        Description = "Havana Club is a Cuban rum, known for its rich flavor and smooth finish.",
                        ImageUrl = "https://example.com/images/havana_club"
                    },
                    new Beverage
                    {
                        Id = 6,
                        Name = "Coca-Cola",
                        Type = BeverageType.SoftDrink,
                        Quantity = 300,
                        Price = 1.99m,
                        Description = "Classic Coca-Cola, the refreshing taste you love.",
                        ImageUrl = "https://example.com/images/cocacola.jpg"
                    },
                    new Beverage
                    {
                        Id = 7,
                        Name = "Pepsi",
                        Type = BeverageType.SoftDrink,
                        Quantity = 280,
                        Price = 1.89m,
                        Description = "Pepsi Cola, bold and refreshing with every sip.",
                        ImageUrl = "https://example.com/images/pepsi.jpg"
                    },
                    new Beverage
                    {
                        Id = 8,
                        Name = "Sprite",
                        Type = BeverageType.SoftDrink,
                        Quantity = 270,
                        Price = 1.79m,
                        Description = "Sprite, lemon-lime soda with a crisp and clean taste.",
                        ImageUrl = "https://example.com/images/sprite.jpg"
                    },
                    new Beverage
                    {
                        Id = 9,
                        Name = "Fanta",
                        Type = BeverageType.SoftDrink,
                        Quantity = 260,
                        Price = 1.69m,
                        Description = "Fanta, fruity and fun with a burst of orange flavor.",
                        ImageUrl = "https://example.com/images/fanta.jpg"
                    },
                    new Beverage
                    {
                        Id = 10,
                        Name = "7-Up",
                        Type = BeverageType.SoftDrink,
                        Quantity = 250,
                        Price = 1.59m,
                        Description = "7-Up, the refreshing lemon-lime soda everyone loves.",
                        ImageUrl = "https://example.com/images/7up.jpg"
                    },
                    new Beverage
                    {
                        Id = 11,
                        Name = "Heineken",
                        Type = BeverageType.Beer,
                        Quantity = 220,
                        Price = 3.99m,
                        Description = "Heineken, a world-renowned Dutch lager.",
                        ImageUrl = "https://example.com/images/heineken.jpg"
                    },
                    new Beverage
                    {
                        Id = 12,
                        Name = "Budweiser",
                        Type = BeverageType.Beer,
                        Quantity = 210,
                        Price = 2.99m,
                        Description = "Budweiser, the King of Beers with a smooth and crisp finish.",
                        ImageUrl = "https://example.com/images/budweiser.jpg"
                    },
                    new Beverage
                    {
                        Id = 13,
                        Name = "Corona",
                        Type = BeverageType.Beer,
                        Quantity = 230,
                        Price = 4.49m,
                        Description = "Corona Extra, perfect for those sunny beach days.",
                        ImageUrl = "https://example.com/images/corona.jpg"
                    },
                    new Beverage
                    {
                        Id = 14,
                        Name = "Stella Artois",
                        Type = BeverageType.Beer,
                        Quantity = 240,
                        Price = 4.29m,
                        Description = "Stella Artois, a Belgian pilsner of premium quality.",
                        ImageUrl = "https://example.com/images/stellaartois.jpg"
                    },
                    new Beverage
                    {
                        Id = 15,
                        Name = "Guinness",
                        Type = BeverageType.Beer,
                        Quantity = 200,
                        Price = 4.99m,
                        Description = "Guinness, the iconic Irish stout with a rich and creamy flavor.",
                        ImageUrl = "https://example.com/images/guinness.jpg"
                    },
                    new Beverage
                    {
                        Id = 16,
                        Name = "Carlsberg",
                        Type = BeverageType.Beer,
                        Quantity = 200,
                        Price = 4.99m,
                        Description = "Carlsberg, probably the best beer in the world.",
                        ImageUrl = "https://example.com/images/carlsberg.jpg"
                    }
                });
        }
    }
}
