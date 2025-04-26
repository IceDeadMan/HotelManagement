using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelManagement.Migrations
{
    /// <inheritdoc />
    public partial class ActivityRecord : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ActivityRecords",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    RoomId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ApplicationUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityRecords", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ActivityRecords_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ActivityRecords_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd291"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f41432b7-9a80-4cc0-9a68-a3aa11628b85", "AQAAAAIAAYagAAAAELHSdcyWJp5GWxbwmIP5YuFvhKs6+fJ5AsbPiHfAktBNqFcyQxzdhIzRIGVqRS3Z1Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd292"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e072d500-b68a-460b-8b26-deeef06926a0", "AQAAAAIAAYagAAAAEOiH3DFNlBtWgTAD+3ZM0OLZJkQLcm3HqlHKvLFpqso4SKkDK0JyfnSANqR9ThpPEw==" });

            migrationBuilder.CreateIndex(
                name: "IX_ActivityRecords_ApplicationUserId",
                table: "ActivityRecords",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ActivityRecords_RoomId",
                table: "ActivityRecords",
                column: "RoomId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActivityRecords");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd291"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "261534f1-4efe-4b2b-9be1-15137ebeda99", "AQAAAAIAAYagAAAAEDvYqCafJhZhYle7vhcpR1wcC6BvucijdEpaBZwr3RrbxFilYatIKkzRP8U/DizggQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67019a3d-04de-444b-bb6c-6ef934dcd292"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c27395de-0c74-4fd3-a534-90dab4bd6d0a", "AQAAAAIAAYagAAAAEMV9KROIXG1jai3Nb/oWine2CKrdyvRzh1lGy1kUmmwBHw75kug+iO997nQ1z20MBQ==" });
        }
    }
}
