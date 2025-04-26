using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelManagement.Migrations
{
    /// <inheritdoc />
    public partial class ModifiedEventSeeds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd291"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bb9ac7eb-ea56-437f-8334-5ba6b235059a", "AQAAAAIAAYagAAAAEHGs+SuuA2is42ieo14Vs3dR62dvzKvhcZCYWZp/5PQU06Wj3/GVvqs+pI11F9INqA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd292"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3c6eae80-36c5-460a-a54f-97ef749f0c14", "AQAAAAIAAYagAAAAEKZQOU8Wl1e+BMhPOV9mwF0M6kHm++CcQyK6i+eaKmckgMrzEVlP3L7PSlBkHk2pWg==" });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "Capacity", "Date", "Description", "Name" },
                values: new object[] { new Guid("6b7da81a-74a0-4d50-8cac-fea2f7897732"), 0, new DateTime(2023, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Enjoy a relaxing evening with smooth jazz.", "Jazz Night" });

            migrationBuilder.UpdateData(
                table: "FoodOrders",
                keyColumn: "Id",
                keyValue: new Guid("41d65c90-de3e-49be-8802-8cbc5b4e2961"),
                column: "OrderDate",
                value: new DateTime(2025, 4, 26, 18, 37, 5, 352, DateTimeKind.Local).AddTicks(8386));

            migrationBuilder.UpdateData(
                table: "FoodOrders",
                keyColumn: "Id",
                keyValue: new Guid("41d65c90-de3e-49be-8802-8cbc5b4e2962"),
                column: "OrderDate",
                value: new DateTime(2025, 4, 26, 18, 37, 5, 355, DateTimeKind.Local).AddTicks(1379));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7291"),
                column: "ReviewDate",
                value: new DateTime(2025, 4, 26, 18, 37, 5, 356, DateTimeKind.Local).AddTicks(394));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7292"),
                column: "ReviewDate",
                value: new DateTime(2025, 4, 26, 18, 37, 5, 356, DateTimeKind.Local).AddTicks(875));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("6b7da81a-74a0-4d50-8cac-fea2f7897732"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd291"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "24502bed-7f55-47c5-ab15-a5e0f41a792f", "AQAAAAIAAYagAAAAEIO/JnQ6z8dyAf59CivseIg4RpWKTIeuY6j9nagNQ+2mVy2+UVfLUub4mC6t3muvow==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd292"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4997f021-a2e3-46c1-bd53-d5276ffa5baa", "AQAAAAIAAYagAAAAEFuiUEYHt3oFodcSucgNWU51n4Kdq8A/pN/8AQ0pNH429PCPRUwB8B5o3G4C+DnQmA==" });

            migrationBuilder.UpdateData(
                table: "FoodOrders",
                keyColumn: "Id",
                keyValue: new Guid("41d65c90-de3e-49be-8802-8cbc5b4e2961"),
                column: "OrderDate",
                value: new DateTime(2025, 4, 26, 18, 20, 48, 243, DateTimeKind.Local).AddTicks(1615));

            migrationBuilder.UpdateData(
                table: "FoodOrders",
                keyColumn: "Id",
                keyValue: new Guid("41d65c90-de3e-49be-8802-8cbc5b4e2962"),
                column: "OrderDate",
                value: new DateTime(2025, 4, 26, 18, 20, 48, 245, DateTimeKind.Local).AddTicks(5160));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7291"),
                column: "ReviewDate",
                value: new DateTime(2025, 4, 26, 18, 20, 48, 246, DateTimeKind.Local).AddTicks(4273));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7292"),
                column: "ReviewDate",
                value: new DateTime(2025, 4, 26, 18, 20, 48, 246, DateTimeKind.Local).AddTicks(4764));
        }
    }
}
