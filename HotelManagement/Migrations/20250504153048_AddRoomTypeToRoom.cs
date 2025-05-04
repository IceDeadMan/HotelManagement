using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelManagement.Migrations
{
    /// <inheritdoc />
    public partial class AddRoomTypeToRoom : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd291"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f20850fe-3df1-477b-a7b5-d6f071f78e00", "AQAAAAIAAYagAAAAEFjLDX+Rjrng4IFFjcFJ7fjU/jZtM7/ENjhZi6SNL5TnCtpd+rCrFV72DYfifn/YVQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd292"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cd2e8057-7128-4a1d-85ed-e7d5f110be73", "AQAAAAIAAYagAAAAEMx6kaf8lZ2+qfKZIxFg2Iike+E3zoyH5/Au1CfWwYpz1uOXc0gH0v8v78KzxWdMtg==" });

            migrationBuilder.UpdateData(
                table: "FoodOrders",
                keyColumn: "Id",
                keyValue: new Guid("41d65c90-de3e-49be-8802-8cbc5b4e2961"),
                column: "OrderDate",
                value: new DateTime(2025, 5, 4, 18, 30, 47, 745, DateTimeKind.Local).AddTicks(8669));

            migrationBuilder.UpdateData(
                table: "FoodOrders",
                keyColumn: "Id",
                keyValue: new Guid("41d65c90-de3e-49be-8802-8cbc5b4e2962"),
                column: "OrderDate",
                value: new DateTime(2025, 5, 4, 18, 30, 47, 748, DateTimeKind.Local).AddTicks(3142));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7291"),
                column: "ReviewDate",
                value: new DateTime(2025, 5, 4, 18, 30, 47, 749, DateTimeKind.Local).AddTicks(702));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7292"),
                column: "ReviewDate",
                value: new DateTime(2025, 5, 4, 18, 30, 47, 749, DateTimeKind.Local).AddTicks(1132));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
