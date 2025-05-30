using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HotelManagement.Migrations
{
    /// <inheritdoc />
    public partial class AdditionalSeeds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ActivityRecords",
                columns: new[] { "Id", "ApplicationUserId", "Date", "Description", "RoomId", "Status", "Type" },
                values: new object[] { new Guid("db1ae6ab-91a7-4aaf-a08a-4097ce670a34"), new Guid("67019a3d-04de-444b-bb6c-6ef934dcd293"), new DateTime(2025, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Room 101 minibar restock", new Guid("a242ae42-b5f3-417e-9277-b89ac16fca21"), 2, 2 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd291"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0e38cb11-3e98-4389-93e0-07e463fab013", "AQAAAAIAAYagAAAAEDIgwAOZJxtT8h7rC90dg96beqH39xfqldgYm3GzWUw1zCQPW6Ubepkt7RszVU7DAg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd292"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7d816839-b6ab-41f6-958e-c8b55adf7309", "AQAAAAIAAYagAAAAEIfBwyIRX9X91qhKBio6MrRq5QTE2WueT9nXY4kEk0dbdeoS2X4aajcysNKisw43Gw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd293"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8c63e5d0-d13f-4347-a507-d4140e454dd1", "AQAAAAIAAYagAAAAEJgi8DS8k/dwzG9lFwQ7XDKDDwfb2ml3YgLaAYCh7QDpZ3x3Hx8CssTWLSetbinajQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd294"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4606eec1-6213-4b30-af8c-e019193ecd21", "AQAAAAIAAYagAAAAEN+TnO+pIY8juOpN4rXFXXSxECFMtrCy7gatoMl5DLCY3XnV21XFZtdNJft86KWE0Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd295"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b1222b84-bb7a-4cbb-9cd9-db843777baab", "AQAAAAIAAYagAAAAELsvesHNMLXYADHq81A1qkIKblC7mejFEPrO4X61kxzHzMSQOVYWBuskGF12gFL8Yg==" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("67019a3d-04de-444b-bb6c-6ef934dcd296"), 0, "5208cef3-2043-4b30-96ba-f4b0a420607c", "user6@example.com", true, false, null, "USER6@EXAMPLE.COM", "USER6", "AQAAAAIAAYagAAAAENDUp7iZoZ5Xi3rWwV8dBsg3pR3uoGohFqBeT5+bLOLbWQrZ/7HkKzYhdES3IRml0A==", null, false, "67019a3d-04de-444b-bb6c-6ef934dcd296", false, "user6" },
                    { new Guid("67019a3d-04de-444b-bb6c-6ef934dcd297"), 0, "3ef8add3-86a4-44f2-a1ea-149d977d2ffa", "user7@example.com", true, false, null, "USER7@EXAMPLE.COM", "USER7", "AQAAAAIAAYagAAAAEAt7r1knFodDjU9dCbzeRpyae9sOBVVdjQ8q9+YHit93m4WhOAvRO17A/fT3Rlhr7w==", null, false, "67019a3d-04de-444b-bb6c-6ef934dcd297", false, "user7" },
                    { new Guid("67019a3d-04de-444b-bb6c-6ef934dcd298"), 0, "e4936fc7-2e1c-4809-843c-5e2c88d59196", "user8@example.com", true, false, null, "USER8@EXAMPLE.COM", "USER8", "AQAAAAIAAYagAAAAELlzh2/zzL9fofsgun7CfItOxIyCMqkSGfm9NcgBFPJcaGDP2aXd/ROhM670ULgWvg==", null, false, "67019a3d-04de-444b-bb6c-6ef934dcd298", false, "user8" }
                });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "Capacity", "Date", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("7c8da81a-74a0-4d50-8cac-fea2f7897733"), 0, new DateTime(2025, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sample exquisite wines from around the world.", "Wine Tasting Evening" },
                    { new Guid("8d9da81a-74a0-4d50-8cac-fea2f7897734"), 0, new DateTime(2025, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "An evening of laughs with stand-up comedians.", "Live Comedy Show" },
                    { new Guid("9e0da81a-74a0-4d50-8cac-fea2f7897735"), 0, new DateTime(2025, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Join us for a summer BBQ party by the pool.", "Poolside BBQ Bash" }
                });

            migrationBuilder.UpdateData(
                table: "FoodOrders",
                keyColumn: "Id",
                keyValue: new Guid("41d65c90-de3e-49be-8802-8cbc5b4e2961"),
                column: "OrderDate",
                value: new DateTime(2025, 5, 30, 15, 16, 2, 235, DateTimeKind.Local).AddTicks(3347));

            migrationBuilder.UpdateData(
                table: "FoodOrders",
                keyColumn: "Id",
                keyValue: new Guid("41d65c90-de3e-49be-8802-8cbc5b4e2962"),
                column: "OrderDate",
                value: new DateTime(2025, 5, 30, 15, 16, 2, 237, DateTimeKind.Local).AddTicks(7008));

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "Id", "Description", "IsAvailable", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("a9063d88-88c6-40db-a7e9-868afeb45814"), "Crisp romaine lettuce with Caesar dressing, croutons, and parmesan.", true, "Caesar Salad", 6.99m },
                    { new Guid("a9063d88-88c6-40db-a7e9-868afeb45815"), "Assorted sushi rolls with fresh fish and vegetables.", true, "Sushi Platter", 14.99m },
                    { new Guid("a9063d88-88c6-40db-a7e9-868afeb45816"), "Fresh salmon fillet grilled to perfection with lemon butter.", true, "Grilled Salmon", 13.49m },
                    { new Guid("a9063d88-88c6-40db-a7e9-868afeb45817"), "Spicy chicken tacos served with salsa and sour cream.", true, "Chicken Tacos", 9.49m },
                    { new Guid("a9063d88-88c6-40db-a7e9-868afeb45818"), "Mixed vegetables sautéed with soy sauce and garlic.", true, "Vegetable Stir-Fry", 8.49m },
                    { new Guid("a9063d88-88c6-40db-a7e9-868afeb45819"), "Tender pork ribs glazed with smoky BBQ sauce.", true, "BBQ Ribs", 15.99m },
                    { new Guid("a9063d88-88c6-40db-a7e9-868afeb45820"), "Warm tomato soup served with a slice of toasted bread.", true, "Tomato Soup", 5.49m },
                    { new Guid("a9063d88-88c6-40db-a7e9-868afeb45821"), "Classic fried rice with egg, vegetables, and soy sauce.", true, "Fried Rice", 7.99m },
                    { new Guid("a9063d88-88c6-40db-a7e9-868afeb45822"), "Juicy grilled steak served with mashed potatoes.", true, "Steak", 18.99m },
                    { new Guid("a9063d88-88c6-40db-a7e9-868afeb45823"), "Fluffy pancakes served with maple syrup and berries.", true, "Pancakes", 6.49m }
                });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7291"),
                column: "ReviewDate",
                value: new DateTime(2025, 5, 30, 15, 16, 2, 239, DateTimeKind.Local).AddTicks(2706));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7292"),
                column: "ReviewDate",
                value: new DateTime(2025, 5, 30, 15, 16, 2, 239, DateTimeKind.Local).AddTicks(3293));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7293"),
                column: "ReviewDate",
                value: new DateTime(2025, 5, 30, 15, 16, 2, 239, DateTimeKind.Local).AddTicks(3312));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7294"),
                column: "ReviewDate",
                value: new DateTime(2025, 5, 30, 15, 16, 2, 239, DateTimeKind.Local).AddTicks(3317));

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Description", "RoomNumber", "RoomTypeId" },
                values: new object[,]
                {
                    { new Guid("a242ae42-b5f3-417e-9277-b89ac16fca24"), "Room 104", "104", new Guid("fbf96b7e-04d2-4290-82e7-40a6f1c76b54") },
                    { new Guid("a242ae42-b5f3-417e-9277-b89ac16fca25"), "Room 105", "105", new Guid("fbf96b7e-04d2-4290-82e7-40a6f1c76b51") },
                    { new Guid("a242ae42-b5f3-417e-9277-b89ac16fca26"), "Room 106", "106", new Guid("fbf96b7e-04d2-4290-82e7-40a6f1c76b52") },
                    { new Guid("a242ae42-b5f3-417e-9277-b89ac16fca27"), "Room 107", "107", new Guid("fbf96b7e-04d2-4290-82e7-40a6f1c76b53") },
                    { new Guid("a242ae42-b5f3-417e-9277-b89ac16fca28"), "Room 108", "108", new Guid("fbf96b7e-04d2-4290-82e7-40a6f1c76b54") },
                    { new Guid("a242ae42-b5f3-417e-9277-b89ac16fca29"), "Room 109", "109", new Guid("fbf96b7e-04d2-4290-82e7-40a6f1c76b51") },
                    { new Guid("a242ae42-b5f3-417e-9277-b89ac16fca30"), "Room 110", "110", new Guid("fbf96b7e-04d2-4290-82e7-40a6f1c76b52") },
                    { new Guid("a242ae42-b5f3-417e-9277-b89ac16fca31"), "Room 111", "111", new Guid("fbf96b7e-04d2-4290-82e7-40a6f1c76b53") },
                    { new Guid("a242ae42-b5f3-417e-9277-b89ac16fca32"), "Room 112", "112", new Guid("fbf96b7e-04d2-4290-82e7-40a6f1c76b54") },
                    { new Guid("a242ae42-b5f3-417e-9277-b89ac16fca33"), "Room 113", "113", new Guid("fbf96b7e-04d2-4290-82e7-40a6f1c76b51") }
                });

            migrationBuilder.InsertData(
                table: "ActivityRecords",
                columns: new[] { "Id", "ApplicationUserId", "Date", "Description", "RoomId", "Status", "Type" },
                values: new object[,]
                {
                    { new Guid("db1ae6ab-91a7-4aaf-a08a-4097ce670a35"), new Guid("67019a3d-04de-444b-bb6c-6ef934dcd298"), new DateTime(2025, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Room 104 cleaning", new Guid("a242ae42-b5f3-417e-9277-b89ac16fca24"), 2, 0 },
                    { new Guid("db1ae6ab-91a7-4aaf-a08a-4097ce670a36"), new Guid("67019a3d-04de-444b-bb6c-6ef934dcd293"), new DateTime(2025, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Room 106 maintenance check", new Guid("a242ae42-b5f3-417e-9277-b89ac16fca26"), 0, 1 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("87600eb8-1da1-452a-a0bc-0d9c808b4b11"), new Guid("67019a3d-04de-444b-bb6c-6ef934dcd296") },
                    { new Guid("87600eb8-1da1-452a-a0bc-0d9c808b4b11"), new Guid("67019a3d-04de-444b-bb6c-6ef934dcd297") },
                    { new Guid("87600eb8-1da1-452a-a0bc-0d9c808b4b14"), new Guid("67019a3d-04de-444b-bb6c-6ef934dcd298") }
                });

            migrationBuilder.InsertData(
                table: "Bookings",
                columns: new[] { "Id", "ApplicationUserId", "EndDate", "StartDate", "Status" },
                values: new object[,]
                {
                    { new Guid("371c096d-5c0b-4929-aab5-1c0289611903"), new Guid("67019a3d-04de-444b-bb6c-6ef934dcd296"), new DateTime(2025, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { new Guid("371c096d-5c0b-4929-aab5-1c0289611904"), new Guid("67019a3d-04de-444b-bb6c-6ef934dcd297"), new DateTime(2025, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { new Guid("371c096d-5c0b-4929-aab5-1c0289611905"), new Guid("67019a3d-04de-444b-bb6c-6ef934dcd296"), new DateTime(2025, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { new Guid("371c096d-5c0b-4929-aab5-1c0289611906"), new Guid("67019a3d-04de-444b-bb6c-6ef934dcd297"), new DateTime(2025, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 }
                });

            migrationBuilder.InsertData(
                table: "EventRegistrations",
                columns: new[] { "EventId", "UserId", "NumberOfParticipants" },
                values: new object[,]
                {
                    { new Guid("7c8da81a-74a0-4d50-8cac-fea2f7897733"), new Guid("67019a3d-04de-444b-bb6c-6ef934dcd296"), 1 },
                    { new Guid("8d9da81a-74a0-4d50-8cac-fea2f7897734"), new Guid("67019a3d-04de-444b-bb6c-6ef934dcd291"), 3 },
                    { new Guid("8d9da81a-74a0-4d50-8cac-fea2f7897734"), new Guid("67019a3d-04de-444b-bb6c-6ef934dcd297"), 2 },
                    { new Guid("9e0da81a-74a0-4d50-8cac-fea2f7897735"), new Guid("67019a3d-04de-444b-bb6c-6ef934dcd296"), 1 }
                });

            migrationBuilder.InsertData(
                table: "EventStaff",
                columns: new[] { "EventId", "UserId" },
                values: new object[,]
                {
                    { new Guid("7c8da81a-74a0-4d50-8cac-fea2f7897733"), new Guid("67019a3d-04de-444b-bb6c-6ef934dcd293") },
                    { new Guid("9e0da81a-74a0-4d50-8cac-fea2f7897735"), new Guid("67019a3d-04de-444b-bb6c-6ef934dcd293") },
                    { new Guid("8d9da81a-74a0-4d50-8cac-fea2f7897734"), new Guid("67019a3d-04de-444b-bb6c-6ef934dcd298") },
                    { new Guid("9e0da81a-74a0-4d50-8cac-fea2f7897735"), new Guid("67019a3d-04de-444b-bb6c-6ef934dcd298") }
                });

            migrationBuilder.InsertData(
                table: "FoodOrders",
                columns: new[] { "Id", "ApplicationUserId", "Description", "OrderDate", "RoomId", "Status" },
                values: new object[,]
                {
                    { new Guid("41d65c90-de3e-49be-8802-8cbc5b4e2963"), new Guid("67019a3d-04de-444b-bb6c-6ef934dcd296"), "Late night snacks", new DateTime(2025, 5, 30, 13, 16, 2, 237, DateTimeKind.Local).AddTicks(7036), new Guid("a242ae42-b5f3-417e-9277-b89ac16fca23"), 0 },
                    { new Guid("41d65c90-de3e-49be-8802-8cbc5b4e2964"), new Guid("67019a3d-04de-444b-bb6c-6ef934dcd297"), "Lunch order", new DateTime(2025, 5, 29, 15, 16, 2, 237, DateTimeKind.Local).AddTicks(7054), new Guid("a242ae42-b5f3-417e-9277-b89ac16fca24"), 2 },
                    { new Guid("41d65c90-de3e-49be-8802-8cbc5b4e2965"), new Guid("67019a3d-04de-444b-bb6c-6ef934dcd291"), "Dinner special", new DateTime(2025, 5, 30, 15, 16, 2, 237, DateTimeKind.Local).AddTicks(7064), new Guid("a242ae42-b5f3-417e-9277-b89ac16fca25"), 0 }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "ApplicationUserId", "Comment", "FoodId", "Rating", "ReviewDate", "RoomId" },
                values: new object[,]
                {
                    { new Guid("4aef3307-19ee-4b61-8efa-8828279e7295"), new Guid("67019a3d-04de-444b-bb6c-6ef934dcd296"), "Absolutely loved the view and comfort!", null, 10, new DateTime(2025, 5, 30, 15, 16, 2, 239, DateTimeKind.Local).AddTicks(3321), new Guid("a242ae42-b5f3-417e-9277-b89ac16fca23") },
                    { new Guid("4aef3307-19ee-4b61-8efa-8828279e7296"), new Guid("67019a3d-04de-444b-bb6c-6ef934dcd297"), "Room was okay, but a bit noisy.", null, 6, new DateTime(2025, 5, 30, 15, 16, 2, 239, DateTimeKind.Local).AddTicks(3331), new Guid("a242ae42-b5f3-417e-9277-b89ac16fca24") },
                    { new Guid("4aef3307-19ee-4b61-8efa-8828279e7297"), new Guid("67019a3d-04de-444b-bb6c-6ef934dcd296"), "Loved the creamy Alfredo sauce!", new Guid("a9063d88-88c6-40db-a7e9-868afeb45813"), 9, new DateTime(2025, 5, 30, 15, 16, 2, 239, DateTimeKind.Local).AddTicks(3335), null },
                    { new Guid("4aef3307-19ee-4b61-8efa-8828279e7298"), new Guid("67019a3d-04de-444b-bb6c-6ef934dcd297"), "Tasty salad, but could use more dressing.", new Guid("a9063d88-88c6-40db-a7e9-868afeb45814"), 7, new DateTime(2025, 5, 30, 15, 16, 2, 239, DateTimeKind.Local).AddTicks(3339), null },
                    { new Guid("4aef3307-19ee-4b61-8efa-8828279e7299"), new Guid("67019a3d-04de-444b-bb6c-6ef934dcd297"), "Fries were soggy and under-seasoned.", new Guid("a9063d88-88c6-40db-a7e9-868afeb45815"), 4, new DateTime(2025, 5, 30, 15, 16, 2, 239, DateTimeKind.Local).AddTicks(3343), null }
                });

            migrationBuilder.InsertData(
                table: "FoodOrderFoods",
                columns: new[] { "FoodId", "FoodOrderId", "Quantity" },
                values: new object[,]
                {
                    { new Guid("a9063d88-88c6-40db-a7e9-868afeb45812"), new Guid("41d65c90-de3e-49be-8802-8cbc5b4e2965"), 1 },
                    { new Guid("a9063d88-88c6-40db-a7e9-868afeb45814"), new Guid("41d65c90-de3e-49be-8802-8cbc5b4e2963"), 1 },
                    { new Guid("a9063d88-88c6-40db-a7e9-868afeb45815"), new Guid("41d65c90-de3e-49be-8802-8cbc5b4e2963"), 2 },
                    { new Guid("a9063d88-88c6-40db-a7e9-868afeb45816"), new Guid("41d65c90-de3e-49be-8802-8cbc5b4e2964"), 1 },
                    { new Guid("a9063d88-88c6-40db-a7e9-868afeb45819"), new Guid("41d65c90-de3e-49be-8802-8cbc5b4e2965"), 2 }
                });

            migrationBuilder.InsertData(
                table: "RoomBookings",
                columns: new[] { "BookingsId", "RoomsId" },
                values: new object[,]
                {
                    { new Guid("371c096d-5c0b-4929-aab5-1c0289611903"), new Guid("a242ae42-b5f3-417e-9277-b89ac16fca24") },
                    { new Guid("371c096d-5c0b-4929-aab5-1c0289611903"), new Guid("a242ae42-b5f3-417e-9277-b89ac16fca25") },
                    { new Guid("371c096d-5c0b-4929-aab5-1c0289611904"), new Guid("a242ae42-b5f3-417e-9277-b89ac16fca23") },
                    { new Guid("371c096d-5c0b-4929-aab5-1c0289611905"), new Guid("a242ae42-b5f3-417e-9277-b89ac16fca26") },
                    { new Guid("371c096d-5c0b-4929-aab5-1c0289611906"), new Guid("a242ae42-b5f3-417e-9277-b89ac16fca27") },
                    { new Guid("371c096d-5c0b-4929-aab5-1c0289611906"), new Guid("a242ae42-b5f3-417e-9277-b89ac16fca28") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ActivityRecords",
                keyColumn: "Id",
                keyValue: new Guid("db1ae6ab-91a7-4aaf-a08a-4097ce670a34"));

            migrationBuilder.DeleteData(
                table: "ActivityRecords",
                keyColumn: "Id",
                keyValue: new Guid("db1ae6ab-91a7-4aaf-a08a-4097ce670a35"));

            migrationBuilder.DeleteData(
                table: "ActivityRecords",
                keyColumn: "Id",
                keyValue: new Guid("db1ae6ab-91a7-4aaf-a08a-4097ce670a36"));

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("87600eb8-1da1-452a-a0bc-0d9c808b4b11"), new Guid("67019a3d-04de-444b-bb6c-6ef934dcd296") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("87600eb8-1da1-452a-a0bc-0d9c808b4b11"), new Guid("67019a3d-04de-444b-bb6c-6ef934dcd297") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("87600eb8-1da1-452a-a0bc-0d9c808b4b14"), new Guid("67019a3d-04de-444b-bb6c-6ef934dcd298") });

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumns: new[] { "EventId", "UserId" },
                keyValues: new object[] { new Guid("7c8da81a-74a0-4d50-8cac-fea2f7897733"), new Guid("67019a3d-04de-444b-bb6c-6ef934dcd296") });

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumns: new[] { "EventId", "UserId" },
                keyValues: new object[] { new Guid("8d9da81a-74a0-4d50-8cac-fea2f7897734"), new Guid("67019a3d-04de-444b-bb6c-6ef934dcd291") });

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumns: new[] { "EventId", "UserId" },
                keyValues: new object[] { new Guid("8d9da81a-74a0-4d50-8cac-fea2f7897734"), new Guid("67019a3d-04de-444b-bb6c-6ef934dcd297") });

            migrationBuilder.DeleteData(
                table: "EventRegistrations",
                keyColumns: new[] { "EventId", "UserId" },
                keyValues: new object[] { new Guid("9e0da81a-74a0-4d50-8cac-fea2f7897735"), new Guid("67019a3d-04de-444b-bb6c-6ef934dcd296") });

            migrationBuilder.DeleteData(
                table: "EventStaff",
                keyColumns: new[] { "EventId", "UserId" },
                keyValues: new object[] { new Guid("7c8da81a-74a0-4d50-8cac-fea2f7897733"), new Guid("67019a3d-04de-444b-bb6c-6ef934dcd293") });

            migrationBuilder.DeleteData(
                table: "EventStaff",
                keyColumns: new[] { "EventId", "UserId" },
                keyValues: new object[] { new Guid("9e0da81a-74a0-4d50-8cac-fea2f7897735"), new Guid("67019a3d-04de-444b-bb6c-6ef934dcd293") });

            migrationBuilder.DeleteData(
                table: "EventStaff",
                keyColumns: new[] { "EventId", "UserId" },
                keyValues: new object[] { new Guid("8d9da81a-74a0-4d50-8cac-fea2f7897734"), new Guid("67019a3d-04de-444b-bb6c-6ef934dcd298") });

            migrationBuilder.DeleteData(
                table: "EventStaff",
                keyColumns: new[] { "EventId", "UserId" },
                keyValues: new object[] { new Guid("9e0da81a-74a0-4d50-8cac-fea2f7897735"), new Guid("67019a3d-04de-444b-bb6c-6ef934dcd298") });

            migrationBuilder.DeleteData(
                table: "FoodOrderFoods",
                keyColumns: new[] { "FoodId", "FoodOrderId" },
                keyValues: new object[] { new Guid("a9063d88-88c6-40db-a7e9-868afeb45812"), new Guid("41d65c90-de3e-49be-8802-8cbc5b4e2965") });

            migrationBuilder.DeleteData(
                table: "FoodOrderFoods",
                keyColumns: new[] { "FoodId", "FoodOrderId" },
                keyValues: new object[] { new Guid("a9063d88-88c6-40db-a7e9-868afeb45814"), new Guid("41d65c90-de3e-49be-8802-8cbc5b4e2963") });

            migrationBuilder.DeleteData(
                table: "FoodOrderFoods",
                keyColumns: new[] { "FoodId", "FoodOrderId" },
                keyValues: new object[] { new Guid("a9063d88-88c6-40db-a7e9-868afeb45815"), new Guid("41d65c90-de3e-49be-8802-8cbc5b4e2963") });

            migrationBuilder.DeleteData(
                table: "FoodOrderFoods",
                keyColumns: new[] { "FoodId", "FoodOrderId" },
                keyValues: new object[] { new Guid("a9063d88-88c6-40db-a7e9-868afeb45816"), new Guid("41d65c90-de3e-49be-8802-8cbc5b4e2964") });

            migrationBuilder.DeleteData(
                table: "FoodOrderFoods",
                keyColumns: new[] { "FoodId", "FoodOrderId" },
                keyValues: new object[] { new Guid("a9063d88-88c6-40db-a7e9-868afeb45819"), new Guid("41d65c90-de3e-49be-8802-8cbc5b4e2965") });

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("a9063d88-88c6-40db-a7e9-868afeb45817"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("a9063d88-88c6-40db-a7e9-868afeb45818"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("a9063d88-88c6-40db-a7e9-868afeb45820"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("a9063d88-88c6-40db-a7e9-868afeb45821"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("a9063d88-88c6-40db-a7e9-868afeb45822"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("a9063d88-88c6-40db-a7e9-868afeb45823"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7295"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7296"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7297"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7298"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7299"));

            migrationBuilder.DeleteData(
                table: "RoomBookings",
                keyColumns: new[] { "BookingsId", "RoomsId" },
                keyValues: new object[] { new Guid("371c096d-5c0b-4929-aab5-1c0289611903"), new Guid("a242ae42-b5f3-417e-9277-b89ac16fca24") });

            migrationBuilder.DeleteData(
                table: "RoomBookings",
                keyColumns: new[] { "BookingsId", "RoomsId" },
                keyValues: new object[] { new Guid("371c096d-5c0b-4929-aab5-1c0289611903"), new Guid("a242ae42-b5f3-417e-9277-b89ac16fca25") });

            migrationBuilder.DeleteData(
                table: "RoomBookings",
                keyColumns: new[] { "BookingsId", "RoomsId" },
                keyValues: new object[] { new Guid("371c096d-5c0b-4929-aab5-1c0289611904"), new Guid("a242ae42-b5f3-417e-9277-b89ac16fca23") });

            migrationBuilder.DeleteData(
                table: "RoomBookings",
                keyColumns: new[] { "BookingsId", "RoomsId" },
                keyValues: new object[] { new Guid("371c096d-5c0b-4929-aab5-1c0289611905"), new Guid("a242ae42-b5f3-417e-9277-b89ac16fca26") });

            migrationBuilder.DeleteData(
                table: "RoomBookings",
                keyColumns: new[] { "BookingsId", "RoomsId" },
                keyValues: new object[] { new Guid("371c096d-5c0b-4929-aab5-1c0289611906"), new Guid("a242ae42-b5f3-417e-9277-b89ac16fca27") });

            migrationBuilder.DeleteData(
                table: "RoomBookings",
                keyColumns: new[] { "BookingsId", "RoomsId" },
                keyValues: new object[] { new Guid("371c096d-5c0b-4929-aab5-1c0289611906"), new Guid("a242ae42-b5f3-417e-9277-b89ac16fca28") });

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("a242ae42-b5f3-417e-9277-b89ac16fca29"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("a242ae42-b5f3-417e-9277-b89ac16fca30"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("a242ae42-b5f3-417e-9277-b89ac16fca31"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("a242ae42-b5f3-417e-9277-b89ac16fca32"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("a242ae42-b5f3-417e-9277-b89ac16fca33"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd298"));

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: new Guid("371c096d-5c0b-4929-aab5-1c0289611903"));

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: new Guid("371c096d-5c0b-4929-aab5-1c0289611904"));

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: new Guid("371c096d-5c0b-4929-aab5-1c0289611905"));

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: new Guid("371c096d-5c0b-4929-aab5-1c0289611906"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("7c8da81a-74a0-4d50-8cac-fea2f7897733"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("8d9da81a-74a0-4d50-8cac-fea2f7897734"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("9e0da81a-74a0-4d50-8cac-fea2f7897735"));

            migrationBuilder.DeleteData(
                table: "FoodOrders",
                keyColumn: "Id",
                keyValue: new Guid("41d65c90-de3e-49be-8802-8cbc5b4e2963"));

            migrationBuilder.DeleteData(
                table: "FoodOrders",
                keyColumn: "Id",
                keyValue: new Guid("41d65c90-de3e-49be-8802-8cbc5b4e2964"));

            migrationBuilder.DeleteData(
                table: "FoodOrders",
                keyColumn: "Id",
                keyValue: new Guid("41d65c90-de3e-49be-8802-8cbc5b4e2965"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("a9063d88-88c6-40db-a7e9-868afeb45814"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("a9063d88-88c6-40db-a7e9-868afeb45815"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("a9063d88-88c6-40db-a7e9-868afeb45816"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("a9063d88-88c6-40db-a7e9-868afeb45819"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("a242ae42-b5f3-417e-9277-b89ac16fca26"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("a242ae42-b5f3-417e-9277-b89ac16fca27"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("a242ae42-b5f3-417e-9277-b89ac16fca28"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd296"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd297"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("a242ae42-b5f3-417e-9277-b89ac16fca24"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("a242ae42-b5f3-417e-9277-b89ac16fca25"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd291"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "569d1a32-de16-4293-a452-fb60b816815d", "AQAAAAIAAYagAAAAEP0QiyH9JBXej3u83fDfzSp8RNEZqfp7eZ/8cx2wK3Y21+652RgPok8fa8bBDKnsKw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd292"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4c7e7f5a-086e-4b34-888f-53f3a2eadd74", "AQAAAAIAAYagAAAAEJw7u8cjgjFDDP77FHeped92PxwFBXxmlsRwKQHTqmR3GjkGNHcZ305SQnqIOiWpxg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd293"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4fed3557-4906-4410-b9fd-d297ec5f990e", "AQAAAAIAAYagAAAAEJRyq+UmQeSAZkQmGMxt8ot6rWf/W2aRVsZlC5gqmwwyRGqkA2WJpZwT2IS8pGWeew==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd294"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a23083a2-20fc-4b36-afaa-699e8cc3b633", "AQAAAAIAAYagAAAAEFUnDtO2ukKrkS80A/6JRgcBp9N6/W7Vy0QqLpDOJGo4xiST0felfMupGdb56LzDFg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd295"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2630790d-898a-4fe5-a36f-3e36650073d2", "AQAAAAIAAYagAAAAEOW/VfzsqpwQHFlHJrCf3XHCWcWtqSf4VGJo/vMCLpopYSHYexecWXcBshjOqDOmMw==" });

            migrationBuilder.UpdateData(
                table: "FoodOrders",
                keyColumn: "Id",
                keyValue: new Guid("41d65c90-de3e-49be-8802-8cbc5b4e2961"),
                column: "OrderDate",
                value: new DateTime(2025, 5, 30, 14, 1, 15, 781, DateTimeKind.Local).AddTicks(8648));

            migrationBuilder.UpdateData(
                table: "FoodOrders",
                keyColumn: "Id",
                keyValue: new Guid("41d65c90-de3e-49be-8802-8cbc5b4e2962"),
                column: "OrderDate",
                value: new DateTime(2025, 5, 30, 14, 1, 15, 784, DateTimeKind.Local).AddTicks(1735));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7291"),
                column: "ReviewDate",
                value: new DateTime(2025, 5, 30, 14, 1, 15, 785, DateTimeKind.Local).AddTicks(3573));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7292"),
                column: "ReviewDate",
                value: new DateTime(2025, 5, 30, 14, 1, 15, 785, DateTimeKind.Local).AddTicks(4078));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7293"),
                column: "ReviewDate",
                value: new DateTime(2025, 5, 30, 14, 1, 15, 785, DateTimeKind.Local).AddTicks(4096));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7294"),
                column: "ReviewDate",
                value: new DateTime(2025, 5, 30, 14, 1, 15, 785, DateTimeKind.Local).AddTicks(4100));
        }
    }
}
