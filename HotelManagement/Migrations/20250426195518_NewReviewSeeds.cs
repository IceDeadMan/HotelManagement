using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HotelManagement.Migrations
{
    /// <inheritdoc />
    public partial class NewReviewSeeds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd291"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "768aefaf-48ca-4b7b-8d88-c380fdb4dcdb", "AQAAAAIAAYagAAAAENaNW3mXKfMOtuzVDgOZWwMbRyHMNp93Jl+QEOAZQv++KZJoAmP62SevioHzxcp2cA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd292"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c584d95b-2b2f-4022-9a84-7ecb383f5095", "AQAAAAIAAYagAAAAEP8XaB4DJ0EL+AemDoeuKyYZFiJBNq4pBC/BgZZTbMGy4giFdbsDmUooHp6Q97SPxg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd293"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c1887ccb-a6e6-4deb-9248-8ccfd80638f0", "AQAAAAIAAYagAAAAEDu434KSOQUDfudjMHWSUaRFAUA1keJmwPWhgJ9Ssqju9qG05cnlAyiG22laLjK4FQ==" });

            migrationBuilder.UpdateData(
                table: "FoodOrders",
                keyColumn: "Id",
                keyValue: new Guid("41d65c90-de3e-49be-8802-8cbc5b4e2961"),
                column: "OrderDate",
                value: new DateTime(2025, 4, 26, 22, 55, 18, 23, DateTimeKind.Local).AddTicks(6676));

            migrationBuilder.UpdateData(
                table: "FoodOrders",
                keyColumn: "Id",
                keyValue: new Guid("41d65c90-de3e-49be-8802-8cbc5b4e2962"),
                column: "OrderDate",
                value: new DateTime(2025, 4, 26, 22, 55, 18, 26, DateTimeKind.Local).AddTicks(1044));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7291"),
                column: "ReviewDate",
                value: new DateTime(2025, 4, 26, 22, 55, 18, 27, DateTimeKind.Local).AddTicks(2332));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7292"),
                column: "ReviewDate",
                value: new DateTime(2025, 4, 26, 22, 55, 18, 27, DateTimeKind.Local).AddTicks(2891));

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "ApplicationUserId", "Comment", "FoodId", "Rating", "ReviewDate", "RoomId" },
                values: new object[,]
                {
                    { new Guid("4aef3307-19ee-4b61-8efa-8828279e7293"), new Guid("67019a3d-04de-444b-bb6c-6ef934dcd291"), "Average experience, could be better.", null, 5, new DateTime(2025, 4, 26, 22, 55, 18, 27, DateTimeKind.Local).AddTicks(2912), new Guid("a242ae42-b5f3-417e-9277-b89ac16fca22") },
                    { new Guid("4aef3307-19ee-4b61-8efa-8828279e7294"), new Guid("67019a3d-04de-444b-bb6c-6ef934dcd291"), "Great burger, will order again!", new Guid("a9063d88-88c6-40db-a7e9-868afeb45812"), 8, new DateTime(2025, 4, 26, 22, 55, 18, 27, DateTimeKind.Local).AddTicks(2916), null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7293"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7294"));

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
        }
    }
}
