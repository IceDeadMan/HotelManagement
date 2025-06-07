using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HotelManagement.Migrations
{
    /// <inheritdoc />
    public partial class FixedSeeds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ActivityRecords",
                keyColumn: "Id",
                keyValue: new Guid("db1ae6ab-91a7-4aaf-a08a-4097ce670a31"),
                columns: new[] { "Date", "Status" },
                values: new object[] { new DateTime(2025, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "ActivityRecords",
                keyColumn: "Id",
                keyValue: new Guid("db1ae6ab-91a7-4aaf-a08a-4097ce670a33"),
                column: "Status",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ActivityRecords",
                keyColumn: "Id",
                keyValue: new Guid("db1ae6ab-91a7-4aaf-a08a-4097ce670a35"),
                column: "Status",
                value: 0);

            migrationBuilder.InsertData(
                table: "ActivityRecords",
                columns: new[] { "Id", "ApplicationUserId", "Date", "Description", "RoomId", "Status", "Type" },
                values: new object[] { new Guid("db1ae6ab-91a7-4aaf-a08a-4097ce670a37"), new Guid("67019a3d-04de-444b-bb6c-6ef934dcd294"), new DateTime(2025, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Room 107 cleaning", new Guid("a242ae42-b5f3-417e-9277-b89ac16fca27"), 1, 0 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd291"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7b5d7130-e66c-4b6d-aa20-1cada7e27029", "AQAAAAIAAYagAAAAEF2gWULBYd/PHP5JpOfMrXH5tYdu1VtluWCaWAYmO5ngXM7oNXDY4gAsTOUOb0iBbw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd292"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e6c416c2-5edc-4558-82cf-f240a521aefa", "AQAAAAIAAYagAAAAEI8dpxw3lTP71SOn/U2QlGnkiXs5UcEpv0iDJ1HRlFMO1UZ4XB8j2ccIhmGceEklQw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd293"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2e79dad2-54cd-4372-a465-e73c82b153ff", "AQAAAAIAAYagAAAAEEBTYZ97K1Exisz+6NVy/0zb0DeJbOOfoovJMZR5DJ8BP8OYWKh9jJnpBkasKKSxmA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd294"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8f8044f6-2dda-4490-adf5-a0e14631900d", "AQAAAAIAAYagAAAAED95wf78k5PJRAF/JJRPpK0uAONk/+077GmljDH9f4SRisDtu/SpwVo8oRJF1cxlsg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd295"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "682c4fb1-91f3-41a8-b4d2-ce6e7395c05c", "AQAAAAIAAYagAAAAEMqP8lUC4X8D8jfaQqp17pxximvWtH2VVmj6vTI669PQgemA+eL3RgP7Dw3pH0yQtg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd296"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ac6234eb-6a87-43ef-8d78-456c9d327fa9", "AQAAAAIAAYagAAAAEB21X8Y6Fil8i4yQnEix33jHFzE5exOSoSc9DlwQGFPW72eQdCRbF0eJhYf3G0o0TA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd297"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1ad80b9f-4c09-4af7-9af7-468add145bf8", "AQAAAAIAAYagAAAAEEgDhST5VX8ReS3ydoikh1ulzwrP6eKWdoATGBkrDDKbttxQe+AovObRMEhnbdlnyQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd298"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e856f694-c348-40ce-8af1-1a135164acb3", "AQAAAAIAAYagAAAAEEANCRoDlmEoAqUbX4j5FGB7OnxJyFedKq3vGmYPnz3hVchN7AD8K4FZPuW3meZ1/Q==" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("67019a3d-04de-444b-bb6c-6ef934dcd299"), 0, "99c63e66-9fe6-4343-8e4c-cc5994ab4cca", "user9@example.com", true, "Jozef", "Mrkva", false, null, "USER9@EXAMPLE.COM", "USER9", "AQAAAAIAAYagAAAAEDFhbyBLNcN1m34UxV8/vWhC/TDriHp99Q2KBD9B4udAMSSiZxIzvX3RlTxkKApn4A==", "+421 905 888 197", false, "67019a3d-04de-444b-bb6c-6ef934dcd299", false, "user9" },
                    { new Guid("67019a3d-04de-444b-bb6c-6ef934dcd29a"), 0, "f3a82077-e198-4ab0-9415-072d3bb627c7", "user10@example.com", true, "Milan", "Bobor", false, null, "USER10@EXAMPLE.COM", "USER10", "AQAAAAIAAYagAAAAEK7U3xuC786n0pgdsNmoUkKPDNxzL6BbAaTBCbdUdV9xYnnxFcOtv0XsXcovwkBBrQ==", "+421 905 888 712", false, "67019a3d-04de-444b-bb6c-6ef934dcd29a", false, "user10" }
                });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: new Guid("371c096d-5c0b-4929-aab5-1c0289611902"),
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: new Guid("371c096d-5c0b-4929-aab5-1c0289611903"),
                column: "Status",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: new Guid("371c096d-5c0b-4929-aab5-1c0289611904"),
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: new Guid("371c096d-5c0b-4929-aab5-1c0289611905"),
                columns: new[] { "EndDate", "StartDate", "Status" },
                values: new object[] { new DateTime(2024, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "Bookings",
                columns: new[] { "Id", "ApplicationUserId", "EndDate", "StartDate", "Status" },
                values: new object[] { new Guid("371c096d-5c0b-4929-aab5-1c0289611907"), new Guid("67019a3d-04de-444b-bb6c-6ef934dcd297"), new DateTime(2025, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("7c8da81a-74a0-4d50-8cac-fea2f7897733"),
                column: "Date",
                value: new DateTime(2025, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "FoodOrders",
                keyColumn: "Id",
                keyValue: new Guid("41d65c90-de3e-49be-8802-8cbc5b4e2961"),
                column: "OrderDate",
                value: new DateTime(2025, 6, 7, 20, 4, 18, 960, DateTimeKind.Local).AddTicks(88));

            migrationBuilder.UpdateData(
                table: "FoodOrders",
                keyColumn: "Id",
                keyValue: new Guid("41d65c90-de3e-49be-8802-8cbc5b4e2962"),
                column: "OrderDate",
                value: new DateTime(2025, 6, 7, 20, 4, 18, 960, DateTimeKind.Local).AddTicks(1116));

            migrationBuilder.UpdateData(
                table: "FoodOrders",
                keyColumn: "Id",
                keyValue: new Guid("41d65c90-de3e-49be-8802-8cbc5b4e2963"),
                column: "OrderDate",
                value: new DateTime(2025, 6, 7, 18, 4, 18, 960, DateTimeKind.Local).AddTicks(1134));

            migrationBuilder.UpdateData(
                table: "FoodOrders",
                keyColumn: "Id",
                keyValue: new Guid("41d65c90-de3e-49be-8802-8cbc5b4e2964"),
                column: "OrderDate",
                value: new DateTime(2025, 6, 6, 20, 4, 18, 960, DateTimeKind.Local).AddTicks(1152));

            migrationBuilder.UpdateData(
                table: "FoodOrders",
                keyColumn: "Id",
                keyValue: new Guid("41d65c90-de3e-49be-8802-8cbc5b4e2965"),
                column: "OrderDate",
                value: new DateTime(2025, 6, 7, 20, 4, 18, 960, DateTimeKind.Local).AddTicks(1158));

            migrationBuilder.InsertData(
                table: "FoodOrders",
                columns: new[] { "Id", "ApplicationUserId", "Description", "OrderDate", "RoomId", "Status" },
                values: new object[] { new Guid("41d65c90-de3e-49be-8802-8cbc5b4e2966"), new Guid("67019a3d-04de-444b-bb6c-6ef934dcd297"), "Dinner", new DateTime(2025, 6, 4, 20, 4, 18, 960, DateTimeKind.Local).AddTicks(1162), new Guid("a242ae42-b5f3-417e-9277-b89ac16fca33"), 2 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7291"),
                column: "ReviewDate",
                value: new DateTime(2025, 6, 7, 20, 4, 18, 961, DateTimeKind.Local).AddTicks(6989));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7292"),
                column: "ReviewDate",
                value: new DateTime(2025, 6, 7, 20, 4, 18, 961, DateTimeKind.Local).AddTicks(7472));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7293"),
                column: "ReviewDate",
                value: new DateTime(2025, 6, 7, 20, 4, 18, 961, DateTimeKind.Local).AddTicks(7491));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7294"),
                column: "ReviewDate",
                value: new DateTime(2025, 6, 7, 20, 4, 18, 961, DateTimeKind.Local).AddTicks(7497));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7295"),
                column: "ReviewDate",
                value: new DateTime(2025, 6, 7, 20, 4, 18, 961, DateTimeKind.Local).AddTicks(7507));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7296"),
                column: "ReviewDate",
                value: new DateTime(2025, 6, 7, 20, 4, 18, 961, DateTimeKind.Local).AddTicks(7511));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7297"),
                column: "ReviewDate",
                value: new DateTime(2025, 6, 7, 20, 4, 18, 961, DateTimeKind.Local).AddTicks(7515));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7298"),
                column: "ReviewDate",
                value: new DateTime(2025, 6, 7, 20, 4, 18, 961, DateTimeKind.Local).AddTicks(7519));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7299"),
                column: "ReviewDate",
                value: new DateTime(2025, 6, 7, 20, 4, 18, 961, DateTimeKind.Local).AddTicks(7523));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("87600eb8-1da1-452a-a0bc-0d9c808b4b14"), new Guid("67019a3d-04de-444b-bb6c-6ef934dcd299") },
                    { new Guid("87600eb8-1da1-452a-a0bc-0d9c808b4b15"), new Guid("67019a3d-04de-444b-bb6c-6ef934dcd29a") }
                });

            migrationBuilder.InsertData(
                table: "FoodOrderFoods",
                columns: new[] { "FoodId", "FoodOrderId", "Quantity" },
                values: new object[] { new Guid("a9063d88-88c6-40db-a7e9-868afeb45823"), new Guid("41d65c90-de3e-49be-8802-8cbc5b4e2966"), 1 });

            migrationBuilder.InsertData(
                table: "RoomBookings",
                columns: new[] { "BookingsId", "RoomsId" },
                values: new object[] { new Guid("371c096d-5c0b-4929-aab5-1c0289611907"), new Guid("a242ae42-b5f3-417e-9277-b89ac16fca33") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ActivityRecords",
                keyColumn: "Id",
                keyValue: new Guid("db1ae6ab-91a7-4aaf-a08a-4097ce670a37"));

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("87600eb8-1da1-452a-a0bc-0d9c808b4b14"), new Guid("67019a3d-04de-444b-bb6c-6ef934dcd299") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("87600eb8-1da1-452a-a0bc-0d9c808b4b15"), new Guid("67019a3d-04de-444b-bb6c-6ef934dcd29a") });

            migrationBuilder.DeleteData(
                table: "FoodOrderFoods",
                keyColumns: new[] { "FoodId", "FoodOrderId" },
                keyValues: new object[] { new Guid("a9063d88-88c6-40db-a7e9-868afeb45823"), new Guid("41d65c90-de3e-49be-8802-8cbc5b4e2966") });

            migrationBuilder.DeleteData(
                table: "RoomBookings",
                keyColumns: new[] { "BookingsId", "RoomsId" },
                keyValues: new object[] { new Guid("371c096d-5c0b-4929-aab5-1c0289611907"), new Guid("a242ae42-b5f3-417e-9277-b89ac16fca33") });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd299"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd29a"));

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: new Guid("371c096d-5c0b-4929-aab5-1c0289611907"));

            migrationBuilder.DeleteData(
                table: "FoodOrders",
                keyColumn: "Id",
                keyValue: new Guid("41d65c90-de3e-49be-8802-8cbc5b4e2966"));

            migrationBuilder.UpdateData(
                table: "ActivityRecords",
                keyColumn: "Id",
                keyValue: new Guid("db1ae6ab-91a7-4aaf-a08a-4097ce670a31"),
                columns: new[] { "Date", "Status" },
                values: new object[] { new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ActivityRecords",
                keyColumn: "Id",
                keyValue: new Guid("db1ae6ab-91a7-4aaf-a08a-4097ce670a33"),
                column: "Status",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ActivityRecords",
                keyColumn: "Id",
                keyValue: new Guid("db1ae6ab-91a7-4aaf-a08a-4097ce670a35"),
                column: "Status",
                value: 2);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd291"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "934f4ad6-0877-40ff-9aaf-5f59d11502b0", "AQAAAAIAAYagAAAAEFOPCYTG0XlAdb5omvAuSpiDZMlhOsKQaWuqwMrxRv7a1oNOHZ8HWy1zAB7KS5l6Dw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd292"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a9f6185a-df8e-4790-92c7-1cc79a309fd6", "AQAAAAIAAYagAAAAEEwLvU5pZMg1yscjD1T7yj+T1EHaNTBv52z5j0aMFgz/umguauOFhJGV4qi1NR+Sug==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd293"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f4a9d4b9-95df-4958-93e8-801329fb6854", "AQAAAAIAAYagAAAAEOuo7VVL68eMyMOg9lm8MfIOiBuiWjv9rfS/xbGuuwSWKjb3/5g9oKGvWfNLEtQf8g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd294"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ef69228b-28fc-4190-b786-642de47b217b", "AQAAAAIAAYagAAAAEBMxPun5aNMKc9nimiQpwGGx7EwFTqE1yTuM7ZVn3EWMvErH3ikPK/BD+T8MguKz3Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd295"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ca4d9ce1-ec3c-4d05-a909-f26dc29fa177", "AQAAAAIAAYagAAAAEJIJgX4HZ+MgpT5tgvF6ND+aHxc06asK+/QBSmjUDIEzmC7rNnjshj0AkNczmbvWCg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd296"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1cf13433-344e-46fd-a9be-1ffda5efda86", "AQAAAAIAAYagAAAAEDpWGnQuatHDWjbCXEjJcJ7D8NALMx6de4wdElC8wJu5HBjS9saeYXt7BPoCKCHeGQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd297"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1f62ba48-e3a3-4a99-b07d-78458a3294e1", "AQAAAAIAAYagAAAAEInWZ7oej3i9sHqjJPOpd5mhHIzvUMlbLZEryi2LQ9vbrRUYlbYBjOguQgTYvHHGvA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd298"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6ea0e2c9-9482-4edb-be3a-2183dd04466d", "AQAAAAIAAYagAAAAEJ6QBuz7d2qWH+ng80yR4pkaLOw7zKTdY3lRbr1t3vAlaMdBSrbbbfZx1jPiW+ipwg==" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: new Guid("371c096d-5c0b-4929-aab5-1c0289611902"),
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: new Guid("371c096d-5c0b-4929-aab5-1c0289611903"),
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: new Guid("371c096d-5c0b-4929-aab5-1c0289611904"),
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: new Guid("371c096d-5c0b-4929-aab5-1c0289611905"),
                columns: new[] { "EndDate", "StartDate", "Status" },
                values: new object[] { new DateTime(2025, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("7c8da81a-74a0-4d50-8cac-fea2f7897733"),
                column: "Date",
                value: new DateTime(2025, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "FoodOrders",
                keyColumn: "Id",
                keyValue: new Guid("41d65c90-de3e-49be-8802-8cbc5b4e2961"),
                column: "OrderDate",
                value: new DateTime(2025, 6, 3, 14, 11, 56, 434, DateTimeKind.Local).AddTicks(8526));

            migrationBuilder.UpdateData(
                table: "FoodOrders",
                keyColumn: "Id",
                keyValue: new Guid("41d65c90-de3e-49be-8802-8cbc5b4e2962"),
                column: "OrderDate",
                value: new DateTime(2025, 6, 3, 14, 11, 56, 434, DateTimeKind.Local).AddTicks(9531));

            migrationBuilder.UpdateData(
                table: "FoodOrders",
                keyColumn: "Id",
                keyValue: new Guid("41d65c90-de3e-49be-8802-8cbc5b4e2963"),
                column: "OrderDate",
                value: new DateTime(2025, 6, 3, 12, 11, 56, 434, DateTimeKind.Local).AddTicks(9547));

            migrationBuilder.UpdateData(
                table: "FoodOrders",
                keyColumn: "Id",
                keyValue: new Guid("41d65c90-de3e-49be-8802-8cbc5b4e2964"),
                column: "OrderDate",
                value: new DateTime(2025, 6, 2, 14, 11, 56, 434, DateTimeKind.Local).AddTicks(9568));

            migrationBuilder.UpdateData(
                table: "FoodOrders",
                keyColumn: "Id",
                keyValue: new Guid("41d65c90-de3e-49be-8802-8cbc5b4e2965"),
                column: "OrderDate",
                value: new DateTime(2025, 6, 3, 14, 11, 56, 434, DateTimeKind.Local).AddTicks(9575));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7291"),
                column: "ReviewDate",
                value: new DateTime(2025, 6, 3, 14, 11, 56, 436, DateTimeKind.Local).AddTicks(5203));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7292"),
                column: "ReviewDate",
                value: new DateTime(2025, 6, 3, 14, 11, 56, 436, DateTimeKind.Local).AddTicks(5684));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7293"),
                column: "ReviewDate",
                value: new DateTime(2025, 6, 3, 14, 11, 56, 436, DateTimeKind.Local).AddTicks(5709));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7294"),
                column: "ReviewDate",
                value: new DateTime(2025, 6, 3, 14, 11, 56, 436, DateTimeKind.Local).AddTicks(5714));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7295"),
                column: "ReviewDate",
                value: new DateTime(2025, 6, 3, 14, 11, 56, 436, DateTimeKind.Local).AddTicks(5718));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7296"),
                column: "ReviewDate",
                value: new DateTime(2025, 6, 3, 14, 11, 56, 436, DateTimeKind.Local).AddTicks(5722));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7297"),
                column: "ReviewDate",
                value: new DateTime(2025, 6, 3, 14, 11, 56, 436, DateTimeKind.Local).AddTicks(5726));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7298"),
                column: "ReviewDate",
                value: new DateTime(2025, 6, 3, 14, 11, 56, 436, DateTimeKind.Local).AddTicks(5730));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7299"),
                column: "ReviewDate",
                value: new DateTime(2025, 6, 3, 14, 11, 56, 436, DateTimeKind.Local).AddTicks(5735));
        }
    }
}
