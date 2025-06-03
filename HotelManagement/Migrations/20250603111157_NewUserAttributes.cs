using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelManagement.Migrations
{
    /// <inheritdoc />
    public partial class NewUserAttributes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd291"),
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "PasswordHash", "PhoneNumber" },
                values: new object[] { "934f4ad6-0877-40ff-9aaf-5f59d11502b0", "John", "Doe", "AQAAAAIAAYagAAAAEFOPCYTG0XlAdb5omvAuSpiDZMlhOsKQaWuqwMrxRv7a1oNOHZ8HWy1zAB7KS5l6Dw==", "+421 987 654 321" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd292"),
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "PasswordHash", "PhoneNumber" },
                values: new object[] { "a9f6185a-df8e-4790-92c7-1cc79a309fd6", "Peter", "Novák", "AQAAAAIAAYagAAAAEEwLvU5pZMg1yscjD1T7yj+T1EHaNTBv52z5j0aMFgz/umguauOFhJGV4qi1NR+Sug==", "+421 912 345 678" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd293"),
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "PasswordHash", "PhoneNumber" },
                values: new object[] { "f4a9d4b9-95df-4958-93e8-801329fb6854", "Laura", "Kalniņa", "AQAAAAIAAYagAAAAEOuo7VVL68eMyMOg9lm8MfIOiBuiWjv9rfS/xbGuuwSWKjb3/5g9oKGvWfNLEtQf8g==", "+371 29876543" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd294"),
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "PasswordHash", "PhoneNumber" },
                values: new object[] { "ef69228b-28fc-4190-b786-642de47b217b", "Tomáš", "Kováč", "AQAAAAIAAYagAAAAEBMxPun5aNMKc9nimiQpwGGx7EwFTqE1yTuM7ZVn3EWMvErH3ikPK/BD+T8MguKz3Q==", "+421 903 222 111" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd295"),
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "PasswordHash", "PhoneNumber" },
                values: new object[] { "ca4d9ce1-ec3c-4d05-a909-f26dc29fa177", "Elīna", "Ozoliņa", "AQAAAAIAAYagAAAAEJIJgX4HZ+MgpT5tgvF6ND+aHxc06asK+/QBSmjUDIEzmC7rNnjshj0AkNczmbvWCg==", "+371 26443322" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd296"),
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "PasswordHash", "PhoneNumber" },
                values: new object[] { "1cf13433-344e-46fd-a9be-1ffda5efda86", "Marek", "Horváth", "AQAAAAIAAYagAAAAEDpWGnQuatHDWjbCXEjJcJ7D8NALMx6de4wdElC8wJu5HBjS9saeYXt7BPoCKCHeGQ==", "+421 944 321 987" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd297"),
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "PasswordHash", "PhoneNumber" },
                values: new object[] { "1f62ba48-e3a3-4a99-b07d-78458a3294e1", "Rihards", "Bērziņš", "AQAAAAIAAYagAAAAEInWZ7oej3i9sHqjJPOpd5mhHIzvUMlbLZEryi2LQ9vbrRUYlbYBjOguQgTYvHHGvA==", "+371 27773311" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd298"),
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "PasswordHash", "PhoneNumber" },
                values: new object[] { "6ea0e2c9-9482-4edb-be3a-2183dd04466d", "Zuzana", "Šimková", "AQAAAAIAAYagAAAAEJ6QBuz7d2qWH+ng80yR4pkaLOw7zKTdY3lRbr1t3vAlaMdBSrbbbfZx1jPiW+ipwg==", "+421 905 888 777" });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd291"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber" },
                values: new object[] { "f1b028a6-4abd-4036-9c6a-fa42c0ab0f0e", "AQAAAAIAAYagAAAAEHrw7lSHrN8wwv6Xvnxly3jQNh2r246myBHXQbDIB5Kd2eNOV1ulrlF78azbVE5FTQ==", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd292"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber" },
                values: new object[] { "8e111885-c455-40d1-bd05-e56a23566c51", "AQAAAAIAAYagAAAAEKDVeSVQ7JsHiasK19GIDrhRlWOk7d/PhA6Ly5TBDC2olsygfBxlSD9GD/iQpY47Nw==", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd293"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber" },
                values: new object[] { "b1c02557-0d3e-4214-9f98-df176df0a1d1", "AQAAAAIAAYagAAAAEHObirwlwIatzScoSQ/DH/1rNyMZxBRdv/p/u54sDu/FlWaDUG8qxT0SEPcAbh7MBw==", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd294"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber" },
                values: new object[] { "a269cdab-4806-4694-a102-482c32d82cfc", "AQAAAAIAAYagAAAAEEYnfsRp6ku533QEIHZSyn6IVVB0Z8vfKW2bH0CxcQC2ifYYwioyvSSk6WQj7xzglA==", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd295"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber" },
                values: new object[] { "df1d6fc8-1bbb-4052-bcbb-cf70c547e103", "AQAAAAIAAYagAAAAEKJ5bDndAM56zn8xz6PVGlG7fMJDOafy90ixApXjyBM8dVPl/cK1AAKz9nEy9bNARw==", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd296"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber" },
                values: new object[] { "d2b908f9-2baf-437e-86d4-7adf23988603", "AQAAAAIAAYagAAAAEDot7t2WOodP2ZwwnnykDdbmSeGzrSHM38rhvzCRDPivhiG6u0YcHFUub6c76pMSAQ==", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd297"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber" },
                values: new object[] { "b75b8323-7d07-447b-825b-8be68eb1985d", "AQAAAAIAAYagAAAAEDIEIywWn7AMrDjWws1rKpBTQetofzoTfXooHCVm+U6nCzrCASxEcvJRzvRWQy+Vzw==", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd298"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber" },
                values: new object[] { "6da25392-74e1-43ca-95f5-8b1a9eaf9d92", "AQAAAAIAAYagAAAAENwfaV2cGY2vKcWla5mXcVZJx6fBuf53NJkcTDzlR2V5QZQWU5KuuPs/bpteqUkjzQ==", null });

            migrationBuilder.UpdateData(
                table: "FoodOrders",
                keyColumn: "Id",
                keyValue: new Guid("41d65c90-de3e-49be-8802-8cbc5b4e2961"),
                column: "OrderDate",
                value: new DateTime(2025, 6, 2, 16, 2, 54, 39, DateTimeKind.Local).AddTicks(6911));

            migrationBuilder.UpdateData(
                table: "FoodOrders",
                keyColumn: "Id",
                keyValue: new Guid("41d65c90-de3e-49be-8802-8cbc5b4e2962"),
                column: "OrderDate",
                value: new DateTime(2025, 6, 2, 16, 2, 54, 39, DateTimeKind.Local).AddTicks(7918));

            migrationBuilder.UpdateData(
                table: "FoodOrders",
                keyColumn: "Id",
                keyValue: new Guid("41d65c90-de3e-49be-8802-8cbc5b4e2963"),
                column: "OrderDate",
                value: new DateTime(2025, 6, 2, 14, 2, 54, 39, DateTimeKind.Local).AddTicks(7934));

            migrationBuilder.UpdateData(
                table: "FoodOrders",
                keyColumn: "Id",
                keyValue: new Guid("41d65c90-de3e-49be-8802-8cbc5b4e2964"),
                column: "OrderDate",
                value: new DateTime(2025, 6, 1, 16, 2, 54, 39, DateTimeKind.Local).AddTicks(7952));

            migrationBuilder.UpdateData(
                table: "FoodOrders",
                keyColumn: "Id",
                keyValue: new Guid("41d65c90-de3e-49be-8802-8cbc5b4e2965"),
                column: "OrderDate",
                value: new DateTime(2025, 6, 2, 16, 2, 54, 39, DateTimeKind.Local).AddTicks(7959));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7291"),
                column: "ReviewDate",
                value: new DateTime(2025, 6, 2, 16, 2, 54, 41, DateTimeKind.Local).AddTicks(2674));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7292"),
                column: "ReviewDate",
                value: new DateTime(2025, 6, 2, 16, 2, 54, 41, DateTimeKind.Local).AddTicks(3141));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7293"),
                column: "ReviewDate",
                value: new DateTime(2025, 6, 2, 16, 2, 54, 41, DateTimeKind.Local).AddTicks(3160));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7294"),
                column: "ReviewDate",
                value: new DateTime(2025, 6, 2, 16, 2, 54, 41, DateTimeKind.Local).AddTicks(3165));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7295"),
                column: "ReviewDate",
                value: new DateTime(2025, 6, 2, 16, 2, 54, 41, DateTimeKind.Local).AddTicks(3170));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7296"),
                column: "ReviewDate",
                value: new DateTime(2025, 6, 2, 16, 2, 54, 41, DateTimeKind.Local).AddTicks(3178));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7297"),
                column: "ReviewDate",
                value: new DateTime(2025, 6, 2, 16, 2, 54, 41, DateTimeKind.Local).AddTicks(3183));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7298"),
                column: "ReviewDate",
                value: new DateTime(2025, 6, 2, 16, 2, 54, 41, DateTimeKind.Local).AddTicks(3187));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7299"),
                column: "ReviewDate",
                value: new DateTime(2025, 6, 2, 16, 2, 54, 41, DateTimeKind.Local).AddTicks(3191));
        }
    }
}
