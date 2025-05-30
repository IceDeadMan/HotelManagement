using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HotelManagement.Migrations
{
    /// <inheritdoc />
    public partial class KitchenStaff : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("87600eb8-1da1-452a-a0bc-0d9c808b4b15"), null, "KitchenStaff", "KITCHENSTAFF" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd291"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "beb17b4c-9768-4bda-8464-73effeb52bc1", "AQAAAAIAAYagAAAAEDYDWlqkIvFA1DaMOOAdtkGhWk8ZMpceTpGCyx3uyhXCfsY6DmHtm5XJIL4IC5RlOg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd292"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "92b0f463-1aa6-4f51-98e6-6ff1a43e759c", "AQAAAAIAAYagAAAAELHwDMhOAbf0IykmrnuXqUIgGkrovjHfnavHga/31A3Ah0uKXU82CW7gX0SvK2DDgg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd293"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "69a1e924-cfa0-4c0e-9462-00eee92cefef", "AQAAAAIAAYagAAAAEEzbwbvhk4rypU5gtQHn8/onVls4fTJZbe4ccUBmXvO0CKS9poGjiQW8kFmYOKEWJw==" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("67019a3d-04de-444b-bb6c-6ef934dcd294"), 0, "3f0b9396-2ea4-4154-b615-33d21759bade", "user4@example.com", true, false, null, "USER4@EXAMPLE.COM", "USER4", "AQAAAAIAAYagAAAAEB68YtMVL9DKCRl81XPGlulMgUx46uBj7qHk76fh9jch9mMXGTwWMeV1oWZ9hDtyow==", null, false, "67019a3d-04de-444b-bb6c-6ef934dcd294", false, "user4" },
                    { new Guid("67019a3d-04de-444b-bb6c-6ef934dcd295"), 0, "a16b5374-9ddc-47e9-b036-225c099ba221", "user5@example.com", true, false, null, "USER5@EXAMPLE.COM", "USER5", "AQAAAAIAAYagAAAAEBSH29Dqvls/QU47+xSW/ayjvnaYTIz0d7ul55rOq3I5cCYtRohC8OturggMLpCh0A==", null, false, "67019a3d-04de-444b-bb6c-6ef934dcd295", false, "user5" }
                });

            migrationBuilder.UpdateData(
                table: "FoodOrders",
                keyColumn: "Id",
                keyValue: new Guid("41d65c90-de3e-49be-8802-8cbc5b4e2961"),
                column: "OrderDate",
                value: new DateTime(2025, 5, 30, 13, 28, 22, 331, DateTimeKind.Local).AddTicks(8302));

            migrationBuilder.UpdateData(
                table: "FoodOrders",
                keyColumn: "Id",
                keyValue: new Guid("41d65c90-de3e-49be-8802-8cbc5b4e2962"),
                column: "OrderDate",
                value: new DateTime(2025, 5, 30, 13, 28, 22, 334, DateTimeKind.Local).AddTicks(2717));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7291"),
                column: "ReviewDate",
                value: new DateTime(2025, 5, 30, 13, 28, 22, 335, DateTimeKind.Local).AddTicks(4580));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7292"),
                column: "ReviewDate",
                value: new DateTime(2025, 5, 30, 13, 28, 22, 335, DateTimeKind.Local).AddTicks(5058));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7293"),
                column: "ReviewDate",
                value: new DateTime(2025, 5, 30, 13, 28, 22, 335, DateTimeKind.Local).AddTicks(5076));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7294"),
                column: "ReviewDate",
                value: new DateTime(2025, 5, 30, 13, 28, 22, 335, DateTimeKind.Local).AddTicks(5081));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("87600eb8-1da1-452a-a0bc-0d9c808b4b12"), new Guid("67019a3d-04de-444b-bb6c-6ef934dcd294") },
                    { new Guid("87600eb8-1da1-452a-a0bc-0d9c808b4b15"), new Guid("67019a3d-04de-444b-bb6c-6ef934dcd295") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("87600eb8-1da1-452a-a0bc-0d9c808b4b12"), new Guid("67019a3d-04de-444b-bb6c-6ef934dcd294") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("87600eb8-1da1-452a-a0bc-0d9c808b4b15"), new Guid("67019a3d-04de-444b-bb6c-6ef934dcd295") });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("87600eb8-1da1-452a-a0bc-0d9c808b4b15"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd294"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd295"));

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
    }
}
