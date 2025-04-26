using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelManagement.Migrations
{
    /// <inheritdoc />
    public partial class FoodsOrders : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FoodOrders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    ApplicationUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodOrders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FoodOrders_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Foods",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foods", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FoodOrderFoods",
                columns: table => new
                {
                    FoodsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FoodOrdersId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodOrderFoods", x => new { x.FoodsId, x.FoodOrdersId });
                    table.ForeignKey(
                        name: "FK_FoodOrderFoods_FoodOrders_FoodOrdersId",
                        column: x => x.FoodOrdersId,
                        principalTable: "FoodOrders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FoodOrderFoods_Foods_FoodsId",
                        column: x => x.FoodsId,
                        principalTable: "Foods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd291"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fb339dfb-dc82-42c3-b2b8-76e61d2b65f4", "AQAAAAIAAYagAAAAEIJ2JY9KAkkuaS5tfbhraxetKK00hTdeTVE5KoD6/9TXyg5KEcWykgbevHI/wXKr8g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd292"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2961280d-d234-463a-83f5-e7a0f2958e8e", "AQAAAAIAAYagAAAAEDAzivRrrW6p7A47rIdpoLz1GLHyO8xHuY5fC5o6AvKrcnSiJEuHwicBvL8BRVUJIA==" });

            migrationBuilder.CreateIndex(
                name: "IX_FoodOrderFoods_FoodOrdersId",
                table: "FoodOrderFoods",
                column: "FoodOrdersId");

            migrationBuilder.CreateIndex(
                name: "IX_FoodOrders_ApplicationUserId",
                table: "FoodOrders",
                column: "ApplicationUserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FoodOrderFoods");

            migrationBuilder.DropTable(
                name: "FoodOrders");

            migrationBuilder.DropTable(
                name: "Foods");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd291"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f41432b7-9a80-4cc0-9a68-a3aa11628b85", "AQAAAAIAAYagAAAAELHSdcyWJp5GWxbwmIP5YuFvhKs6+fJ5AsbPiHfAktBNqFcyQxzdhIzRIGVqRS3Z1Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd292"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e072d500-b68a-460b-8b26-deeef06926a0", "AQAAAAIAAYagAAAAEOiH3DFNlBtWgTAD+3ZM0OLZJkQLcm3HqlHKvLFpqso4SKkDK0JyfnSANqR9ThpPEw==" });
        }
    }
}
