using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelManagement.Migrations
{
    /// <inheritdoc />
    public partial class FoodAvailability : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsAvailable",
                table: "Foods",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd291"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "31b77411-fae4-407c-8e20-4c3fc64bbe7a", "AQAAAAIAAYagAAAAEH3a3ZyaPwUEzIYhitdjjXx4B6hkKft71U28bA8j2xwaUQJKI3028ayxFx2UURvwkA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd292"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "74a0e490-db95-4b04-8fbc-5ea4fb283dfc", "AQAAAAIAAYagAAAAEDebyobsy5Xt4fcrKuLuxnMikO0EpE92RPn9+rwiDD+TtB4v6EKdsQ3clc1KRsf+Wg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd293"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5e871fd0-d015-45a4-9f40-bb17b577c62e", "AQAAAAIAAYagAAAAELS6U5JwjQfaqB3Umq7B40WuDt/fsPTV2pm1LTu8g8UBvABln3fsXfg8UNEI0Q/VrA==" });

            migrationBuilder.UpdateData(
                table: "FoodOrders",
                keyColumn: "Id",
                keyValue: new Guid("41d65c90-de3e-49be-8802-8cbc5b4e2961"),
                column: "OrderDate",
                value: new DateTime(2025, 5, 30, 13, 13, 47, 1, DateTimeKind.Local).AddTicks(3321));

            migrationBuilder.UpdateData(
                table: "FoodOrders",
                keyColumn: "Id",
                keyValue: new Guid("41d65c90-de3e-49be-8802-8cbc5b4e2962"),
                column: "OrderDate",
                value: new DateTime(2025, 5, 30, 13, 13, 47, 3, DateTimeKind.Local).AddTicks(6791));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("a9063d88-88c6-40db-a7e9-868afeb45811"),
                column: "IsAvailable",
                value: true);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("a9063d88-88c6-40db-a7e9-868afeb45812"),
                column: "IsAvailable",
                value: true);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("a9063d88-88c6-40db-a7e9-868afeb45813"),
                column: "IsAvailable",
                value: true);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7291"),
                column: "ReviewDate",
                value: new DateTime(2025, 5, 30, 13, 13, 47, 4, DateTimeKind.Local).AddTicks(9044));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7292"),
                column: "ReviewDate",
                value: new DateTime(2025, 5, 30, 13, 13, 47, 4, DateTimeKind.Local).AddTicks(9526));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7293"),
                column: "ReviewDate",
                value: new DateTime(2025, 5, 30, 13, 13, 47, 4, DateTimeKind.Local).AddTicks(9543));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7294"),
                column: "ReviewDate",
                value: new DateTime(2025, 5, 30, 13, 13, 47, 4, DateTimeKind.Local).AddTicks(9548));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsAvailable",
                table: "Foods");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd291"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3ab96b3e-5da7-431b-ab20-90683e572f8a", "AQAAAAIAAYagAAAAECY8Yx1Vu7sbmDsYX8YpB+2MMpM08ME3d0FA5xR2RrFh2Rx5awe7haANoglQ3+Juow==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd292"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d2c766e4-a087-42a3-b535-eb54a50cb14e", "AQAAAAIAAYagAAAAEPme093W6wxeNRcd6HnafAjZxMxc3h6JGe5d9uqkYIbzBb0n+6ifR54sQxcIs91kPQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd293"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3c8ae24b-12fe-4737-8adb-f26f4c780466", "AQAAAAIAAYagAAAAEGmrwC8MFKhWbKpxnyxgXZtwZS21tWBH2BDl7up8OXJiLwc/3eYUsoJKQ3QRDaBV5Q==" });

            migrationBuilder.UpdateData(
                table: "FoodOrders",
                keyColumn: "Id",
                keyValue: new Guid("41d65c90-de3e-49be-8802-8cbc5b4e2961"),
                column: "OrderDate",
                value: new DateTime(2025, 5, 30, 12, 58, 34, 763, DateTimeKind.Local).AddTicks(2654));

            migrationBuilder.UpdateData(
                table: "FoodOrders",
                keyColumn: "Id",
                keyValue: new Guid("41d65c90-de3e-49be-8802-8cbc5b4e2962"),
                column: "OrderDate",
                value: new DateTime(2025, 5, 30, 12, 58, 34, 765, DateTimeKind.Local).AddTicks(5451));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7291"),
                column: "ReviewDate",
                value: new DateTime(2025, 5, 30, 12, 58, 34, 766, DateTimeKind.Local).AddTicks(6916));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7292"),
                column: "ReviewDate",
                value: new DateTime(2025, 5, 30, 12, 58, 34, 766, DateTimeKind.Local).AddTicks(7385));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7293"),
                column: "ReviewDate",
                value: new DateTime(2025, 5, 30, 12, 58, 34, 766, DateTimeKind.Local).AddTicks(7401));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7294"),
                column: "ReviewDate",
                value: new DateTime(2025, 5, 30, 12, 58, 34, 766, DateTimeKind.Local).AddTicks(7412));
        }
    }
}
