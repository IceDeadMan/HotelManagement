using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HotelManagement.Migrations
{
    /// <inheritdoc />
    public partial class NewActivityRecordSeeds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("67019a3d-04de-444b-bb6c-6ef934dcd293"), 0, "18a52bb1-8ac4-41e5-9ba5-6ef4da1124bd", "user3@example.com", true, false, null, "USER3@EXAMPLE.COM", "USER3", "AQAAAAIAAYagAAAAEGbMaa4o6J8k6x8jxeay44MQ9Xot2iN2qFmoGgIWiHgpntcZpncFPODOTeQIdZWKpw==", null, false, "67019a3d-04de-444b-bb6c-6ef934dcd293", false, "user3" });

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

            migrationBuilder.InsertData(
                table: "ActivityRecords",
                columns: new[] { "Id", "ApplicationUserId", "Date", "Description", "RoomId", "Status", "Type" },
                values: new object[,]
                {
                    { new Guid("db1ae6ab-91a7-4aaf-a08a-4097ce670a32"), new Guid("67019a3d-04de-444b-bb6c-6ef934dcd293"), new DateTime(2023, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Room 102 maintenance", new Guid("a242ae42-b5f3-417e-9277-b89ac16fca22"), 2, 1 },
                    { new Guid("db1ae6ab-91a7-4aaf-a08a-4097ce670a33"), new Guid("67019a3d-04de-444b-bb6c-6ef934dcd293"), new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Room 102 cleaning", new Guid("a242ae42-b5f3-417e-9277-b89ac16fca22"), 0, 0 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("87600eb8-1da1-452a-a0bc-0d9c808b4b14"), new Guid("67019a3d-04de-444b-bb6c-6ef934dcd293") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ActivityRecords",
                keyColumn: "Id",
                keyValue: new Guid("db1ae6ab-91a7-4aaf-a08a-4097ce670a32"));

            migrationBuilder.DeleteData(
                table: "ActivityRecords",
                keyColumn: "Id",
                keyValue: new Guid("db1ae6ab-91a7-4aaf-a08a-4097ce670a33"));

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("87600eb8-1da1-452a-a0bc-0d9c808b4b14"), new Guid("67019a3d-04de-444b-bb6c-6ef934dcd293") });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd293"));

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
    }
}
