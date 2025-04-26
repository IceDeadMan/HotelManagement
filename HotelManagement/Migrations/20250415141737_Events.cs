using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HotelManagement.Migrations
{
    /// <inheritdoc />
    public partial class Events : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Event",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Capacity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Event", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EventUsers",
                columns: table => new
                {
                    UsersId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EventsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventUsers", x => new { x.UsersId, x.EventsId });
                    table.ForeignKey(
                        name: "FK_EventUsers_AspNetUsers_UsersId",
                        column: x => x.UsersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EventUsers_Event_EventsId",
                        column: x => x.EventsId,
                        principalTable: "Event",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd291"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "26279be2-2aa9-4c92-9b1f-0dcc161fc38d", "AQAAAAIAAYagAAAAEBmihLSvRZ47pqHyh6wWLoa3jRjg+R+izG4VY1wXADadOQt2Ei7oJLIS0XofZpoIrg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd292"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8ea1318f-3363-4faf-a531-3430dc2b0a3f", "AQAAAAIAAYagAAAAEJNezKmk8L329hRAC7C5AWsSGjX9RLeS1nzDjl/HJzDpA5+8/MShLQj7VjWpPKsXmA==" });

            migrationBuilder.InsertData(
                table: "Event",
                columns: new[] { "Id", "Capacity", "Date", "Description", "Name" },
                values: new object[] { new Guid("5a6da81a-74a0-4d50-8cac-fea2f7897731"), 0, new DateTime(2023, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "A night of nostalgia with classic hits.", "Oldies Party" });

            migrationBuilder.UpdateData(
                table: "FoodOrders",
                keyColumn: "Id",
                keyValue: new Guid("41d65c90-de3e-49be-8802-8cbc5b4e2961"),
                column: "OrderDate",
                value: new DateTime(2025, 4, 15, 17, 17, 36, 285, DateTimeKind.Local).AddTicks(309));

            migrationBuilder.UpdateData(
                table: "FoodOrders",
                keyColumn: "Id",
                keyValue: new Guid("41d65c90-de3e-49be-8802-8cbc5b4e2962"),
                column: "OrderDate",
                value: new DateTime(2025, 4, 15, 17, 17, 36, 287, DateTimeKind.Local).AddTicks(2992));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7291"),
                column: "ReviewDate",
                value: new DateTime(2025, 4, 15, 17, 17, 36, 288, DateTimeKind.Local).AddTicks(2795));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7292"),
                column: "ReviewDate",
                value: new DateTime(2025, 4, 15, 17, 17, 36, 288, DateTimeKind.Local).AddTicks(3264));

            migrationBuilder.InsertData(
                table: "EventUsers",
                columns: new[] { "EventsId", "UsersId" },
                values: new object[,]
                {
                    { new Guid("5a6da81a-74a0-4d50-8cac-fea2f7897731"), new Guid("67019a3d-04de-444b-bb6c-6ef934dcd291") },
                    { new Guid("5a6da81a-74a0-4d50-8cac-fea2f7897731"), new Guid("67019a3d-04de-444b-bb6c-6ef934dcd292") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_EventUsers_EventsId",
                table: "EventUsers",
                column: "EventsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EventUsers");

            migrationBuilder.DropTable(
                name: "Event");

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

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7291"),
                column: "ReviewDate",
                value: new DateTime(2025, 4, 15, 17, 0, 54, 546, DateTimeKind.Local).AddTicks(9188));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7292"),
                column: "ReviewDate",
                value: new DateTime(2025, 4, 15, 17, 0, 54, 546, DateTimeKind.Local).AddTicks(9666));
        }
    }
}
