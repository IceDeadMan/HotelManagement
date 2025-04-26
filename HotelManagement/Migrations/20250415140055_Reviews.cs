using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HotelManagement.Migrations
{
    /// <inheritdoc />
    public partial class Reviews : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    ReviewDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ApplicationUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoomId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    FoodId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reviews_Foods_FoodId",
                        column: x => x.FoodId,
                        principalTable: "Foods",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Reviews_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd291"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4886c870-110a-413e-9fea-7db734d39bc7", "AQAAAAIAAYagAAAAEAAiX3JSlku0B/SN1fn4D+udnbTyrAi2W7LOgoIox9A0W3jcJdw5+Jr8VCT9AfNblw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd292"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4f98e885-6888-408c-b553-65e6c172950c", "AQAAAAIAAYagAAAAELV+cxirIDNvqPiFzo/Z6u5317lxELZ0PVHtiE2yZXnN0Mh4EbZeQrT1UYrSXni/rg==" });

            migrationBuilder.UpdateData(
                table: "FoodOrders",
                keyColumn: "Id",
                keyValue: new Guid("41d65c90-de3e-49be-8802-8cbc5b4e2961"),
                column: "OrderDate",
                value: new DateTime(2025, 4, 15, 17, 0, 54, 543, DateTimeKind.Local).AddTicks(4424));

            migrationBuilder.UpdateData(
                table: "FoodOrders",
                keyColumn: "Id",
                keyValue: new Guid("41d65c90-de3e-49be-8802-8cbc5b4e2962"),
                column: "OrderDate",
                value: new DateTime(2025, 4, 15, 17, 0, 54, 545, DateTimeKind.Local).AddTicks(9352));

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "ApplicationUserId", "Comment", "FoodId", "Rating", "ReviewDate", "RoomId" },
                values: new object[,]
                {
                    { new Guid("4aef3307-19ee-4b61-8efa-8828279e7291"), new Guid("67019a3d-04de-444b-bb6c-6ef934dcd291"), "Excellent service and clean room!", null, 9, new DateTime(2025, 4, 15, 17, 0, 54, 546, DateTimeKind.Local).AddTicks(9188), new Guid("a242ae42-b5f3-417e-9277-b89ac16fca21") },
                    { new Guid("4aef3307-19ee-4b61-8efa-8828279e7292"), new Guid("67019a3d-04de-444b-bb6c-6ef934dcd291"), "Pretty decent pizza", new Guid("a9063d88-88c6-40db-a7e9-868afeb45811"), 7, new DateTime(2025, 4, 15, 17, 0, 54, 546, DateTimeKind.Local).AddTicks(9666), null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_ApplicationUserId",
                table: "Reviews",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_FoodId",
                table: "Reviews",
                column: "FoodId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_RoomId",
                table: "Reviews",
                column: "RoomId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reviews");

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

            migrationBuilder.UpdateData(
                table: "FoodOrders",
                keyColumn: "Id",
                keyValue: new Guid("41d65c90-de3e-49be-8802-8cbc5b4e2961"),
                column: "OrderDate",
                value: new DateTime(2025, 4, 15, 16, 42, 45, 564, DateTimeKind.Local).AddTicks(2374));

            migrationBuilder.UpdateData(
                table: "FoodOrders",
                keyColumn: "Id",
                keyValue: new Guid("41d65c90-de3e-49be-8802-8cbc5b4e2962"),
                column: "OrderDate",
                value: new DateTime(2025, 4, 15, 16, 42, 45, 566, DateTimeKind.Local).AddTicks(6390));
        }
    }
}
