using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HotelManagement.Migrations
{
    /// <inheritdoc />
    public partial class EventUserChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EventUsers");

            migrationBuilder.CreateTable(
                name: "EventRegistrations",
                columns: table => new
                {
                    EventId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NumberOfParticipants = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventRegistrations", x => new { x.EventId, x.UserId });
                    table.ForeignKey(
                        name: "FK_EventRegistrations_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EventRegistrations_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EventStaff",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EventId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventStaff", x => new { x.UserId, x.EventId });
                    table.ForeignKey(
                        name: "FK_EventStaff_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EventStaff_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd291"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "569d1a32-de16-4293-a452-fb60b816815d", "AQAAAAIAAYagAAAAEP0QiyH9JBXej3u83fDfzSp8RNEZqfp7eZ/8cx2wK3Y21+652RgPok8fa8bBDKnsKw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd292"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4c7e7f5a-086e-4b34-888f-53f3a2eadd74", "AQAAAAIAAYagAAAAEJw7u8cjgjFDDP77FHeped92PxwFBXxmlsRwKQHTqmR3GjkGNHcZ305SQnqIOiWpxg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd293"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4fed3557-4906-4410-b9fd-d297ec5f990e", "AQAAAAIAAYagAAAAEJRyq+UmQeSAZkQmGMxt8ot6rWf/W2aRVsZlC5gqmwwyRGqkA2WJpZwT2IS8pGWeew==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd294"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a23083a2-20fc-4b36-afaa-699e8cc3b633", "AQAAAAIAAYagAAAAEFUnDtO2ukKrkS80A/6JRgcBp9N6/W7Vy0QqLpDOJGo4xiST0felfMupGdb56LzDFg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd295"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2630790d-898a-4fe5-a36f-3e36650073d2", "AQAAAAIAAYagAAAAEOW/VfzsqpwQHFlHJrCf3XHCWcWtqSf4VGJo/vMCLpopYSHYexecWXcBshjOqDOmMw==" });

            migrationBuilder.InsertData(
                table: "EventRegistrations",
                columns: new[] { "EventId", "UserId", "NumberOfParticipants" },
                values: new object[] { new Guid("5a6da81a-74a0-4d50-8cac-fea2f7897731"), new Guid("67019a3d-04de-444b-bb6c-6ef934dcd291"), 2 });

            migrationBuilder.InsertData(
                table: "EventStaff",
                columns: new[] { "EventId", "UserId" },
                values: new object[] { new Guid("5a6da81a-74a0-4d50-8cac-fea2f7897731"), new Guid("67019a3d-04de-444b-bb6c-6ef934dcd293") });

            migrationBuilder.UpdateData(
                table: "FoodOrders",
                keyColumn: "Id",
                keyValue: new Guid("41d65c90-de3e-49be-8802-8cbc5b4e2961"),
                column: "OrderDate",
                value: new DateTime(2025, 5, 30, 14, 1, 15, 781, DateTimeKind.Local).AddTicks(8648));

            migrationBuilder.UpdateData(
                table: "FoodOrders",
                keyColumn: "Id",
                keyValue: new Guid("41d65c90-de3e-49be-8802-8cbc5b4e2962"),
                column: "OrderDate",
                value: new DateTime(2025, 5, 30, 14, 1, 15, 784, DateTimeKind.Local).AddTicks(1735));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7291"),
                column: "ReviewDate",
                value: new DateTime(2025, 5, 30, 14, 1, 15, 785, DateTimeKind.Local).AddTicks(3573));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7292"),
                column: "ReviewDate",
                value: new DateTime(2025, 5, 30, 14, 1, 15, 785, DateTimeKind.Local).AddTicks(4078));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7293"),
                column: "ReviewDate",
                value: new DateTime(2025, 5, 30, 14, 1, 15, 785, DateTimeKind.Local).AddTicks(4096));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7294"),
                column: "ReviewDate",
                value: new DateTime(2025, 5, 30, 14, 1, 15, 785, DateTimeKind.Local).AddTicks(4100));

            migrationBuilder.CreateIndex(
                name: "IX_EventRegistrations_UserId",
                table: "EventRegistrations",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_EventStaff_EventId",
                table: "EventStaff",
                column: "EventId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EventRegistrations");

            migrationBuilder.DropTable(
                name: "EventStaff");

            migrationBuilder.CreateTable(
                name: "EventUsers",
                columns: table => new
                {
                    UsersId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EventsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventUsers", x => new { x.UsersId, x.EventsId });
                    table.ForeignKey(
                        name: "FK_EventUsers_AspNetUsers_UsersId",
                        column: x => x.UsersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EventUsers_Events_EventsId",
                        column: x => x.EventsId,
                        principalTable: "Events",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd294"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3f0b9396-2ea4-4154-b615-33d21759bade", "AQAAAAIAAYagAAAAEB68YtMVL9DKCRl81XPGlulMgUx46uBj7qHk76fh9jch9mMXGTwWMeV1oWZ9hDtyow==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd295"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a16b5374-9ddc-47e9-b036-225c099ba221", "AQAAAAIAAYagAAAAEBSH29Dqvls/QU47+xSW/ayjvnaYTIz0d7ul55rOq3I5cCYtRohC8OturggMLpCh0A==" });

            migrationBuilder.InsertData(
                table: "EventUsers",
                columns: new[] { "EventsId", "UsersId" },
                values: new object[,]
                {
                    { new Guid("5a6da81a-74a0-4d50-8cac-fea2f7897731"), new Guid("67019a3d-04de-444b-bb6c-6ef934dcd291") },
                    { new Guid("5a6da81a-74a0-4d50-8cac-fea2f7897731"), new Guid("67019a3d-04de-444b-bb6c-6ef934dcd292") }
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

            migrationBuilder.CreateIndex(
                name: "IX_EventUsers_EventsId",
                table: "EventUsers",
                column: "EventsId");
        }
    }
}
