
using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class addBeverage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Beverages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Beverages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Beverages",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "DeletedBy", "DeletedOn", "Description", "ImageUrl", "ModifiedBy", "ModifiedOn", "Name", "Price", "Quantity", "Type" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 9, 13, 14, 51, 28, 799, DateTimeKind.Local).AddTicks(6998), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jameson Irish Whiskey, triple distilled for a smooth taste.", "https://example.com/images/jameson.jpg", 1, new DateTime(2024, 9, 13, 14, 51, 28, 799, DateTimeKind.Local).AddTicks(7028), "Jameson", 29.99m, 100, 1 },
                    { 2, 1, new DateTime(2024, 9, 13, 14, 51, 28, 799, DateTimeKind.Local).AddTicks(7038), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jack Daniel's Tennessee Whiskey, a classic American favorite.", "https://example.com/images/jackdaniels.jpg", 1, new DateTime(2024, 9, 13, 14, 51, 28, 799, DateTimeKind.Local).AddTicks(7039), "Jack Daniel's", 35.99m, 150, 1 },
                    { 3, 1, new DateTime(2024, 9, 13, 14, 51, 28, 799, DateTimeKind.Local).AddTicks(7042), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Johnnie Walker Black Label, a refined blend of Scotch whisky.", "https://example.com/images/johnniewalker.jpg", 1, new DateTime(2024, 9, 13, 14, 51, 28, 799, DateTimeKind.Local).AddTicks(7043), "Johnnie Walker", 39.99m, 120, 1 },
                    { 4, 1, new DateTime(2024, 9, 13, 14, 51, 28, 799, DateTimeKind.Local).AddTicks(7047), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Absolut Vodka, pure and smooth, perfect for cocktails.", "https://example.com/images/absolutvodka.jpg", 1, new DateTime(2024, 9, 13, 14, 51, 28, 799, DateTimeKind.Local).AddTicks(7049), "Absolut Vodka", 19.99m, 200, 1 },
                    { 5, 1, new DateTime(2024, 9, 13, 14, 51, 28, 799, DateTimeKind.Local).AddTicks(7051), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Havana Club is a Cuban rum, known for its rich flavor and smooth finish.", "https://example.com/images/havana_club", 1, new DateTime(2024, 9, 13, 14, 51, 28, 799, DateTimeKind.Local).AddTicks(7052), "Havana Club", 25.99m, 80, 1 },
                    { 6, 1, new DateTime(2024, 9, 13, 14, 51, 28, 799, DateTimeKind.Local).AddTicks(7057), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Classic Coca-Cola, the refreshing taste you love.", "https://example.com/images/cocacola.jpg", 1, new DateTime(2024, 9, 13, 14, 51, 28, 799, DateTimeKind.Local).AddTicks(7059), "Coca-Cola", 1.99m, 300, 2 },
                    { 7, 1, new DateTime(2024, 9, 13, 14, 51, 28, 799, DateTimeKind.Local).AddTicks(7061), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pepsi Cola, bold and refreshing with every sip.", "https://example.com/images/pepsi.jpg", 1, new DateTime(2024, 9, 13, 14, 51, 28, 799, DateTimeKind.Local).AddTicks(7062), "Pepsi", 1.89m, 280, 2 },
                    { 8, 1, new DateTime(2024, 9, 13, 14, 51, 28, 799, DateTimeKind.Local).AddTicks(7064), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sprite, lemon-lime soda with a crisp and clean taste.", "https://example.com/images/sprite.jpg", 1, new DateTime(2024, 9, 13, 14, 51, 28, 799, DateTimeKind.Local).AddTicks(7065), "Sprite", 1.79m, 270, 2 },
                    { 9, 1, new DateTime(2024, 9, 13, 14, 51, 28, 799, DateTimeKind.Local).AddTicks(7067), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fanta, fruity and fun with a burst of orange flavor.", "https://example.com/images/fanta.jpg", 1, new DateTime(2024, 9, 13, 14, 51, 28, 799, DateTimeKind.Local).AddTicks(7069), "Fanta", 1.69m, 260, 2 },
                    { 10, 1, new DateTime(2024, 9, 13, 14, 51, 28, 799, DateTimeKind.Local).AddTicks(7071), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "7-Up, the refreshing lemon-lime soda everyone loves.", "https://example.com/images/7up.jpg", 1, new DateTime(2024, 9, 13, 14, 51, 28, 799, DateTimeKind.Local).AddTicks(7073), "7-Up", 1.59m, 250, 2 },
                    { 11, 1, new DateTime(2024, 9, 13, 14, 51, 28, 799, DateTimeKind.Local).AddTicks(7075), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Heineken, a world-renowned Dutch lager.", "https://example.com/images/heineken.jpg", 1, new DateTime(2024, 9, 13, 14, 51, 28, 799, DateTimeKind.Local).AddTicks(7076), "Heineken", 3.99m, 220, 3 },
                    { 12, 1, new DateTime(2024, 9, 13, 14, 51, 28, 799, DateTimeKind.Local).AddTicks(7078), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Budweiser, the King of Beers with a smooth and crisp finish.", "https://example.com/images/budweiser.jpg", 1, new DateTime(2024, 9, 13, 14, 51, 28, 799, DateTimeKind.Local).AddTicks(7079), "Budweiser", 2.99m, 210, 3 },
                    { 13, 1, new DateTime(2024, 9, 13, 14, 51, 28, 799, DateTimeKind.Local).AddTicks(7081), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Corona Extra, perfect for those sunny beach days.", "https://example.com/images/corona.jpg", 1, new DateTime(2024, 9, 13, 14, 51, 28, 799, DateTimeKind.Local).AddTicks(7083), "Corona", 4.49m, 230, 3 },
                    { 14, 1, new DateTime(2024, 9, 13, 14, 51, 28, 799, DateTimeKind.Local).AddTicks(7085), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stella Artois, a Belgian pilsner of premium quality.", "https://example.com/images/stellaartois.jpg", 1, new DateTime(2024, 9, 13, 14, 51, 28, 799, DateTimeKind.Local).AddTicks(7086), "Stella Artois", 4.29m, 240, 3 },
                    { 15, 1, new DateTime(2024, 9, 13, 14, 51, 28, 799, DateTimeKind.Local).AddTicks(7088), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Guinness, the iconic Irish stout with a rich and creamy flavor.", "https://example.com/images/guinness.jpg", 1, new DateTime(2024, 9, 13, 14, 51, 28, 799, DateTimeKind.Local).AddTicks(7089), "Guinness", 4.99m, 200, 3 },
                    { 16, 1, new DateTime(2024, 9, 13, 14, 51, 28, 799, DateTimeKind.Local).AddTicks(7091), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Carlsberg, probably the best beer in the world.", "https://example.com/images/carlsberg.jpg", 1, new DateTime(2024, 9, 13, 14, 51, 28, 799, DateTimeKind.Local).AddTicks(7092), "Carlsberg", 4.99m, 200, 3 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Beverages");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Beverages");
        }
    }
}
