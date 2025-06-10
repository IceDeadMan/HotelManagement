using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelManagement.Migrations
{
    /// <inheritdoc />
    public partial class ExtraSeeds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("a242ae42-b5f3-417e-9277-b89ac16fca21"),
                column: "Description",
                value: "Room includes a king-size bed, a private bathroom, and a balcony with a sea view.");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("a242ae42-b5f3-417e-9277-b89ac16fca22"),
                column: "Description",
                value: "Room includes two twin beds, a private bathroom, and a city view.");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("a242ae42-b5f3-417e-9277-b89ac16fca23"),
                column: "Description",
                value: "Room includes a queen-size bed, a private bathroom, and a garden view.");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("a242ae42-b5f3-417e-9277-b89ac16fca24"),
                column: "Description",
                value: "Room includes a living area, and a private bathroom.");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("a242ae42-b5f3-417e-9277-b89ac16fca25"),
                column: "Description",
                value: "Room includes a king-size bed, a private bathroom, and a balcony with a mountain view.");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("a242ae42-b5f3-417e-9277-b89ac16fca26"),
                column: "Description",
                value: "Room includes two twin beds, a private bathroom, and a city view.");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("a242ae42-b5f3-417e-9277-b89ac16fca27"),
                column: "Description",
                value: "Room includes a queen-size bed, a private bathroom, and a garden view.");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("a242ae42-b5f3-417e-9277-b89ac16fca28"),
                column: "Description",
                value: "Room includes a living area, and a private bathroom.");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("a242ae42-b5f3-417e-9277-b89ac16fca29"),
                column: "Description",
                value: "Room with a premium view.");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("a242ae42-b5f3-417e-9277-b89ac16fca30"),
                column: "Description",
                value: "Room with a city view.");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("a242ae42-b5f3-417e-9277-b89ac16fca31"),
                column: "Description",
                value: "Room with a garden view.");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("a242ae42-b5f3-417e-9277-b89ac16fca32"),
                column: "Description",
                value: "Room ont the top floor with a panoramic view.");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("a242ae42-b5f3-417e-9277-b89ac16fca33"),
                column: "Description",
                value: "Room with a spacious layout and modern amenities.");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd291"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "87517e09-9213-40f0-b02c-e7d19d264764", "AQAAAAIAAYagAAAAEJg8ih/Y1UehctA/5MYNvd1E06bgpb8XhnYhVQi2bUeIMB/ybHQdvKVerG+gX6Jgtg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd292"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5bb7d798-244d-46b9-92df-c181724c8c43", "AQAAAAIAAYagAAAAEKzgptzoo7j0yDqVmjrA3hkZMYRKLj+ve6di81kkGr7YGoyFY+wSu89q4fJTY8anIw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd293"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "dfb2635a-6474-4db3-8f92-be7ceeea33bc", "AQAAAAIAAYagAAAAENCqCJvoXdkZVGVi7EpD7goqrDVUDvuD+6Kyeq2GVJn0xYCne/NpkkewbRgOEwMYUw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd294"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2a0218c5-3495-4801-aacd-4b587fbb4c33", "AQAAAAIAAYagAAAAEDzU5UBkrg808lN+aqLpl+2W5HEJF0ohl2JOS2PN9zZORXZxNn5PC+Z5NhxcIcVyew==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd295"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1c55aebf-98cf-40c0-8809-4441865f7328", "AQAAAAIAAYagAAAAEJPyH9YX2CWikuEu+GMR6sxuqd7fk6M+w6TWcjnR659S2SN4FCwMxIdhuymsAtUoMw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd296"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d57d47e0-6e1b-4ee6-84b7-cfd28ebba3a7", "AQAAAAIAAYagAAAAEJFE/S5rBFeCoT3TUefr2tIJR5MFBOpPbB6mPYxn85WcMGVwBU2WTDNRE8R5wCVRqg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd297"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "15d79248-b634-491c-b19a-9559198957bb", "AQAAAAIAAYagAAAAEHAcSZ2lsw4nVqP/yFkObAhZYWhiCJ6knJfCLcFsicmTONeWhxYnr+7umUamPUexcQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd298"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "dbb8bc69-25e2-497b-af76-c424621f91d6", "AQAAAAIAAYagAAAAELskLCaNk6aEKQfS1fk8gX0oHHhuBYZBU3A7ZAiZJhQVcLsx3Iwv7niX0eu+80qzJw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd299"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2c27bccd-2b4b-4a7f-9276-939d47c4604f", "AQAAAAIAAYagAAAAELmXUzhJkcgRBqFsn158sTH27nQuyut+Mongc45RXtNBKF+7O7F0fDX2l9FtZx+yAw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd29a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f2987886-3571-41df-a13b-90749952132c", "AQAAAAIAAYagAAAAED2n1BLSw7os4GfhDNApzGZ3KIp0aQce0HaYs4ONIJenmrWEW7hSXTqM9njlQA+ARw==" });

            migrationBuilder.UpdateData(
                table: "FoodOrders",
                keyColumn: "Id",
                keyValue: new Guid("41d65c90-de3e-49be-8802-8cbc5b4e2961"),
                column: "OrderDate",
                value: new DateTime(2025, 6, 9, 18, 27, 15, 886, DateTimeKind.Local).AddTicks(1803));

            migrationBuilder.UpdateData(
                table: "FoodOrders",
                keyColumn: "Id",
                keyValue: new Guid("41d65c90-de3e-49be-8802-8cbc5b4e2962"),
                column: "OrderDate",
                value: new DateTime(2025, 6, 9, 18, 27, 15, 886, DateTimeKind.Local).AddTicks(2815));

            migrationBuilder.UpdateData(
                table: "FoodOrders",
                keyColumn: "Id",
                keyValue: new Guid("41d65c90-de3e-49be-8802-8cbc5b4e2963"),
                column: "OrderDate",
                value: new DateTime(2025, 6, 9, 16, 27, 15, 886, DateTimeKind.Local).AddTicks(2835));

            migrationBuilder.UpdateData(
                table: "FoodOrders",
                keyColumn: "Id",
                keyValue: new Guid("41d65c90-de3e-49be-8802-8cbc5b4e2964"),
                column: "OrderDate",
                value: new DateTime(2025, 6, 8, 18, 27, 15, 886, DateTimeKind.Local).AddTicks(2859));

            migrationBuilder.UpdateData(
                table: "FoodOrders",
                keyColumn: "Id",
                keyValue: new Guid("41d65c90-de3e-49be-8802-8cbc5b4e2965"),
                column: "OrderDate",
                value: new DateTime(2025, 6, 9, 18, 27, 15, 886, DateTimeKind.Local).AddTicks(2867));

            migrationBuilder.UpdateData(
                table: "FoodOrders",
                keyColumn: "Id",
                keyValue: new Guid("41d65c90-de3e-49be-8802-8cbc5b4e2966"),
                column: "OrderDate",
                value: new DateTime(2025, 6, 6, 18, 27, 15, 886, DateTimeKind.Local).AddTicks(2872));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7291"),
                column: "ReviewDate",
                value: new DateTime(2025, 6, 9, 18, 27, 15, 887, DateTimeKind.Local).AddTicks(8110));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7292"),
                column: "ReviewDate",
                value: new DateTime(2025, 6, 9, 18, 27, 15, 887, DateTimeKind.Local).AddTicks(8569));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7293"),
                column: "ReviewDate",
                value: new DateTime(2025, 6, 9, 18, 27, 15, 887, DateTimeKind.Local).AddTicks(8592));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7294"),
                column: "ReviewDate",
                value: new DateTime(2025, 6, 9, 18, 27, 15, 887, DateTimeKind.Local).AddTicks(8599));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7295"),
                column: "ReviewDate",
                value: new DateTime(2025, 6, 9, 18, 27, 15, 887, DateTimeKind.Local).AddTicks(8612));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7296"),
                column: "ReviewDate",
                value: new DateTime(2025, 6, 9, 18, 27, 15, 887, DateTimeKind.Local).AddTicks(8617));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7297"),
                column: "ReviewDate",
                value: new DateTime(2025, 6, 9, 18, 27, 15, 887, DateTimeKind.Local).AddTicks(8622));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7298"),
                column: "ReviewDate",
                value: new DateTime(2025, 6, 9, 18, 27, 15, 887, DateTimeKind.Local).AddTicks(8627));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7299"),
                column: "ReviewDate",
                value: new DateTime(2025, 6, 9, 18, 27, 15, 887, DateTimeKind.Local).AddTicks(8632));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("a242ae42-b5f3-417e-9277-b89ac16fca21"),
                column: "Description",
                value: "Room 101");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("a242ae42-b5f3-417e-9277-b89ac16fca22"),
                column: "Description",
                value: "Room 102");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("a242ae42-b5f3-417e-9277-b89ac16fca23"),
                column: "Description",
                value: "Room 103");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("a242ae42-b5f3-417e-9277-b89ac16fca24"),
                column: "Description",
                value: "Room 104");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("a242ae42-b5f3-417e-9277-b89ac16fca25"),
                column: "Description",
                value: "Room 105");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("a242ae42-b5f3-417e-9277-b89ac16fca26"),
                column: "Description",
                value: "Room 106");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("a242ae42-b5f3-417e-9277-b89ac16fca27"),
                column: "Description",
                value: "Room 107");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("a242ae42-b5f3-417e-9277-b89ac16fca28"),
                column: "Description",
                value: "Room 108");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("a242ae42-b5f3-417e-9277-b89ac16fca29"),
                column: "Description",
                value: "Room 109");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("a242ae42-b5f3-417e-9277-b89ac16fca30"),
                column: "Description",
                value: "Room 110");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("a242ae42-b5f3-417e-9277-b89ac16fca31"),
                column: "Description",
                value: "Room 111");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("a242ae42-b5f3-417e-9277-b89ac16fca32"),
                column: "Description",
                value: "Room 112");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("a242ae42-b5f3-417e-9277-b89ac16fca33"),
                column: "Description",
                value: "Room 113");
        }
    }
}
