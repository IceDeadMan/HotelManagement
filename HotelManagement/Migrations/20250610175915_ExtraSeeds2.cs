using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelManagement.Migrations
{
    /// <inheritdoc />
    public partial class ExtraSeeds2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd291"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "431a77ee-c128-4148-ba35-0e6c146e0b61", "AQAAAAIAAYagAAAAEN/NUGaYBYVG8i/HZV2O3dyPnC/qN5hZxWev6mT20GU6C+gYt4jNrO5fjMY/cdU7XA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd292"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ab2e5306-f422-4dad-bacf-d56f2ea2866f", "AQAAAAIAAYagAAAAEI4Dk06LmQQ24QzWAjG0NVaRQ7yZkAf4EBcUYwWQG0+Sdo4US4Ma82KXtdsnh4uxjA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd293"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "02c0a475-7990-4d99-b25e-6d450d04f531", "AQAAAAIAAYagAAAAEIuEPvYgJsmpP6b0fRx/kLe2V0G3w9S3WYC+YhDVhWqw7WrKqBYdAJgPXnahpgxKxw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd294"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5a6f2c1f-17a8-4098-833f-20ff9181e2c4", "AQAAAAIAAYagAAAAEObQyaARxLe2isAV7xZi9qhT6U0pjKPDONYi7OjCAlYrgdu34pe4DazV+OpiwPWt4w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd295"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8b02a281-f2e5-4052-aca7-88c4f06f90d0", "AQAAAAIAAYagAAAAEEX+YvlxseL0gWQiEAPTcI4GOf4LsKD2U+St4PT0PlT97Hv5drDUJSXfBm8LE8mk8Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd296"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5528f1d3-aac4-4627-8837-a3d70cbc3f6b", "AQAAAAIAAYagAAAAELjifgmwlpAb8md4pg9T1rqDt7UgJdxvVzMXIRYYZUNHfmwOlysN/KyvzEvpsue6YA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd297"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "339fc0b9-be25-4f69-acc3-e3c6292981b6", "AQAAAAIAAYagAAAAEGpjzIvoEuHRatGSIYYcQSSMapiWKPFipIdsEhAWZ/p9J+EV0w3NXA3cC770pGTE3w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd298"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e0b45796-e62d-4798-8b8c-01f8427ed6aa", "AQAAAAIAAYagAAAAEMKvJDUscP2fyTb9DEYTOOVkNchtButHLIC4uO4PrpXfD3oh0RgcWm8ySYTrrLZUtQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd299"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a854adb8-d15a-44b0-8620-1571172e53e0", "AQAAAAIAAYagAAAAEGO4dn1TaEdpVNnjaDfI/K/+/P4NXxepwE/gi/cjtyUlelO6a25fomi9ii0CAOsteA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd29a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b1db54f1-7e10-4a62-ab3c-b4f83c100295", "AQAAAAIAAYagAAAAEGFhz2/6u4RNVLAjNlmvGEeyejRVT738gIxpEL+u3534PZ/HmfXwl3MQPSO6AAy3qw==" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: new Guid("371c096d-5c0b-4929-aab5-1c0289611901"),
                column: "Status",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("5a6da81a-74a0-4d50-8cac-fea2f7897731"),
                columns: new[] { "Capacity", "Date" },
                values: new object[] { 100, new DateTime(2025, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("6b7da81a-74a0-4d50-8cac-fea2f7897732"),
                columns: new[] { "Capacity", "Date" },
                values: new object[] { 50, new DateTime(2025, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("7c8da81a-74a0-4d50-8cac-fea2f7897733"),
                column: "Capacity",
                value: 30);

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("8d9da81a-74a0-4d50-8cac-fea2f7897734"),
                column: "Capacity",
                value: 200);

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("9e0da81a-74a0-4d50-8cac-fea2f7897735"),
                column: "Capacity",
                value: 5);

            migrationBuilder.UpdateData(
                table: "FoodOrders",
                keyColumn: "Id",
                keyValue: new Guid("41d65c90-de3e-49be-8802-8cbc5b4e2961"),
                column: "OrderDate",
                value: new DateTime(2025, 6, 10, 20, 59, 14, 227, DateTimeKind.Local).AddTicks(8794));

            migrationBuilder.UpdateData(
                table: "FoodOrders",
                keyColumn: "Id",
                keyValue: new Guid("41d65c90-de3e-49be-8802-8cbc5b4e2962"),
                column: "OrderDate",
                value: new DateTime(2025, 6, 10, 20, 59, 14, 227, DateTimeKind.Local).AddTicks(9486));

            migrationBuilder.UpdateData(
                table: "FoodOrders",
                keyColumn: "Id",
                keyValue: new Guid("41d65c90-de3e-49be-8802-8cbc5b4e2963"),
                column: "OrderDate",
                value: new DateTime(2025, 6, 10, 18, 59, 14, 227, DateTimeKind.Local).AddTicks(9498));

            migrationBuilder.UpdateData(
                table: "FoodOrders",
                keyColumn: "Id",
                keyValue: new Guid("41d65c90-de3e-49be-8802-8cbc5b4e2964"),
                column: "OrderDate",
                value: new DateTime(2025, 6, 9, 20, 59, 14, 227, DateTimeKind.Local).AddTicks(9526));

            migrationBuilder.UpdateData(
                table: "FoodOrders",
                keyColumn: "Id",
                keyValue: new Guid("41d65c90-de3e-49be-8802-8cbc5b4e2965"),
                column: "OrderDate",
                value: new DateTime(2025, 6, 10, 20, 59, 14, 227, DateTimeKind.Local).AddTicks(9533));

            migrationBuilder.UpdateData(
                table: "FoodOrders",
                keyColumn: "Id",
                keyValue: new Guid("41d65c90-de3e-49be-8802-8cbc5b4e2966"),
                column: "OrderDate",
                value: new DateTime(2025, 6, 7, 20, 59, 14, 227, DateTimeKind.Local).AddTicks(9537));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7291"),
                column: "ReviewDate",
                value: new DateTime(2025, 6, 10, 20, 59, 14, 229, DateTimeKind.Local).AddTicks(3388));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7292"),
                column: "ReviewDate",
                value: new DateTime(2025, 6, 10, 20, 59, 14, 229, DateTimeKind.Local).AddTicks(3742));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7293"),
                column: "ReviewDate",
                value: new DateTime(2025, 6, 10, 20, 59, 14, 229, DateTimeKind.Local).AddTicks(3754));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7294"),
                column: "ReviewDate",
                value: new DateTime(2025, 6, 10, 20, 59, 14, 229, DateTimeKind.Local).AddTicks(3763));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7295"),
                column: "ReviewDate",
                value: new DateTime(2025, 6, 10, 20, 59, 14, 229, DateTimeKind.Local).AddTicks(3769));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7296"),
                column: "ReviewDate",
                value: new DateTime(2025, 6, 10, 20, 59, 14, 229, DateTimeKind.Local).AddTicks(3773));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7297"),
                column: "ReviewDate",
                value: new DateTime(2025, 6, 10, 20, 59, 14, 229, DateTimeKind.Local).AddTicks(3777));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7298"),
                column: "ReviewDate",
                value: new DateTime(2025, 6, 10, 20, 59, 14, 229, DateTimeKind.Local).AddTicks(3782));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7299"),
                column: "ReviewDate",
                value: new DateTime(2025, 6, 10, 20, 59, 14, 229, DateTimeKind.Local).AddTicks(3786));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd291"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "061f9779-3cda-4778-b6b8-574727fe807f", "AQAAAAIAAYagAAAAEJtv2FFqNTQHHB4OrhH8fAvcGhHwA2ofwOXbagl5XRGFYzz4s4PrrV2C2MauTNFVfw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd292"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6ea6b34c-1165-4a5c-b837-ad2a26b5cc7e", "AQAAAAIAAYagAAAAEKT1Jp+NE7t3Nrulm/qR4cOsM/CojB4HB8PHq5/PrxMaVxG6jmt1Hf67aQGOdBKa9w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd293"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a2483e9d-590f-476f-892b-414fd12c0470", "AQAAAAIAAYagAAAAEJj0NQyFz92Sd7SMMUvkZAufOyWrEk0cQvHlcUsh/B0gwLbz4xvrc0dLvLJbfSj3Cg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd294"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f0094887-5f4b-421c-8eb9-9d90530ecc7a", "AQAAAAIAAYagAAAAEI5KTQSfo8ZbRtuEvuGH+SKdGCd2OO+mhV9oxt1ZfyJoy+Ghp7JByobN8Ik7uzrq/w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd295"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d8dd2858-ecbf-4782-9592-d31a26a9f2e0", "AQAAAAIAAYagAAAAEJzMfqy6h4Y3URpG7qTuDr6VqnuX3uHKoG+Z6rr83Eejo1nBuKOWrz2zENigXWEOsg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd296"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "35398631-9ff7-4d90-bb09-aeb3113ab36a", "AQAAAAIAAYagAAAAEO9VfDk+vZBcUqlppkcYZRKIus1Z2p1QZXknaVvfNZ8kviU3umNV5XbPzOyg9n4+Qg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd297"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ff6d62dd-a816-47cd-9cc3-d4934d43f3fd", "AQAAAAIAAYagAAAAEJSvJXwtAdvM/jgs4b7K5xbVUGZ14nebTnQyECt2h5SKFoOPakG+rtXuPT736V4wYA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd298"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e7c3db92-5795-4188-8e4a-5b8ae5ebbe78", "AQAAAAIAAYagAAAAEDoX4mK7XgLvWsxn1A7+iMCm+DhG96NMNkLhBjzuCKQcwTmueS38y5b6zJK0ZqTsDw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd299"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5afe1f0a-5430-482a-b5d2-33ddc5952bf9", "AQAAAAIAAYagAAAAEDnNE3uZxMavoBXMx5DsKSm3Dtu/kpnuqs3Qs0aG92zJgC2klQn9QL3/pYhm+cYtjw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd29a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "db44c667-50f8-4f76-b6ac-0866b7187609", "AQAAAAIAAYagAAAAEC2gTiFYyp1dx9EIWT/F9LkErMRC1+pXC5GnsNgw9LRaFZ/vdcV33FAWnYyiAeW6/g==" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: new Guid("371c096d-5c0b-4929-aab5-1c0289611901"),
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("5a6da81a-74a0-4d50-8cac-fea2f7897731"),
                columns: new[] { "Capacity", "Date" },
                values: new object[] { 0, new DateTime(2023, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("6b7da81a-74a0-4d50-8cac-fea2f7897732"),
                columns: new[] { "Capacity", "Date" },
                values: new object[] { 0, new DateTime(2023, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("7c8da81a-74a0-4d50-8cac-fea2f7897733"),
                column: "Capacity",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("8d9da81a-74a0-4d50-8cac-fea2f7897734"),
                column: "Capacity",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("9e0da81a-74a0-4d50-8cac-fea2f7897735"),
                column: "Capacity",
                value: 0);

            migrationBuilder.UpdateData(
                table: "FoodOrders",
                keyColumn: "Id",
                keyValue: new Guid("41d65c90-de3e-49be-8802-8cbc5b4e2961"),
                column: "OrderDate",
                value: new DateTime(2025, 6, 10, 12, 37, 43, 505, DateTimeKind.Local).AddTicks(9339));

            migrationBuilder.UpdateData(
                table: "FoodOrders",
                keyColumn: "Id",
                keyValue: new Guid("41d65c90-de3e-49be-8802-8cbc5b4e2962"),
                column: "OrderDate",
                value: new DateTime(2025, 6, 10, 12, 37, 43, 506, DateTimeKind.Local).AddTicks(43));

            migrationBuilder.UpdateData(
                table: "FoodOrders",
                keyColumn: "Id",
                keyValue: new Guid("41d65c90-de3e-49be-8802-8cbc5b4e2963"),
                column: "OrderDate",
                value: new DateTime(2025, 6, 10, 10, 37, 43, 506, DateTimeKind.Local).AddTicks(54));

            migrationBuilder.UpdateData(
                table: "FoodOrders",
                keyColumn: "Id",
                keyValue: new Guid("41d65c90-de3e-49be-8802-8cbc5b4e2964"),
                column: "OrderDate",
                value: new DateTime(2025, 6, 9, 12, 37, 43, 506, DateTimeKind.Local).AddTicks(81));

            migrationBuilder.UpdateData(
                table: "FoodOrders",
                keyColumn: "Id",
                keyValue: new Guid("41d65c90-de3e-49be-8802-8cbc5b4e2965"),
                column: "OrderDate",
                value: new DateTime(2025, 6, 10, 12, 37, 43, 506, DateTimeKind.Local).AddTicks(89));

            migrationBuilder.UpdateData(
                table: "FoodOrders",
                keyColumn: "Id",
                keyValue: new Guid("41d65c90-de3e-49be-8802-8cbc5b4e2966"),
                column: "OrderDate",
                value: new DateTime(2025, 6, 7, 12, 37, 43, 506, DateTimeKind.Local).AddTicks(94));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7291"),
                column: "ReviewDate",
                value: new DateTime(2025, 6, 10, 12, 37, 43, 507, DateTimeKind.Local).AddTicks(4044));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7292"),
                column: "ReviewDate",
                value: new DateTime(2025, 6, 10, 12, 37, 43, 507, DateTimeKind.Local).AddTicks(4397));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7293"),
                column: "ReviewDate",
                value: new DateTime(2025, 6, 10, 12, 37, 43, 507, DateTimeKind.Local).AddTicks(4408));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7294"),
                column: "ReviewDate",
                value: new DateTime(2025, 6, 10, 12, 37, 43, 507, DateTimeKind.Local).AddTicks(4412));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7295"),
                column: "ReviewDate",
                value: new DateTime(2025, 6, 10, 12, 37, 43, 507, DateTimeKind.Local).AddTicks(4422));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7296"),
                column: "ReviewDate",
                value: new DateTime(2025, 6, 10, 12, 37, 43, 507, DateTimeKind.Local).AddTicks(4427));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7297"),
                column: "ReviewDate",
                value: new DateTime(2025, 6, 10, 12, 37, 43, 507, DateTimeKind.Local).AddTicks(4431));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7298"),
                column: "ReviewDate",
                value: new DateTime(2025, 6, 10, 12, 37, 43, 507, DateTimeKind.Local).AddTicks(4435));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7299"),
                column: "ReviewDate",
                value: new DateTime(2025, 6, 10, 12, 37, 43, 507, DateTimeKind.Local).AddTicks(4439));
        }
    }
}
