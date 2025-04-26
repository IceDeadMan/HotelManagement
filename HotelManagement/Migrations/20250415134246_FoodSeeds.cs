using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HotelManagement.Migrations
{
    /// <inheritdoc />
    public partial class FoodSeeds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Foods",
                type: "decimal(10,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AddColumn<Guid>(
                name: "RoomId",
                table: "FoodOrders",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.InsertData(
                table: "ActivityRecords",
                columns: new[] { "Id", "ApplicationUserId", "Date", "Description", "RoomId", "Status", "Type" },
                values: new object[] { new Guid("db1ae6ab-91a7-4aaf-a08a-4097ce670a31"), new Guid("67019a3d-04de-444b-bb6c-6ef934dcd291"), new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Room 101 cleaning", new Guid("a242ae42-b5f3-417e-9277-b89ac16fca21"), 0, 0 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd291"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2deaa746-44ac-4642-a10f-46a078f7c8e4", "AQAAAAIAAYagAAAAEGHacdrc4rSBnrNOMr9VyUqWE7++pzpoQ0SQAnzxjgPaS74xQYUH+/GbSjGUEW7Egw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd292"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "dca14458-de05-4259-b804-7be4854d6650", "AQAAAAIAAYagAAAAEA0Y80i2BFzql5QBHAwe3eFavihPABvqFWYAGbl+xzvCpbmkbEf+7XyGnaVIrntbJg==" });

            migrationBuilder.InsertData(
                table: "FoodOrders",
                columns: new[] { "Id", "ApplicationUserId", "Description", "OrderDate", "RoomId", "Status" },
                values: new object[,]
                {
                    { new Guid("41d65c90-de3e-49be-8802-8cbc5b4e2961"), new Guid("67019a3d-04de-444b-bb6c-6ef934dcd291"), "Order 1", new DateTime(2025, 4, 15, 16, 42, 45, 564, DateTimeKind.Local).AddTicks(2374), new Guid("a242ae42-b5f3-417e-9277-b89ac16fca21"), 0 },
                    { new Guid("41d65c90-de3e-49be-8802-8cbc5b4e2962"), new Guid("67019a3d-04de-444b-bb6c-6ef934dcd291"), "Order 2", new DateTime(2025, 4, 15, 16, 42, 45, 566, DateTimeKind.Local).AddTicks(6390), new Guid("a242ae42-b5f3-417e-9277-b89ac16fca22"), 2 }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("a9063d88-88c6-40db-a7e9-868afeb45811"), "Delicious cheese pizza with fresh toppings.", "Pizza", 12.99m },
                    { new Guid("a9063d88-88c6-40db-a7e9-868afeb45812"), "Juicy beef burger with lettuce and tomato.", "Burger", 8.99m },
                    { new Guid("a9063d88-88c6-40db-a7e9-868afeb45813"), "Creamy Alfredo pasta with grilled chicken.", "Pasta Alfredo", 10.99m }
                });

            migrationBuilder.InsertData(
                table: "FoodOrderFoods",
                columns: new[] { "FoodOrdersId", "FoodsId" },
                values: new object[,]
                {
                    { new Guid("41d65c90-de3e-49be-8802-8cbc5b4e2961"), new Guid("a9063d88-88c6-40db-a7e9-868afeb45811") },
                    { new Guid("41d65c90-de3e-49be-8802-8cbc5b4e2961"), new Guid("a9063d88-88c6-40db-a7e9-868afeb45812") },
                    { new Guid("41d65c90-de3e-49be-8802-8cbc5b4e2962"), new Guid("a9063d88-88c6-40db-a7e9-868afeb45813") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_FoodOrders_RoomId",
                table: "FoodOrders",
                column: "RoomId");

            migrationBuilder.AddForeignKey(
                name: "FK_FoodOrders_Rooms_RoomId",
                table: "FoodOrders",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FoodOrders_Rooms_RoomId",
                table: "FoodOrders");

            migrationBuilder.DropIndex(
                name: "IX_FoodOrders_RoomId",
                table: "FoodOrders");

            migrationBuilder.DeleteData(
                table: "ActivityRecords",
                keyColumn: "Id",
                keyValue: new Guid("db1ae6ab-91a7-4aaf-a08a-4097ce670a31"));

            migrationBuilder.DeleteData(
                table: "FoodOrderFoods",
                keyColumns: new[] { "FoodOrdersId", "FoodsId" },
                keyValues: new object[] { new Guid("41d65c90-de3e-49be-8802-8cbc5b4e2961"), new Guid("a9063d88-88c6-40db-a7e9-868afeb45811") });

            migrationBuilder.DeleteData(
                table: "FoodOrderFoods",
                keyColumns: new[] { "FoodOrdersId", "FoodsId" },
                keyValues: new object[] { new Guid("41d65c90-de3e-49be-8802-8cbc5b4e2961"), new Guid("a9063d88-88c6-40db-a7e9-868afeb45812") });

            migrationBuilder.DeleteData(
                table: "FoodOrderFoods",
                keyColumns: new[] { "FoodOrdersId", "FoodsId" },
                keyValues: new object[] { new Guid("41d65c90-de3e-49be-8802-8cbc5b4e2962"), new Guid("a9063d88-88c6-40db-a7e9-868afeb45813") });

            migrationBuilder.DeleteData(
                table: "FoodOrders",
                keyColumn: "Id",
                keyValue: new Guid("41d65c90-de3e-49be-8802-8cbc5b4e2961"));

            migrationBuilder.DeleteData(
                table: "FoodOrders",
                keyColumn: "Id",
                keyValue: new Guid("41d65c90-de3e-49be-8802-8cbc5b4e2962"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("a9063d88-88c6-40db-a7e9-868afeb45811"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("a9063d88-88c6-40db-a7e9-868afeb45812"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("a9063d88-88c6-40db-a7e9-868afeb45813"));

            migrationBuilder.DropColumn(
                name: "RoomId",
                table: "FoodOrders");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Foods",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,2)");

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
        }
    }
}
