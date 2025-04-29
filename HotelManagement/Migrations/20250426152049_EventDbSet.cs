using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelManagement.Migrations
{
    /// <inheritdoc />
    public partial class EventDbSet : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EventUsers_Event_EventsId",
                table: "EventUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Event",
                table: "Event");

            migrationBuilder.RenameTable(
                name: "Event",
                newName: "Events");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Events",
                table: "Events",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd291"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "24502bed-7f55-47c5-ab15-a5e0f41a792f", "AQAAAAIAAYagAAAAEIO/JnQ6z8dyAf59CivseIg4RpWKTIeuY6j9nagNQ+2mVy2+UVfLUub4mC6t3muvow==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd292"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4997f021-a2e3-46c1-bd53-d5276ffa5baa", "AQAAAAIAAYagAAAAEFuiUEYHt3oFodcSucgNWU51n4Kdq8A/pN/8AQ0pNH429PCPRUwB8B5o3G4C+DnQmA==" });

            migrationBuilder.UpdateData(
                table: "FoodOrders",
                keyColumn: "Id",
                keyValue: new Guid("41d65c90-de3e-49be-8802-8cbc5b4e2961"),
                column: "OrderDate",
                value: new DateTime(2025, 4, 26, 18, 20, 48, 243, DateTimeKind.Local).AddTicks(1615));

            migrationBuilder.UpdateData(
                table: "FoodOrders",
                keyColumn: "Id",
                keyValue: new Guid("41d65c90-de3e-49be-8802-8cbc5b4e2962"),
                column: "OrderDate",
                value: new DateTime(2025, 4, 26, 18, 20, 48, 245, DateTimeKind.Local).AddTicks(5160));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7291"),
                column: "ReviewDate",
                value: new DateTime(2025, 4, 26, 18, 20, 48, 246, DateTimeKind.Local).AddTicks(4273));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7292"),
                column: "ReviewDate",
                value: new DateTime(2025, 4, 26, 18, 20, 48, 246, DateTimeKind.Local).AddTicks(4764));

            migrationBuilder.AddForeignKey(
                name: "FK_EventUsers_Events_EventsId",
                table: "EventUsers",
                column: "EventsId",
                principalTable: "Events",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EventUsers_Events_EventsId",
                table: "EventUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Events",
                table: "Events");

            migrationBuilder.RenameTable(
                name: "Events",
                newName: "Event");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Event",
                table: "Event",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd291"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c051735f-7ca4-4e32-84fd-86d5c244ebd5", "AQAAAAIAAYagAAAAEPE8Ki2+67YGTlysLFhmmRcRz8MeqUHMPZh1wkBizH1CXjaph/9SV9yTe/hJIBmIKQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd292"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f7c0796b-b3e3-474e-a415-9a93d01f05ad", "AQAAAAIAAYagAAAAEEWcH2pJIpnuW4wQ10x+bGJ1oScVxLoQwY0IYdruL1A/b/pOXM4gv5Ocfv0qzJnG2g==" });

            migrationBuilder.UpdateData(
                table: "FoodOrders",
                keyColumn: "Id",
                keyValue: new Guid("41d65c90-de3e-49be-8802-8cbc5b4e2961"),
                column: "OrderDate",
                value: new DateTime(2025, 4, 15, 20, 49, 31, 193, DateTimeKind.Local).AddTicks(9095));

            migrationBuilder.UpdateData(
                table: "FoodOrders",
                keyColumn: "Id",
                keyValue: new Guid("41d65c90-de3e-49be-8802-8cbc5b4e2962"),
                column: "OrderDate",
                value: new DateTime(2025, 4, 15, 20, 49, 31, 196, DateTimeKind.Local).AddTicks(1615));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7291"),
                column: "ReviewDate",
                value: new DateTime(2025, 4, 15, 20, 49, 31, 197, DateTimeKind.Local).AddTicks(177));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7292"),
                column: "ReviewDate",
                value: new DateTime(2025, 4, 15, 20, 49, 31, 197, DateTimeKind.Local).AddTicks(658));

            migrationBuilder.AddForeignKey(
                name: "FK_EventUsers_Event_EventsId",
                table: "EventUsers",
                column: "EventsId",
                principalTable: "Event",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
