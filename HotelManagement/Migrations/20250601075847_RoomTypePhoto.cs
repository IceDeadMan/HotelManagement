using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelManagement.Migrations
{
    /// <inheritdoc />
    public partial class RoomTypePhoto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Photo",
                table: "RoomTypes",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd291"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "128732e5-0b5d-4486-a439-604ebc1d25da", "AQAAAAIAAYagAAAAEHCKH8KU5jWU/ooR18as19BeeZKxNgN4dJ+/C8ZjalF4dVv+uz4xcXrv+ZlydN8kbw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd292"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "dfbcea9b-3115-41e9-94de-1b932819190d", "AQAAAAIAAYagAAAAECpBDkFU7Yempu8fYmqzecYEaTL67nAp/MkPGzp+3L4u2WqpCiHmdTCK0zT5G1e35g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd293"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ad3597d3-6226-48d4-9ef8-c3fc1b7ba385", "AQAAAAIAAYagAAAAEPE81+dErDib2A0NicZupeP7I3nWcuL7bZnk8AoQn/2Nw6SORFZwzL/eYQd3RJ3SAA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd294"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0123f7d9-8541-4216-8f8f-91b85137976a", "AQAAAAIAAYagAAAAEGW8LuUlsE88ZilVHULfdAJBT5XMjJcDAiMOkqG9NKeOvzuWzAEfnWoMcbBbgMUTXw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd295"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "95826f49-a06b-4ced-82a2-cb42cac18034", "AQAAAAIAAYagAAAAEODorgAjb21F0duEXUN4ns68RCxbqiSYFMC604p8oovJMXRKRaxeH/hFOp0dxmda6Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd296"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "01ecaa98-fb8b-4b0e-b21b-18182e97155d", "AQAAAAIAAYagAAAAEHWk6uZ109Z8RfQwFj5h3Bh+AgvGZ3LfpezoeSRgM5phwEgN3cJvodve/QklN+wwtw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd297"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e016206b-8e64-4658-8c5c-1843c8bdeeda", "AQAAAAIAAYagAAAAEA5q5x4X2/4ylivuf/880UwaQwr1bmeR9M5jlMH/z+/XZqXEzQIAsdJkIdlF9aF9KQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd298"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a3cbd87e-c710-404f-b2e4-f1ae55dae1ab", "AQAAAAIAAYagAAAAEEsrP8Jr6WA573E3KucpTBBRZ/OyB/zbRXxlT9Kn7kCQoVBYyXcXyS1o7dECiD5eXA==" });

            migrationBuilder.UpdateData(
                table: "FoodOrders",
                keyColumn: "Id",
                keyValue: new Guid("41d65c90-de3e-49be-8802-8cbc5b4e2961"),
                column: "OrderDate",
                value: new DateTime(2025, 6, 1, 10, 58, 45, 961, DateTimeKind.Local).AddTicks(3065));

            migrationBuilder.UpdateData(
                table: "FoodOrders",
                keyColumn: "Id",
                keyValue: new Guid("41d65c90-de3e-49be-8802-8cbc5b4e2962"),
                column: "OrderDate",
                value: new DateTime(2025, 6, 1, 10, 58, 45, 961, DateTimeKind.Local).AddTicks(4080));

            migrationBuilder.UpdateData(
                table: "FoodOrders",
                keyColumn: "Id",
                keyValue: new Guid("41d65c90-de3e-49be-8802-8cbc5b4e2963"),
                column: "OrderDate",
                value: new DateTime(2025, 6, 1, 8, 58, 45, 961, DateTimeKind.Local).AddTicks(4097));

            migrationBuilder.UpdateData(
                table: "FoodOrders",
                keyColumn: "Id",
                keyValue: new Guid("41d65c90-de3e-49be-8802-8cbc5b4e2964"),
                column: "OrderDate",
                value: new DateTime(2025, 5, 31, 10, 58, 45, 961, DateTimeKind.Local).AddTicks(4116));

            migrationBuilder.UpdateData(
                table: "FoodOrders",
                keyColumn: "Id",
                keyValue: new Guid("41d65c90-de3e-49be-8802-8cbc5b4e2965"),
                column: "OrderDate",
                value: new DateTime(2025, 6, 1, 10, 58, 45, 961, DateTimeKind.Local).AddTicks(4129));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7291"),
                column: "ReviewDate",
                value: new DateTime(2025, 6, 1, 10, 58, 45, 962, DateTimeKind.Local).AddTicks(9266));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7292"),
                column: "ReviewDate",
                value: new DateTime(2025, 6, 1, 10, 58, 45, 962, DateTimeKind.Local).AddTicks(9754));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7293"),
                column: "ReviewDate",
                value: new DateTime(2025, 6, 1, 10, 58, 45, 962, DateTimeKind.Local).AddTicks(9774));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7294"),
                column: "ReviewDate",
                value: new DateTime(2025, 6, 1, 10, 58, 45, 962, DateTimeKind.Local).AddTicks(9778));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7295"),
                column: "ReviewDate",
                value: new DateTime(2025, 6, 1, 10, 58, 45, 962, DateTimeKind.Local).AddTicks(9783));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7296"),
                column: "ReviewDate",
                value: new DateTime(2025, 6, 1, 10, 58, 45, 962, DateTimeKind.Local).AddTicks(9787));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7297"),
                column: "ReviewDate",
                value: new DateTime(2025, 6, 1, 10, 58, 45, 962, DateTimeKind.Local).AddTicks(9831));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7298"),
                column: "ReviewDate",
                value: new DateTime(2025, 6, 1, 10, 58, 45, 962, DateTimeKind.Local).AddTicks(9836));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7299"),
                column: "ReviewDate",
                value: new DateTime(2025, 6, 1, 10, 58, 45, 962, DateTimeKind.Local).AddTicks(9840));

            migrationBuilder.UpdateData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: new Guid("fbf96b7e-04d2-4290-82e7-40a6f1c76b51"),
                column: "Photo",
                value: null);

            migrationBuilder.UpdateData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: new Guid("fbf96b7e-04d2-4290-82e7-40a6f1c76b52"),
                column: "Photo",
                value: null);

            migrationBuilder.UpdateData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: new Guid("fbf96b7e-04d2-4290-82e7-40a6f1c76b53"),
                column: "Photo",
                value: null);

            migrationBuilder.UpdateData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: new Guid("fbf96b7e-04d2-4290-82e7-40a6f1c76b54"),
                column: "Photo",
                value: null);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Photo",
                table: "RoomTypes");

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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd296"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5208cef3-2043-4b30-96ba-f4b0a420607c", "AQAAAAIAAYagAAAAENDUp7iZoZ5Xi3rWwV8dBsg3pR3uoGohFqBeT5+bLOLbWQrZ/7HkKzYhdES3IRml0A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd297"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3ef8add3-86a4-44f2-a1ea-149d977d2ffa", "AQAAAAIAAYagAAAAEAt7r1knFodDjU9dCbzeRpyae9sOBVVdjQ8q9+YHit93m4WhOAvRO17A/fT3Rlhr7w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd298"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e4936fc7-2e1c-4809-843c-5e2c88d59196", "AQAAAAIAAYagAAAAELlzh2/zzL9fofsgun7CfItOxIyCMqkSGfm9NcgBFPJcaGDP2aXd/ROhM670ULgWvg==" });

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

            migrationBuilder.UpdateData(
                table: "FoodOrders",
                keyColumn: "Id",
                keyValue: new Guid("41d65c90-de3e-49be-8802-8cbc5b4e2963"),
                column: "OrderDate",
                value: new DateTime(2025, 5, 30, 13, 16, 2, 237, DateTimeKind.Local).AddTicks(7036));

            migrationBuilder.UpdateData(
                table: "FoodOrders",
                keyColumn: "Id",
                keyValue: new Guid("41d65c90-de3e-49be-8802-8cbc5b4e2964"),
                column: "OrderDate",
                value: new DateTime(2025, 5, 29, 15, 16, 2, 237, DateTimeKind.Local).AddTicks(7054));

            migrationBuilder.UpdateData(
                table: "FoodOrders",
                keyColumn: "Id",
                keyValue: new Guid("41d65c90-de3e-49be-8802-8cbc5b4e2965"),
                column: "OrderDate",
                value: new DateTime(2025, 5, 30, 15, 16, 2, 237, DateTimeKind.Local).AddTicks(7064));

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

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7295"),
                column: "ReviewDate",
                value: new DateTime(2025, 5, 30, 15, 16, 2, 239, DateTimeKind.Local).AddTicks(3321));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7296"),
                column: "ReviewDate",
                value: new DateTime(2025, 5, 30, 15, 16, 2, 239, DateTimeKind.Local).AddTicks(3331));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7297"),
                column: "ReviewDate",
                value: new DateTime(2025, 5, 30, 15, 16, 2, 239, DateTimeKind.Local).AddTicks(3335));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7298"),
                column: "ReviewDate",
                value: new DateTime(2025, 5, 30, 15, 16, 2, 239, DateTimeKind.Local).AddTicks(3339));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7299"),
                column: "ReviewDate",
                value: new DateTime(2025, 5, 30, 15, 16, 2, 239, DateTimeKind.Local).AddTicks(3343));
        }
    }
}
