﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Restaurant_api.Data;

#nullable disable

namespace Restaurant_api.Migrations
{
    [DbContext(typeof(RestaurantDbContext))]
    [Migration("20240607213848_UpdateCartItemRelationship")]
    partial class UpdateCartItemRelationship
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Restaurant_api.Models.CartItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("MenuItemId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhotoUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("Restaurant_api.Models.MenuItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DietaryRestrictions")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhotoUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("MenuItems");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Category = "Pasta Dishes",
                            Description = "Classic Italian pasta dish with meat sauce",
                            DietaryRestrictions = "[\"None\"]",
                            Name = "Spaghetti Bolognese",
                            PhotoUrl = "Images/spaghetti-bolognese.jpg",
                            Price = 12.99m
                        },
                        new
                        {
                            Id = 2,
                            Category = "Salads",
                            Description = "Crisp romaine lettuce with Parmesan cheese and croutons",
                            DietaryRestrictions = "[\"Vegetarian\"]",
                            Name = "Caesar Salad",
                            PhotoUrl = "Images/caesar-salad.jpg",
                            Price = 8.50m
                        },
                        new
                        {
                            Id = 3,
                            Category = "Pizzas",
                            Description = "Traditional Neapolitan pizza with tomato, mozzarella, and basil",
                            DietaryRestrictions = "[\"None\"]",
                            Name = "Margherita Pizza",
                            PhotoUrl = "Images/margherita-pizza.jpg",
                            Price = 10.75m
                        },
                        new
                        {
                            Id = 4,
                            Category = "Chicken/Beef Dishes",
                            Description = "Grilled chicken with a sweet and savory teriyaki glaze",
                            DietaryRestrictions = "[\"None\"]",
                            Name = "Chicken Teriyaki",
                            PhotoUrl = "Images/chicken-teriyaki.jpg",
                            Price = 11.25m
                        },
                        new
                        {
                            Id = 5,
                            Category = "Burgers",
                            Description = "Juicy beef patty with lettuce, tomato, and pickles",
                            DietaryRestrictions = "[\"None\"]",
                            Name = "Beef Burger",
                            PhotoUrl = "Images/beef-burger.jpg",
                            Price = 9.99m
                        },
                        new
                        {
                            Id = 6,
                            Category = "Seafood Dishes",
                            Description = "Crispy battered fish served with fries",
                            DietaryRestrictions = "[\"None\"]",
                            Name = "Fish and Chips",
                            PhotoUrl = "Images/fish&chips.jpg",
                            Price = 13.50m
                        },
                        new
                        {
                            Id = 7,
                            Category = "Vegetarian Dishes",
                            Description = "Creamy Arborio rice cooked with mushrooms and Parmesan",
                            DietaryRestrictions = "[\"Vegetarian\"]",
                            Name = "Mushroom Risotto",
                            PhotoUrl = "Images/mushroom-risotto.jpg",
                            Price = 10.50m
                        },
                        new
                        {
                            Id = 8,
                            Category = "Chicken/Beef Dishes",
                            Description = "Grilled chicken, romaine lettuce, and Caesar dressing wrapped in a tortilla",
                            DietaryRestrictions = "[\"None\"]",
                            Name = "Chicken Caesar Wrap",
                            PhotoUrl = "Images/chicken-caesar-wrap.jpg",
                            Price = 9.25m
                        },
                        new
                        {
                            Id = 9,
                            Category = "Chicken/Beef Dishes",
                            Description = "Soft corn tortillas filled with seasoned beef and toppings",
                            DietaryRestrictions = "[\"None\"]",
                            Name = "Beef Tacos",
                            PhotoUrl = "Images/beef-tacos.jpg",
                            Price = 8.99m
                        },
                        new
                        {
                            Id = 10,
                            Category = "Pasta Dishes",
                            Description = "Tubes of pasta in a spicy tomato sauce with garlic and chili",
                            DietaryRestrictions = "[\"Vegetarian\"]",
                            Name = "Penne Arrabiata",
                            PhotoUrl = "Images/penne-arabiatta.jpg",
                            Price = 10.25m
                        },
                        new
                        {
                            Id = 11,
                            Category = "Salads",
                            Description = "Fresh mozzarella, tomatoes, and basil drizzled with balsamic glaze",
                            DietaryRestrictions = "[\"Vegetarian\",\"Gluten-Free\"]",
                            Name = "Caprese Salad",
                            PhotoUrl = "Images/caprese-salad.jpg",
                            Price = 9.50m
                        },
                        new
                        {
                            Id = 12,
                            Category = "Chicken/Beef Dishes",
                            Description = "Breaded chicken cutlet topped with tomato sauce and melted cheese",
                            DietaryRestrictions = "[\"None\"]",
                            Name = "Chicken Parmesan",
                            PhotoUrl = "Images/chicken-parmesan.jpg",
                            Price = 12.75m
                        },
                        new
                        {
                            Id = 13,
                            Category = "Salads",
                            Description = "Assorted vegetables sautéed in a soy-based sauce",
                            DietaryRestrictions = "[\"Vegetarian\",\"Gluten-Free\"]",
                            Name = "Vegetable Stir-Fry",
                            PhotoUrl = "Images/vegetable-stir-fry.jpg",
                            Price = 9.75m
                        },
                        new
                        {
                            Id = 14,
                            Category = "Pizzas",
                            Description = "Classic pizza topped with pepperoni and mozzarella",
                            DietaryRestrictions = "[\"None\"]",
                            Name = "Pepperoni Pizza",
                            PhotoUrl = "Images/pepperoni-pizza.jpg",
                            Price = 11.50m
                        },
                        new
                        {
                            Id = 15,
                            Category = "Seafood Dishes",
                            Description = "Sautéed shrimp in a garlic and butter sauce served over pasta",
                            DietaryRestrictions = "[\"None\"]",
                            Name = "Shrimp Scampi",
                            PhotoUrl = "Images/shrimp-scampi.jpg",
                            Price = 14.99m
                        },
                        new
                        {
                            Id = 16,
                            Category = "Salads",
                            Description = "Mixed greens topped with chicken, bacon, avocado, and blue cheese",
                            DietaryRestrictions = "[\"None\"]",
                            Name = "Cobb Salad",
                            PhotoUrl = "Images/cobb-salad.jpg",
                            Price = 11.75m
                        },
                        new
                        {
                            Id = 17,
                            Category = "Chicken/Beef Dishes",
                            Description = "Tender strips of beef with vegetables in a savory sauce",
                            DietaryRestrictions = "[\"None\"]",
                            Name = "Beef Stir-Fry",
                            PhotoUrl = "Images/beef-stir-fry.jpg",
                            Price = 12.25m
                        },
                        new
                        {
                            Id = 18,
                            Category = "Burgers",
                            Description = "Classic beef patty with melted cheese on a bun",
                            DietaryRestrictions = "[\"None\"]",
                            Name = "Cheeseburger",
                            PhotoUrl = "Images/cheeseburger.jpg",
                            Price = 8.75m
                        },
                        new
                        {
                            Id = 19,
                            Category = "Chicken/Beef Dishes",
                            Description = "Grilled chicken with fettuccine in a creamy Alfredo sauce",
                            DietaryRestrictions = "[\"None\"]",
                            Name = "Chicken Alfredo",
                            PhotoUrl = "Images/chicken-alfredo.jpg",
                            Price = 13.25m
                        });
                });

            modelBuilder.Entity("Restaurant_api.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Restaurant_api.Models.CartItem", b =>
                {
                    b.HasOne("Restaurant_api.Models.User", "User")
                        .WithMany("CartItems")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Restaurant_api.Models.User", b =>
                {
                    b.Navigation("CartItems");
                });
#pragma warning restore 612, 618
        }
    }
}
