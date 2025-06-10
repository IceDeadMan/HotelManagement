using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelManagement.Migrations
{
    /// <inheritdoc />
    public partial class OnCascadeDeletes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Foods_FoodId",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Rooms_RoomId",
                table: "Reviews");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd291"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f1b028a6-4abd-4036-9c6a-fa42c0ab0f0e", "AQAAAAIAAYagAAAAEHrw7lSHrN8wwv6Xvnxly3jQNh2r246myBHXQbDIB5Kd2eNOV1ulrlF78azbVE5FTQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd292"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8e111885-c455-40d1-bd05-e56a23566c51", "AQAAAAIAAYagAAAAEKDVeSVQ7JsHiasK19GIDrhRlWOk7d/PhA6Ly5TBDC2olsygfBxlSD9GD/iQpY47Nw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd293"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b1c02557-0d3e-4214-9f98-df176df0a1d1", "AQAAAAIAAYagAAAAEHObirwlwIatzScoSQ/DH/1rNyMZxBRdv/p/u54sDu/FlWaDUG8qxT0SEPcAbh7MBw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd294"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a269cdab-4806-4694-a102-482c32d82cfc", "AQAAAAIAAYagAAAAEEYnfsRp6ku533QEIHZSyn6IVVB0Z8vfKW2bH0CxcQC2ifYYwioyvSSk6WQj7xzglA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd295"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "df1d6fc8-1bbb-4052-bcbb-cf70c547e103", "AQAAAAIAAYagAAAAEKJ5bDndAM56zn8xz6PVGlG7fMJDOafy90ixApXjyBM8dVPl/cK1AAKz9nEy9bNARw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd296"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d2b908f9-2baf-437e-86d4-7adf23988603", "AQAAAAIAAYagAAAAEDot7t2WOodP2ZwwnnykDdbmSeGzrSHM38rhvzCRDPivhiG6u0YcHFUub6c76pMSAQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd297"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b75b8323-7d07-447b-825b-8be68eb1985d", "AQAAAAIAAYagAAAAEDIEIywWn7AMrDjWws1rKpBTQetofzoTfXooHCVm+U6nCzrCASxEcvJRzvRWQy+Vzw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd298"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6da25392-74e1-43ca-95f5-8b1a9eaf9d92", "AQAAAAIAAYagAAAAENwfaV2cGY2vKcWla5mXcVZJx6fBuf53NJkcTDzlR2V5QZQWU5KuuPs/bpteqUkjzQ==" });

            migrationBuilder.UpdateData(
                table: "FoodOrders",
                keyColumn: "Id",
                keyValue: new Guid("41d65c90-de3e-49be-8802-8cbc5b4e2961"),
                column: "OrderDate",
                value: new DateTime(2025, 6, 2, 16, 2, 54, 39, DateTimeKind.Local).AddTicks(6911));

            migrationBuilder.UpdateData(
                table: "FoodOrders",
                keyColumn: "Id",
                keyValue: new Guid("41d65c90-de3e-49be-8802-8cbc5b4e2962"),
                column: "OrderDate",
                value: new DateTime(2025, 6, 2, 16, 2, 54, 39, DateTimeKind.Local).AddTicks(7918));

            migrationBuilder.UpdateData(
                table: "FoodOrders",
                keyColumn: "Id",
                keyValue: new Guid("41d65c90-de3e-49be-8802-8cbc5b4e2963"),
                column: "OrderDate",
                value: new DateTime(2025, 6, 2, 14, 2, 54, 39, DateTimeKind.Local).AddTicks(7934));

            migrationBuilder.UpdateData(
                table: "FoodOrders",
                keyColumn: "Id",
                keyValue: new Guid("41d65c90-de3e-49be-8802-8cbc5b4e2964"),
                column: "OrderDate",
                value: new DateTime(2025, 6, 1, 16, 2, 54, 39, DateTimeKind.Local).AddTicks(7952));

            migrationBuilder.UpdateData(
                table: "FoodOrders",
                keyColumn: "Id",
                keyValue: new Guid("41d65c90-de3e-49be-8802-8cbc5b4e2965"),
                column: "OrderDate",
                value: new DateTime(2025, 6, 2, 16, 2, 54, 39, DateTimeKind.Local).AddTicks(7959));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7291"),
                column: "ReviewDate",
                value: new DateTime(2025, 6, 2, 16, 2, 54, 41, DateTimeKind.Local).AddTicks(2674));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7292"),
                column: "ReviewDate",
                value: new DateTime(2025, 6, 2, 16, 2, 54, 41, DateTimeKind.Local).AddTicks(3141));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7293"),
                column: "ReviewDate",
                value: new DateTime(2025, 6, 2, 16, 2, 54, 41, DateTimeKind.Local).AddTicks(3160));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7294"),
                column: "ReviewDate",
                value: new DateTime(2025, 6, 2, 16, 2, 54, 41, DateTimeKind.Local).AddTicks(3165));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7295"),
                column: "ReviewDate",
                value: new DateTime(2025, 6, 2, 16, 2, 54, 41, DateTimeKind.Local).AddTicks(3170));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7296"),
                column: "ReviewDate",
                value: new DateTime(2025, 6, 2, 16, 2, 54, 41, DateTimeKind.Local).AddTicks(3178));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7297"),
                column: "ReviewDate",
                value: new DateTime(2025, 6, 2, 16, 2, 54, 41, DateTimeKind.Local).AddTicks(3183));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7298"),
                column: "ReviewDate",
                value: new DateTime(2025, 6, 2, 16, 2, 54, 41, DateTimeKind.Local).AddTicks(3187));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7299"),
                column: "ReviewDate",
                value: new DateTime(2025, 6, 2, 16, 2, 54, 41, DateTimeKind.Local).AddTicks(3191));

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Foods_FoodId",
                table: "Reviews",
                column: "FoodId",
                principalTable: "Foods",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Rooms_RoomId",
                table: "Reviews",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Foods_FoodId",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Rooms_RoomId",
                table: "Reviews");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Foods_FoodId",
                table: "Reviews",
                column: "FoodId",
                principalTable: "Foods",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Rooms_RoomId",
                table: "Reviews",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "Id");
        }
    }
}
