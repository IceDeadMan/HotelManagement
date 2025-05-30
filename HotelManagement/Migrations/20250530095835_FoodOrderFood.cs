using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelManagement.Migrations
{
    /// <inheritdoc />
    public partial class FoodOrderFood : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FoodOrderFoods_FoodOrders_FoodOrdersId",
                table: "FoodOrderFoods");

            migrationBuilder.DropForeignKey(
                name: "FK_FoodOrderFoods_Foods_FoodsId",
                table: "FoodOrderFoods");

            migrationBuilder.RenameColumn(
                name: "FoodOrdersId",
                table: "FoodOrderFoods",
                newName: "FoodOrderId");

            migrationBuilder.RenameColumn(
                name: "FoodsId",
                table: "FoodOrderFoods",
                newName: "FoodId");

            migrationBuilder.RenameIndex(
                name: "IX_FoodOrderFoods_FoodOrdersId",
                table: "FoodOrderFoods",
                newName: "IX_FoodOrderFoods_FoodOrderId");

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "FoodOrderFoods",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd291"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3ab96b3e-5da7-431b-ab20-90683e572f8a", "AQAAAAIAAYagAAAAECY8Yx1Vu7sbmDsYX8YpB+2MMpM08ME3d0FA5xR2RrFh2Rx5awe7haANoglQ3+Juow==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd292"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d2c766e4-a087-42a3-b535-eb54a50cb14e", "AQAAAAIAAYagAAAAEPme093W6wxeNRcd6HnafAjZxMxc3h6JGe5d9uqkYIbzBb0n+6ifR54sQxcIs91kPQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd293"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3c8ae24b-12fe-4737-8adb-f26f4c780466", "AQAAAAIAAYagAAAAEGmrwC8MFKhWbKpxnyxgXZtwZS21tWBH2BDl7up8OXJiLwc/3eYUsoJKQ3QRDaBV5Q==" });

            migrationBuilder.UpdateData(
                table: "FoodOrderFoods",
                keyColumns: new[] { "FoodId", "FoodOrderId" },
                keyValues: new object[] { new Guid("a9063d88-88c6-40db-a7e9-868afeb45811"), new Guid("41d65c90-de3e-49be-8802-8cbc5b4e2961") },
                column: "Quantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "FoodOrderFoods",
                keyColumns: new[] { "FoodId", "FoodOrderId" },
                keyValues: new object[] { new Guid("a9063d88-88c6-40db-a7e9-868afeb45812"), new Guid("41d65c90-de3e-49be-8802-8cbc5b4e2961") },
                column: "Quantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "FoodOrderFoods",
                keyColumns: new[] { "FoodId", "FoodOrderId" },
                keyValues: new object[] { new Guid("a9063d88-88c6-40db-a7e9-868afeb45813"), new Guid("41d65c90-de3e-49be-8802-8cbc5b4e2962") },
                column: "Quantity",
                value: 3);

            migrationBuilder.UpdateData(
                table: "FoodOrders",
                keyColumn: "Id",
                keyValue: new Guid("41d65c90-de3e-49be-8802-8cbc5b4e2961"),
                column: "OrderDate",
                value: new DateTime(2025, 5, 30, 12, 58, 34, 763, DateTimeKind.Local).AddTicks(2654));

            migrationBuilder.UpdateData(
                table: "FoodOrders",
                keyColumn: "Id",
                keyValue: new Guid("41d65c90-de3e-49be-8802-8cbc5b4e2962"),
                column: "OrderDate",
                value: new DateTime(2025, 5, 30, 12, 58, 34, 765, DateTimeKind.Local).AddTicks(5451));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7291"),
                column: "ReviewDate",
                value: new DateTime(2025, 5, 30, 12, 58, 34, 766, DateTimeKind.Local).AddTicks(6916));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7292"),
                column: "ReviewDate",
                value: new DateTime(2025, 5, 30, 12, 58, 34, 766, DateTimeKind.Local).AddTicks(7385));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7293"),
                column: "ReviewDate",
                value: new DateTime(2025, 5, 30, 12, 58, 34, 766, DateTimeKind.Local).AddTicks(7401));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7294"),
                column: "ReviewDate",
                value: new DateTime(2025, 5, 30, 12, 58, 34, 766, DateTimeKind.Local).AddTicks(7412));

            migrationBuilder.AddForeignKey(
                name: "FK_FoodOrderFoods_FoodOrders_FoodOrderId",
                table: "FoodOrderFoods",
                column: "FoodOrderId",
                principalTable: "FoodOrders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FoodOrderFoods_Foods_FoodId",
                table: "FoodOrderFoods",
                column: "FoodId",
                principalTable: "Foods",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FoodOrderFoods_FoodOrders_FoodOrderId",
                table: "FoodOrderFoods");

            migrationBuilder.DropForeignKey(
                name: "FK_FoodOrderFoods_Foods_FoodId",
                table: "FoodOrderFoods");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "FoodOrderFoods");

            migrationBuilder.RenameColumn(
                name: "FoodOrderId",
                table: "FoodOrderFoods",
                newName: "FoodOrdersId");

            migrationBuilder.RenameColumn(
                name: "FoodId",
                table: "FoodOrderFoods",
                newName: "FoodsId");

            migrationBuilder.RenameIndex(
                name: "IX_FoodOrderFoods_FoodOrderId",
                table: "FoodOrderFoods",
                newName: "IX_FoodOrderFoods_FoodOrdersId");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd291"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a89e3cd4-6b35-47fd-8619-2ccda2f63bc3", "AQAAAAIAAYagAAAAENot6gCpWS4SwF+LYO7NKU3VB3fmob4Obsj4PB/fd7zNUBI4dMdpi5T9m7hAwepWFA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd292"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a1521484-b926-4e30-ba04-8ee1f1d5576d", "AQAAAAIAAYagAAAAEJHBAVx3LWKdurTdMOl0MfNDC3YUv7pOYUM8uNjlp3Qpdbt65Tuc08Bbxg6TGMeRkg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd293"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e016b9a2-c649-412d-ac4c-f3370ca26db7", "AQAAAAIAAYagAAAAEE0RuWU/Pk0nbvUcZkVTLnpEPILmxCXAad/THeTBMHFos8L3Ugre9UtCHDSH2+qmeg==" });

            migrationBuilder.UpdateData(
                table: "FoodOrders",
                keyColumn: "Id",
                keyValue: new Guid("41d65c90-de3e-49be-8802-8cbc5b4e2961"),
                column: "OrderDate",
                value: new DateTime(2025, 5, 6, 16, 50, 30, 191, DateTimeKind.Local).AddTicks(8422));

            migrationBuilder.UpdateData(
                table: "FoodOrders",
                keyColumn: "Id",
                keyValue: new Guid("41d65c90-de3e-49be-8802-8cbc5b4e2962"),
                column: "OrderDate",
                value: new DateTime(2025, 5, 6, 16, 50, 30, 194, DateTimeKind.Local).AddTicks(3667));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7291"),
                column: "ReviewDate",
                value: new DateTime(2025, 5, 6, 16, 50, 30, 195, DateTimeKind.Local).AddTicks(5372));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7292"),
                column: "ReviewDate",
                value: new DateTime(2025, 5, 6, 16, 50, 30, 195, DateTimeKind.Local).AddTicks(5857));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7293"),
                column: "ReviewDate",
                value: new DateTime(2025, 5, 6, 16, 50, 30, 195, DateTimeKind.Local).AddTicks(5875));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4aef3307-19ee-4b61-8efa-8828279e7294"),
                column: "ReviewDate",
                value: new DateTime(2025, 5, 6, 16, 50, 30, 195, DateTimeKind.Local).AddTicks(5889));

            migrationBuilder.AddForeignKey(
                name: "FK_FoodOrderFoods_FoodOrders_FoodOrdersId",
                table: "FoodOrderFoods",
                column: "FoodOrdersId",
                principalTable: "FoodOrders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FoodOrderFoods_Foods_FoodsId",
                table: "FoodOrderFoods",
                column: "FoodsId",
                principalTable: "Foods",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
