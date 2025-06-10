using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelManagement.Migrations
{
    /// <inheritdoc />
    public partial class CascadeDeleteOnJoinTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd299"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "99c63e66-9fe6-4343-8e4c-cc5994ab4cca", "AQAAAAIAAYagAAAAEDFhbyBLNcN1m34UxV8/vWhC/TDriHp99Q2KBD9B4udAMSSiZxIzvX3RlTxkKApn4A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd29a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f3a82077-e198-4ab0-9415-072d3bb627c7", "AQAAAAIAAYagAAAAEK7U3xuC786n0pgdsNmoUkKPDNxzL6BbAaTBCbdUdV9xYnnxFcOtv0XsXcovwkBBrQ==" });

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

            migrationBuilder.UpdateData(
                table: "FoodOrders",
                keyColumn: "Id",
                keyValue: new Guid("41d65c90-de3e-49be-8802-8cbc5b4e2966"),
                column: "OrderDate",
                value: new DateTime(2025, 6, 4, 20, 4, 18, 960, DateTimeKind.Local).AddTicks(1162));

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
        }
    }
}
