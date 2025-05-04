using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelManagement.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RoomType",
                table: "Rooms",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd291"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e8b3418e-a2ab-41bf-aa8d-b4b219ae343f", "AQAAAAIAAYagAAAAEL26xAXJAUgGT+ZUpWTWI5e3nqcK7o7X/kBm2rmk4IA6GIpFziOKZ9E41xj5yw4Evg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd292"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9bbb0777-e395-48b4-8c20-9bb56170b0fa", "AQAAAAIAAYagAAAAEOngcyCg/1X+TcRaYlhWg59h0sn8qiLAIQFMdK3j2qEAAH9ziEqBLM1cdyMYVs188Q==" });

            migrationBuilder.UpdateData(
                table: "FoodOrders",
                keyColumn: "Id",
                keyValue: new Guid("41d65c90-de3e-49be-8802-8cbc5b4e2961"),
                column: "OrderDate",
                value: new DateTime(2025, 5, 4, 18, 45, 18, 19, DateTimeKind.Local).AddTicks(6958));

            migrationBuilder.UpdateData(
                table: "FoodOrders",
                keyColumn: "Id",
                keyValue: new Guid("41d65c90-de3e-49be-8802-8cbc5b4e2962"),
                column: "OrderDate",
                value: new DateTime(2025, 5, 4, 18, 45, 18, 22, DateTimeKind.Local).AddTicks(7745));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7291"),
                column: "ReviewDate",
                value: new DateTime(2025, 5, 4, 18, 45, 18, 23, DateTimeKind.Local).AddTicks(7514));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7292"),
                column: "ReviewDate",
                value: new DateTime(2025, 5, 4, 18, 45, 18, 23, DateTimeKind.Local).AddTicks(7878));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("a242ae42-b5f3-417e-9277-b89ac16fca21"),
                column: "RoomType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("a242ae42-b5f3-417e-9277-b89ac16fca22"),
                column: "RoomType",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("a242ae42-b5f3-417e-9277-b89ac16fca23"),
                column: "RoomType",
                value: 2);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RoomType",
                table: "Rooms");

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
    }
}
