using Microsoft.EntityFrameworkCore;
using Restaurant_api.Models;

namespace Restaurant_api.Data
{
    public class RestaurantDbContext : DbContext
    {
        public RestaurantDbContext(DbContextOptions<RestaurantDbContext> options) : base(options) { }

        public DbSet<MenuItem> MenuItems { get; set; }
        public DbSet<CartItem> CartItems { get; set; }  

        public DbSet<User> Users { get; set; }
     
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<MenuItem>()
               .Property(m => m.Price)
               .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<CartItem>()
                .Property(c => c.Price)
                .HasColumnType("decimal(18,2)");

           

            modelBuilder.Entity<MenuItem>().HasData(
                 new MenuItem
                 {
                     Id = 1,
                     Name = "Spaghetti Bolognese",
                     Description = "Classic Italian pasta dish with meat sauce",
                     PhotoUrl = "Images/spaghetti-bolognese.jpg",
                     Price = 12.99M,
                     Category = "Pasta Dishes",
                     DietaryRestrictions = new List<string> { "None" }
                 },
                new MenuItem
                {
                    Id = 2,
                    Name = "Caesar Salad",
                    Description = "Crisp romaine lettuce with Parmesan cheese and croutons",
                    PhotoUrl = "Images/caesar-salad.jpg",
                    Price = 8.50M,
                    Category = "Salads",
                    DietaryRestrictions = new List<string> { "Vegetarian" }
                },
                new MenuItem
                {
                    Id = 3,
                    Name = "Margherita Pizza",
                    Description = "Traditional Neapolitan pizza with tomato, mozzarella, and basil",
                    PhotoUrl = "Images/margherita-pizza.jpg",
                    Price = 10.75M,
                    Category = "Pizzas",
                    DietaryRestrictions = new List<string> { "None" }
                },
                new MenuItem
                {
                    Id = 4,
                    Name = "Chicken Teriyaki",
                    Description = "Grilled chicken with a sweet and savory teriyaki glaze",
                    PhotoUrl = "Images/chicken-teriyaki.jpg",
                    Price = 11.25M,
                    Category = "Chicken/Beef Dishes",
                    DietaryRestrictions = new List<string> { "None" }
                },
                new MenuItem
                {
                    Id = 5,
                    Name = "Beef Burger",
                    Description = "Juicy beef patty with lettuce, tomato, and pickles",
                    PhotoUrl = "Images/beef-burger.jpg",
                    Price = 9.99M,
                    Category = "Burgers",
                    DietaryRestrictions = new List<string> { "None" }
                },
                new MenuItem
                {
                    Id = 6,
                    Name = "Fish and Chips",
                    Description = "Crispy battered fish served with fries",
                    PhotoUrl = "Images/fish&chips.jpg",
                    Price = 13.50M,
                    Category = "Seafood Dishes",
                    DietaryRestrictions = new List<string> { "None" }
                },
                new MenuItem
                {
                    Id = 7,
                    Name = "Mushroom Risotto",
                    Description = "Creamy Arborio rice cooked with mushrooms and Parmesan",
                    PhotoUrl = "Images/mushroom-risotto.jpg",
                    Price = 10.50M,
                    Category = "Vegetarian Dishes",
                    DietaryRestrictions = new List<string> { "Vegetarian" }
                },
                new MenuItem
                {
                    Id = 8,
                    Name = "Chicken Caesar Wrap",
                    Description = "Grilled chicken, romaine lettuce, and Caesar dressing wrapped in a tortilla",
                    PhotoUrl = "Images/chicken-caesar-wrap.jpg",
                    Price = 9.25M,
                    Category = "Chicken/Beef Dishes",
                    DietaryRestrictions = new List<string> { "None" }
                },
                new MenuItem
                {
                    Id = 9,
                    Name = "Beef Tacos",
                    Description = "Soft corn tortillas filled with seasoned beef and toppings",
                    PhotoUrl = "Images/beef-tacos.jpg",
                    Price = 8.99M,
                    Category = "Chicken/Beef Dishes",
                    DietaryRestrictions = new List<string> { "None" }
                },
                new MenuItem
                {
                    Id = 10,
                    Name = "Penne Arrabiata",
                    Description = "Tubes of pasta in a spicy tomato sauce with garlic and chili",
                    PhotoUrl = "Images/penne-arabiatta.jpg",
                    Price = 10.25M,
                      Category = "Pasta Dishes",
                    DietaryRestrictions = new List<string> { "Vegetarian"}
                },
                new MenuItem
                {
                    Id = 11,
                    Name = "Caprese Salad",
                    Description = "Fresh mozzarella, tomatoes, and basil drizzled with balsamic glaze",
                    PhotoUrl = "Images/caprese-salad.jpg",
                    Price = 9.50M,
                      Category = "Salads",
                    DietaryRestrictions = new List<string> { "Vegetarian", "Gluten-Free" }
                },
                new MenuItem
                {
                    Id = 12,
                    Name = "Chicken Parmesan",
                    Description = "Breaded chicken cutlet topped with tomato sauce and melted cheese",
                    PhotoUrl = "Images/chicken-parmesan.jpg",
                    Price = 12.75M,
                      Category = "Chicken/Beef Dishes",
                    DietaryRestrictions = new List<string> { "None" }
                },
                new MenuItem
                {
                    Id = 13,
                    Name = "Vegetable Stir-Fry",
                    Description = "Assorted vegetables sautéed in a soy-based sauce",
                    PhotoUrl = "Images/vegetable-stir-fry.jpg",
                    Price = 9.75M,
                    Category = "Salads",
                    DietaryRestrictions = new List<string> { "Vegetarian", "Gluten-Free" }
                },
                new MenuItem
                {
                    Id = 14,
                    Name = "Pepperoni Pizza",
                    Description = "Classic pizza topped with pepperoni and mozzarella",
                    PhotoUrl = "Images/pepperoni-pizza.jpg",
                    Price = 11.50M,
                    Category = "Pizzas",
                    DietaryRestrictions = new List<string> { "None" }

                },
                new MenuItem
                {
                    Id = 15,
                    Name = "Shrimp Scampi",
                    Description = "Sautéed shrimp in a garlic and butter sauce served over pasta",
                    PhotoUrl = "Images/shrimp-scampi.jpg",
                    Price = 14.99M,
                       Category = "Seafood Dishes",
                    DietaryRestrictions = new List<string> { "None" }
                },
                new MenuItem
                {
                    Id = 16,
                    Name = "Cobb Salad",
                    Description = "Mixed greens topped with chicken, bacon, avocado, and blue cheese",
                    PhotoUrl = "Images/cobb-salad.jpg",
                    Price = 11.75M,
                    Category = "Salads",
                    DietaryRestrictions = new List<string> { "None" }
                },
                new MenuItem
                {
                    Id = 17,
                    Name = "Beef Stir-Fry",
                    Description = "Tender strips of beef with vegetables in a savory sauce",
                    PhotoUrl = "Images/beef-stir-fry.jpg",
                    Price = 12.25M,
                    Category = "Chicken/Beef Dishes",
                    DietaryRestrictions = new List<string> { "None" }
                },
                new MenuItem
                {
                    Id = 18,
                    Name = "Cheeseburger",
                    Description = "Classic beef patty with melted cheese on a bun",
                    PhotoUrl = "Images/cheeseburger.jpg",
                    Price = 8.75M,
                       Category = "Burgers",
                    DietaryRestrictions = new List<string> { "None" }
                },
                new MenuItem
                {
                    Id = 19,
                    Name = "Chicken Alfredo",
                    Description = "Grilled chicken with fettuccine in a creamy Alfredo sauce",
                    PhotoUrl = "Images/chicken-alfredo.jpg",
                    Price = 13.25M,
                    Category = "Chicken/Beef Dishes",
                    DietaryRestrictions = new List<string> { "None" }
                }
           );
        }
    }
}
