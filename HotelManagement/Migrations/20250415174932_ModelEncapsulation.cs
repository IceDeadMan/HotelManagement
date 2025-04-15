using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelManagement.Migrations
{
    /// <inheritdoc />
    public partial class ModelEncapsulation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd291"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c051735f-7ca4-4e32-84fd-86d5c244ebd5", "AQAAAAIAAYagAAAAEPE8Ki2+67YGTlysLFhmmRcRz8MeqUHMPZh1wkBizH1CXjaph/9SV9yTe/hJIBmIKQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd292"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f7c0796b-b3e3-474e-a415-9a93d01f05ad", "AQAAAAIAAYagAAAAEEWcH2pJIpnuW4wQ10x+bGJ1oScVxLoQwY0IYdruL1A/b/pOXM4gv5Ocfv0qzJnG2g==" });

            migrationBuilder.UpdateData(
                table: "FoodOrders",
                keyColumn: "Id",
                keyValue: new Guid("41d65c90-de3e-49be-8802-8cbc5b4e2961"),
                column: "OrderDate",
                value: new DateTime(2025, 4, 15, 20, 49, 31, 193, DateTimeKind.Local).AddTicks(9095));

            migrationBuilder.UpdateData(
                table: "FoodOrders",
                keyColumn: "Id",
                keyValue: new Guid("41d65c90-de3e-49be-8802-8cbc5b4e2962"),
                column: "OrderDate",
                value: new DateTime(2025, 4, 15, 20, 49, 31, 196, DateTimeKind.Local).AddTicks(1615));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7291"),
                column: "ReviewDate",
                value: new DateTime(2025, 4, 15, 20, 49, 31, 197, DateTimeKind.Local).AddTicks(177));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7292"),
                column: "ReviewDate",
                value: new DateTime(2025, 4, 15, 20, 49, 31, 197, DateTimeKind.Local).AddTicks(658));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
