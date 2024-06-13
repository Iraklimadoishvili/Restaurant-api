using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Restaurant_api.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CartItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MenuItemId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhotoUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MenuItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhotoUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DietaryRestrictions = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuItems", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "Id", "Category", "Description", "DietaryRestrictions", "Name", "PhotoUrl", "Price" },
                values: new object[,]
                {
                    { 1, "Pasta Dishes", "Classic Italian pasta dish with meat sauce", "[\"None\"]", "Spaghetti Bolognese", "Images/spaghetti-bolognese.jpg", 12.99m },
                    { 2, "Salads", "Crisp romaine lettuce with Parmesan cheese and croutons", "[\"Vegetarian\"]", "Caesar Salad", "Images/caesar-salad.jpg", 8.50m },
                    { 3, "Pizzas", "Traditional Neapolitan pizza with tomato, mozzarella, and basil", "[\"None\"]", "Margherita Pizza", "Images/margherita-pizza.jpg", 10.75m },
                    { 4, "Chicken/Beef Dishes", "Grilled chicken with a sweet and savory teriyaki glaze", "[\"None\"]", "Chicken Teriyaki", "Images/chicken-teriyaki.jpg", 11.25m },
                    { 5, "Burgers", "Juicy beef patty with lettuce, tomato, and pickles", "[\"None\"]", "Beef Burger", "Images/beef-burger.jpg", 9.99m },
                    { 6, "Seafood Dishes", "Crispy battered fish served with fries", "[\"None\"]", "Fish and Chips", "Images/fish&chips.jpg", 13.50m },
                    { 7, "Vegetarian Dishes", "Creamy Arborio rice cooked with mushrooms and Parmesan", "[\"Vegetarian\"]", "Mushroom Risotto", "Images/mushroom-risotto.jpg", 10.50m },
                    { 8, "Chicken/Beef Dishes", "Grilled chicken, romaine lettuce, and Caesar dressing wrapped in a tortilla", "[\"None\"]", "Chicken Caesar Wrap", "Images/chicken-caesar-wrap.jpg", 9.25m },
                    { 9, "Chicken/Beef Dishes", "Soft corn tortillas filled with seasoned beef and toppings", "[\"None\"]", "Beef Tacos", "Images/beef-tacos.jpg", 8.99m },
                    { 10, "Pasta Dishes", "Tubes of pasta in a spicy tomato sauce with garlic and chili", "[\"Vegetarian\"]", "Penne Arrabiata", "Images/penne-arabiatta.jpg", 10.25m },
                    { 11, "Salads", "Fresh mozzarella, tomatoes, and basil drizzled with balsamic glaze", "[\"Vegetarian\",\"Gluten-Free\"]", "Caprese Salad", "Images/caprese-salad.jpg", 9.50m },
                    { 12, "Chicken/Beef Dishes", "Breaded chicken cutlet topped with tomato sauce and melted cheese", "[\"None\"]", "Chicken Parmesan", "Images/chicken-parmesan.jpg", 12.75m },
                    { 13, "Salads", "Assorted vegetables sautéed in a soy-based sauce", "[\"Vegetarian\",\"Gluten-Free\"]", "Vegetable Stir-Fry", "Images/vegetable-stir-fry.jpg", 9.75m },
                    { 14, "Pizzas", "Classic pizza topped with pepperoni and mozzarella", "[\"None\"]", "Pepperoni Pizza", "Images/pepperoni-pizza.jpg", 11.50m },
                    { 15, "Seafood Dishes", "Sautéed shrimp in a garlic and butter sauce served over pasta", "[\"None\"]", "Shrimp Scampi", "Images/shrimp-scampi.jpg", 14.99m },
                    { 16, "Salads", "Mixed greens topped with chicken, bacon, avocado, and blue cheese", "[\"None\"]", "Cobb Salad", "Images/cobb-salad.jpg", 11.75m },
                    { 17, "Chicken/Beef Dishes", "Tender strips of beef with vegetables in a savory sauce", "[\"None\"]", "Beef Stir-Fry", "Images/beef-stir-fry.jpg", 12.25m },
                    { 18, "Burgers", "Classic beef patty with melted cheese on a bun", "[\"None\"]", "Cheeseburger", "Images/cheeseburger.jpg", 8.75m },
                    { 19, "Chicken/Beef Dishes", "Grilled chicken with fettuccine in a creamy Alfredo sauce", "[\"None\"]", "Chicken Alfredo", "Images/chicken-alfredo.jpg", 13.25m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartItems");

            migrationBuilder.DropTable(
                name: "MenuItems");
        }
    }
}
