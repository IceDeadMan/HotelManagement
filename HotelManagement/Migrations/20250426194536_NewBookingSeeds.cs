using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelManagement.Migrations
{
    /// <inheritdoc />
    public partial class NewBookingSeeds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd291"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "26dbb6c1-aced-4aea-b79f-c34eb3759c02", "AQAAAAIAAYagAAAAEPqhSFaz/oore55RtmnHqhcMcIgcdZQeTNn7dtzp3MnNPrmiIZ7XUVdqR7uKrzRw6g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd292"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "96c2da21-1cfc-4b5d-8f20-9bb9a7a46f0e", "AQAAAAIAAYagAAAAEHS5hr16a2AqzEk4xd/VqSAeNNXedurOImYjJZQ2UfU8LNEGkW2z6dm1b95DaZJbPw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd293"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fe749ed2-6758-449b-a36f-24f4ed3e2b00", "AQAAAAIAAYagAAAAELJC5Okc7LR/8wTeden1nQ1Pfczpa04BflhfuQnzA+czm/9nsWprwnsOu+OR005ugg==" });

            migrationBuilder.InsertData(
                table: "Bookings",
                columns: new[] { "Id", "ApplicationUserId", "EndDate", "StartDate", "Status" },
                values: new object[] { new Guid("371c096d-5c0b-4929-aab5-1c0289611902"), new Guid("67019a3d-04de-444b-bb6c-6ef934dcd291"), new DateTime(2025, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "FoodOrders",
                keyColumn: "Id",
                keyValue: new Guid("41d65c90-de3e-49be-8802-8cbc5b4e2961"),
                column: "OrderDate",
                value: new DateTime(2025, 4, 26, 22, 45, 35, 518, DateTimeKind.Local).AddTicks(8049));

            migrationBuilder.UpdateData(
                table: "FoodOrders",
                keyColumn: "Id",
                keyValue: new Guid("41d65c90-de3e-49be-8802-8cbc5b4e2962"),
                column: "OrderDate",
                value: new DateTime(2025, 4, 26, 22, 45, 35, 521, DateTimeKind.Local).AddTicks(1374));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7291"),
                column: "ReviewDate",
                value: new DateTime(2025, 4, 26, 22, 45, 35, 522, DateTimeKind.Local).AddTicks(1801));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7292"),
                column: "ReviewDate",
                value: new DateTime(2025, 4, 26, 22, 45, 35, 522, DateTimeKind.Local).AddTicks(2316));

            migrationBuilder.InsertData(
                table: "RoomBookings",
                columns: new[] { "BookingsId", "RoomsId" },
                values: new object[] { new Guid("371c096d-5c0b-4929-aab5-1c0289611902"), new Guid("a242ae42-b5f3-417e-9277-b89ac16fca21") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RoomBookings",
                keyColumns: new[] { "BookingsId", "RoomsId" },
                keyValues: new object[] { new Guid("371c096d-5c0b-4929-aab5-1c0289611902"), new Guid("a242ae42-b5f3-417e-9277-b89ac16fca21") });

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: new Guid("371c096d-5c0b-4929-aab5-1c0289611902"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd291"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ac0662b7-4eb8-49c3-be22-2d34a0719a70", "AQAAAAIAAYagAAAAEMwLzEp3qTqS8fkJqo5UPTP0CyOAUsjLJ4jwFLfBSUxL3rjT0S3BetlEGf+iVo1Yaw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd292"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7b426b3e-bc3e-401f-a89a-7bfcbdcdd000", "AQAAAAIAAYagAAAAEE9H7IaJbqu+H6RxXqwywHaMzH5HrafvvYGauFCnJKi2tDM6ea7eT6Ap3VOZxKGP2g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd293"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "18a52bb1-8ac4-41e5-9ba5-6ef4da1124bd", "AQAAAAIAAYagAAAAEGbMaa4o6J8k6x8jxeay44MQ9Xot2iN2qFmoGgIWiHgpntcZpncFPODOTeQIdZWKpw==" });

            migrationBuilder.UpdateData(
                table: "FoodOrders",
                keyColumn: "Id",
                keyValue: new Guid("41d65c90-de3e-49be-8802-8cbc5b4e2961"),
                column: "OrderDate",
                value: new DateTime(2025, 4, 26, 21, 58, 43, 905, DateTimeKind.Local).AddTicks(7998));

            migrationBuilder.UpdateData(
                table: "FoodOrders",
                keyColumn: "Id",
                keyValue: new Guid("41d65c90-de3e-49be-8802-8cbc5b4e2962"),
                column: "OrderDate",
                value: new DateTime(2025, 4, 26, 21, 58, 43, 908, DateTimeKind.Local).AddTicks(1438));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7291"),
                column: "ReviewDate",
                value: new DateTime(2025, 4, 26, 21, 58, 43, 909, DateTimeKind.Local).AddTicks(1712));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7292"),
                column: "ReviewDate",
                value: new DateTime(2025, 4, 26, 21, 58, 43, 909, DateTimeKind.Local).AddTicks(2649));
        }
    }
}
