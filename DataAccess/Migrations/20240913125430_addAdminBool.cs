using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class addAdminBool : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsAdmin",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 9, 13, 14, 54, 30, 310, DateTimeKind.Local).AddTicks(458), new DateTime(2024, 9, 13, 14, 54, 30, 310, DateTimeKind.Local).AddTicks(495) });

            migrationBuilder.UpdateData(
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 9, 13, 14, 54, 30, 310, DateTimeKind.Local).AddTicks(505), new DateTime(2024, 9, 13, 14, 54, 30, 310, DateTimeKind.Local).AddTicks(507) });

            migrationBuilder.UpdateData(
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 9, 13, 14, 54, 30, 310, DateTimeKind.Local).AddTicks(509), new DateTime(2024, 9, 13, 14, 54, 30, 310, DateTimeKind.Local).AddTicks(511) });

            migrationBuilder.UpdateData(
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 9, 13, 14, 54, 30, 310, DateTimeKind.Local).AddTicks(513), new DateTime(2024, 9, 13, 14, 54, 30, 310, DateTimeKind.Local).AddTicks(514) });

            migrationBuilder.UpdateData(
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 9, 13, 14, 54, 30, 310, DateTimeKind.Local).AddTicks(516), new DateTime(2024, 9, 13, 14, 54, 30, 310, DateTimeKind.Local).AddTicks(517) });

            migrationBuilder.UpdateData(
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 9, 13, 14, 54, 30, 310, DateTimeKind.Local).AddTicks(523), new DateTime(2024, 9, 13, 14, 54, 30, 310, DateTimeKind.Local).AddTicks(524) });

            migrationBuilder.UpdateData(
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 9, 13, 14, 54, 30, 310, DateTimeKind.Local).AddTicks(526), new DateTime(2024, 9, 13, 14, 54, 30, 310, DateTimeKind.Local).AddTicks(528) });

            migrationBuilder.UpdateData(
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 9, 13, 14, 54, 30, 310, DateTimeKind.Local).AddTicks(529), new DateTime(2024, 9, 13, 14, 54, 30, 310, DateTimeKind.Local).AddTicks(531) });

            migrationBuilder.UpdateData(
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 9, 13, 14, 54, 30, 310, DateTimeKind.Local).AddTicks(533), new DateTime(2024, 9, 13, 14, 54, 30, 310, DateTimeKind.Local).AddTicks(534) });

            migrationBuilder.UpdateData(
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 9, 13, 14, 54, 30, 310, DateTimeKind.Local).AddTicks(537), new DateTime(2024, 9, 13, 14, 54, 30, 310, DateTimeKind.Local).AddTicks(538) });

            migrationBuilder.UpdateData(
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 9, 13, 14, 54, 30, 310, DateTimeKind.Local).AddTicks(540), new DateTime(2024, 9, 13, 14, 54, 30, 310, DateTimeKind.Local).AddTicks(542) });

            migrationBuilder.UpdateData(
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 9, 13, 14, 54, 30, 310, DateTimeKind.Local).AddTicks(544), new DateTime(2024, 9, 13, 14, 54, 30, 310, DateTimeKind.Local).AddTicks(545) });

            migrationBuilder.UpdateData(
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 9, 13, 14, 54, 30, 310, DateTimeKind.Local).AddTicks(547), new DateTime(2024, 9, 13, 14, 54, 30, 310, DateTimeKind.Local).AddTicks(548) });

            migrationBuilder.UpdateData(
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 9, 13, 14, 54, 30, 310, DateTimeKind.Local).AddTicks(550), new DateTime(2024, 9, 13, 14, 54, 30, 310, DateTimeKind.Local).AddTicks(552) });

            migrationBuilder.UpdateData(
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 9, 13, 14, 54, 30, 310, DateTimeKind.Local).AddTicks(554), new DateTime(2024, 9, 13, 14, 54, 30, 310, DateTimeKind.Local).AddTicks(555) });

            migrationBuilder.UpdateData(
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 9, 13, 14, 54, 30, 310, DateTimeKind.Local).AddTicks(557), new DateTime(2024, 9, 13, 14, 54, 30, 310, DateTimeKind.Local).AddTicks(558) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsAdmin",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 9, 13, 14, 51, 28, 799, DateTimeKind.Local).AddTicks(6998), new DateTime(2024, 9, 13, 14, 51, 28, 799, DateTimeKind.Local).AddTicks(7028) });

            migrationBuilder.UpdateData(
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 9, 13, 14, 51, 28, 799, DateTimeKind.Local).AddTicks(7038), new DateTime(2024, 9, 13, 14, 51, 28, 799, DateTimeKind.Local).AddTicks(7039) });

            migrationBuilder.UpdateData(
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 9, 13, 14, 51, 28, 799, DateTimeKind.Local).AddTicks(7042), new DateTime(2024, 9, 13, 14, 51, 28, 799, DateTimeKind.Local).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 9, 13, 14, 51, 28, 799, DateTimeKind.Local).AddTicks(7047), new DateTime(2024, 9, 13, 14, 51, 28, 799, DateTimeKind.Local).AddTicks(7049) });

            migrationBuilder.UpdateData(
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 9, 13, 14, 51, 28, 799, DateTimeKind.Local).AddTicks(7051), new DateTime(2024, 9, 13, 14, 51, 28, 799, DateTimeKind.Local).AddTicks(7052) });

            migrationBuilder.UpdateData(
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 9, 13, 14, 51, 28, 799, DateTimeKind.Local).AddTicks(7057), new DateTime(2024, 9, 13, 14, 51, 28, 799, DateTimeKind.Local).AddTicks(7059) });

            migrationBuilder.UpdateData(
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 9, 13, 14, 51, 28, 799, DateTimeKind.Local).AddTicks(7061), new DateTime(2024, 9, 13, 14, 51, 28, 799, DateTimeKind.Local).AddTicks(7062) });

            migrationBuilder.UpdateData(
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 9, 13, 14, 51, 28, 799, DateTimeKind.Local).AddTicks(7064), new DateTime(2024, 9, 13, 14, 51, 28, 799, DateTimeKind.Local).AddTicks(7065) });

            migrationBuilder.UpdateData(
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 9, 13, 14, 51, 28, 799, DateTimeKind.Local).AddTicks(7067), new DateTime(2024, 9, 13, 14, 51, 28, 799, DateTimeKind.Local).AddTicks(7069) });

            migrationBuilder.UpdateData(
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 9, 13, 14, 51, 28, 799, DateTimeKind.Local).AddTicks(7071), new DateTime(2024, 9, 13, 14, 51, 28, 799, DateTimeKind.Local).AddTicks(7073) });

            migrationBuilder.UpdateData(
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 9, 13, 14, 51, 28, 799, DateTimeKind.Local).AddTicks(7075), new DateTime(2024, 9, 13, 14, 51, 28, 799, DateTimeKind.Local).AddTicks(7076) });

            migrationBuilder.UpdateData(
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 9, 13, 14, 51, 28, 799, DateTimeKind.Local).AddTicks(7078), new DateTime(2024, 9, 13, 14, 51, 28, 799, DateTimeKind.Local).AddTicks(7079) });

            migrationBuilder.UpdateData(
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 9, 13, 14, 51, 28, 799, DateTimeKind.Local).AddTicks(7081), new DateTime(2024, 9, 13, 14, 51, 28, 799, DateTimeKind.Local).AddTicks(7083) });

            migrationBuilder.UpdateData(
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 9, 13, 14, 51, 28, 799, DateTimeKind.Local).AddTicks(7085), new DateTime(2024, 9, 13, 14, 51, 28, 799, DateTimeKind.Local).AddTicks(7086) });

            migrationBuilder.UpdateData(
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 9, 13, 14, 51, 28, 799, DateTimeKind.Local).AddTicks(7088), new DateTime(2024, 9, 13, 14, 51, 28, 799, DateTimeKind.Local).AddTicks(7089) });

            migrationBuilder.UpdateData(
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 9, 13, 14, 51, 28, 799, DateTimeKind.Local).AddTicks(7091), new DateTime(2024, 9, 13, 14, 51, 28, 799, DateTimeKind.Local).AddTicks(7092) });
        }
    }
}
