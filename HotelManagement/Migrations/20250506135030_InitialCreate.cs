using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HotelManagement.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Capacity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Foods",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foods", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoomTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(10,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    ApplicationUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bookings_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoomNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoomTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rooms_RoomTypes_RoomTypeId",
                        column: x => x.RoomTypeId,
                        principalTable: "RoomTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateTable(
                name: "FoodOrders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    ApplicationUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoomId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodOrders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FoodOrders_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FoodOrders_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    ReviewDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ApplicationUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoomId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    FoodId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reviews_Foods_FoodId",
                        column: x => x.FoodId,
                        principalTable: "Foods",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Reviews_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RoomBookings",
                columns: table => new
                {
                    BookingsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoomsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomBookings", x => new { x.BookingsId, x.RoomsId });
                    table.ForeignKey(
                        name: "FK_RoomBookings_Bookings_BookingsId",
                        column: x => x.BookingsId,
                        principalTable: "Bookings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoomBookings_Rooms_RoomsId",
                        column: x => x.RoomsId,
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FoodOrderFoods",
                columns: table => new
                {
                    FoodsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FoodOrdersId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodOrderFoods", x => new { x.FoodsId, x.FoodOrdersId });
                    table.ForeignKey(
                        name: "FK_FoodOrderFoods_FoodOrders_FoodOrdersId",
                        column: x => x.FoodOrdersId,
                        principalTable: "FoodOrders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FoodOrderFoods_Foods_FoodsId",
                        column: x => x.FoodsId,
                        principalTable: "Foods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("87600eb8-1da1-452a-a0bc-0d9c808b4b11"), null, "Customer", "CUSTOMER" },
                    { new Guid("87600eb8-1da1-452a-a0bc-0d9c808b4b12"), null, "Receptionist", "RECEPTIONIST" },
                    { new Guid("87600eb8-1da1-452a-a0bc-0d9c808b4b13"), null, "Manager", "MANAGER" },
                    { new Guid("87600eb8-1da1-452a-a0bc-0d9c808b4b14"), null, "Staff", "STAFF" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("67019a3d-04de-444b-bb6c-6ef934dcd291"), 0, "a89e3cd4-6b35-47fd-8619-2ccda2f63bc3", "user1@example.com", true, false, null, "USER1@EXAMPLE.COM", "USER1", "AQAAAAIAAYagAAAAENot6gCpWS4SwF+LYO7NKU3VB3fmob4Obsj4PB/fd7zNUBI4dMdpi5T9m7hAwepWFA==", null, false, "67019a3d-04de-444b-bb6c-6ef934dcd291", false, "user1" },
                    { new Guid("67019a3d-04de-444b-bb6c-6ef934dcd292"), 0, "a1521484-b926-4e30-ba04-8ee1f1d5576d", "user2@example.com", true, false, null, "USER2@EXAMPLE.COM", "USER2", "AQAAAAIAAYagAAAAEJHBAVx3LWKdurTdMOl0MfNDC3YUv7pOYUM8uNjlp3Qpdbt65Tuc08Bbxg6TGMeRkg==", null, false, "67019a3d-04de-444b-bb6c-6ef934dcd292", false, "user2" },
                    { new Guid("67019a3d-04de-444b-bb6c-6ef934dcd293"), 0, "e016b9a2-c649-412d-ac4c-f3370ca26db7", "user3@example.com", true, false, null, "USER3@EXAMPLE.COM", "USER3", "AQAAAAIAAYagAAAAEE0RuWU/Pk0nbvUcZkVTLnpEPILmxCXAad/THeTBMHFos8L3Ugre9UtCHDSH2+qmeg==", null, false, "67019a3d-04de-444b-bb6c-6ef934dcd293", false, "user3" }
                });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "Capacity", "Date", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("5a6da81a-74a0-4d50-8cac-fea2f7897731"), 0, new DateTime(2023, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "A night of nostalgia with classic hits.", "Oldies Party" },
                    { new Guid("6b7da81a-74a0-4d50-8cac-fea2f7897732"), 0, new DateTime(2023, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Enjoy a relaxing evening with smooth jazz.", "Jazz Night" }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("a9063d88-88c6-40db-a7e9-868afeb45811"), "Delicious cheese pizza with fresh toppings.", "Pizza", 12.99m },
                    { new Guid("a9063d88-88c6-40db-a7e9-868afeb45812"), "Juicy beef burger with lettuce and tomato.", "Burger", 8.99m },
                    { new Guid("a9063d88-88c6-40db-a7e9-868afeb45813"), "Creamy Alfredo pasta with grilled chicken.", "Pasta Alfredo", 10.99m }
                });

            migrationBuilder.InsertData(
                table: "RoomTypes",
                columns: new[] { "Id", "Capacity", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("fbf96b7e-04d2-4290-82e7-40a6f1c76b51"), 1, "A cozy room for one person", "Single", 50.0m },
                    { new Guid("fbf96b7e-04d2-4290-82e7-40a6f1c76b52"), 2, "Comfortable for two guests", "Double", 90.0m },
                    { new Guid("fbf96b7e-04d2-4290-82e7-40a6f1c76b53"), 4, "Luxury suite with extra amenities", "Suite", 160.0m },
                    { new Guid("fbf96b7e-04d2-4290-82e7-40a6f1c76b54"), 6, "Spacious room for families", "Family", 220.0m }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("87600eb8-1da1-452a-a0bc-0d9c808b4b11"), new Guid("67019a3d-04de-444b-bb6c-6ef934dcd291") },
                    { new Guid("87600eb8-1da1-452a-a0bc-0d9c808b4b13"), new Guid("67019a3d-04de-444b-bb6c-6ef934dcd292") },
                    { new Guid("87600eb8-1da1-452a-a0bc-0d9c808b4b14"), new Guid("67019a3d-04de-444b-bb6c-6ef934dcd293") }
                });

            migrationBuilder.InsertData(
                table: "Bookings",
                columns: new[] { "Id", "ApplicationUserId", "EndDate", "StartDate", "Status" },
                values: new object[,]
                {
                    { new Guid("371c096d-5c0b-4929-aab5-1c0289611901"), new Guid("67019a3d-04de-444b-bb6c-6ef934dcd291"), new DateTime(2025, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { new Guid("371c096d-5c0b-4929-aab5-1c0289611902"), new Guid("67019a3d-04de-444b-bb6c-6ef934dcd291"), new DateTime(2025, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 }
                });

            migrationBuilder.InsertData(
                table: "EventUsers",
                columns: new[] { "EventsId", "UsersId" },
                values: new object[,]
                {
                    { new Guid("5a6da81a-74a0-4d50-8cac-fea2f7897731"), new Guid("67019a3d-04de-444b-bb6c-6ef934dcd291") },
                    { new Guid("5a6da81a-74a0-4d50-8cac-fea2f7897731"), new Guid("67019a3d-04de-444b-bb6c-6ef934dcd292") }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "ApplicationUserId", "Comment", "FoodId", "Rating", "ReviewDate", "RoomId" },
                values: new object[,]
                {
                    { new Guid("4aef3307-19ee-4b61-8efa-8828279e7292"), new Guid("67019a3d-04de-444b-bb6c-6ef934dcd291"), "Pretty decent pizza", new Guid("a9063d88-88c6-40db-a7e9-868afeb45811"), 7, new DateTime(2025, 5, 6, 16, 50, 30, 195, DateTimeKind.Local).AddTicks(5857), null },
                    { new Guid("4aef3307-19ee-4b61-8efa-8828279e7294"), new Guid("67019a3d-04de-444b-bb6c-6ef934dcd291"), "Great burger, will order again!", new Guid("a9063d88-88c6-40db-a7e9-868afeb45812"), 8, new DateTime(2025, 5, 6, 16, 50, 30, 195, DateTimeKind.Local).AddTicks(5889), null }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Description", "RoomNumber", "RoomTypeId" },
                values: new object[,]
                {
                    { new Guid("a242ae42-b5f3-417e-9277-b89ac16fca21"), "Room 101", "101", new Guid("fbf96b7e-04d2-4290-82e7-40a6f1c76b51") },
                    { new Guid("a242ae42-b5f3-417e-9277-b89ac16fca22"), "Room 102", "102", new Guid("fbf96b7e-04d2-4290-82e7-40a6f1c76b52") },
                    { new Guid("a242ae42-b5f3-417e-9277-b89ac16fca23"), "Room 103", "103", new Guid("fbf96b7e-04d2-4290-82e7-40a6f1c76b53") }
                });

            migrationBuilder.InsertData(
                table: "ActivityRecords",
                columns: new[] { "Id", "ApplicationUserId", "Date", "Description", "RoomId", "Status", "Type" },
                values: new object[,]
                {
                    { new Guid("db1ae6ab-91a7-4aaf-a08a-4097ce670a31"), new Guid("67019a3d-04de-444b-bb6c-6ef934dcd291"), new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Room 101 cleaning", new Guid("a242ae42-b5f3-417e-9277-b89ac16fca21"), 0, 0 },
                    { new Guid("db1ae6ab-91a7-4aaf-a08a-4097ce670a32"), new Guid("67019a3d-04de-444b-bb6c-6ef934dcd293"), new DateTime(2023, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Room 102 maintenance", new Guid("a242ae42-b5f3-417e-9277-b89ac16fca22"), 2, 1 },
                    { new Guid("db1ae6ab-91a7-4aaf-a08a-4097ce670a33"), new Guid("67019a3d-04de-444b-bb6c-6ef934dcd293"), new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Room 102 cleaning", new Guid("a242ae42-b5f3-417e-9277-b89ac16fca22"), 0, 0 }
                });

            migrationBuilder.InsertData(
                table: "FoodOrders",
                columns: new[] { "Id", "ApplicationUserId", "Description", "OrderDate", "RoomId", "Status" },
                values: new object[,]
                {
                    { new Guid("41d65c90-de3e-49be-8802-8cbc5b4e2961"), new Guid("67019a3d-04de-444b-bb6c-6ef934dcd291"), "Order 1", new DateTime(2025, 5, 6, 16, 50, 30, 191, DateTimeKind.Local).AddTicks(8422), new Guid("a242ae42-b5f3-417e-9277-b89ac16fca21"), 0 },
                    { new Guid("41d65c90-de3e-49be-8802-8cbc5b4e2962"), new Guid("67019a3d-04de-444b-bb6c-6ef934dcd291"), "Order 2", new DateTime(2025, 5, 6, 16, 50, 30, 194, DateTimeKind.Local).AddTicks(3667), new Guid("a242ae42-b5f3-417e-9277-b89ac16fca22"), 2 }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "ApplicationUserId", "Comment", "FoodId", "Rating", "ReviewDate", "RoomId" },
                values: new object[,]
                {
                    { new Guid("4aef3307-19ee-4b61-8efa-8828279e7291"), new Guid("67019a3d-04de-444b-bb6c-6ef934dcd291"), "Excellent service and clean room!", null, 9, new DateTime(2025, 5, 6, 16, 50, 30, 195, DateTimeKind.Local).AddTicks(5372), new Guid("a242ae42-b5f3-417e-9277-b89ac16fca21") },
                    { new Guid("4aef3307-19ee-4b61-8efa-8828279e7293"), new Guid("67019a3d-04de-444b-bb6c-6ef934dcd291"), "Average experience, could be better.", null, 5, new DateTime(2025, 5, 6, 16, 50, 30, 195, DateTimeKind.Local).AddTicks(5875), new Guid("a242ae42-b5f3-417e-9277-b89ac16fca22") }
                });

            migrationBuilder.InsertData(
                table: "RoomBookings",
                columns: new[] { "BookingsId", "RoomsId" },
                values: new object[,]
                {
                    { new Guid("371c096d-5c0b-4929-aab5-1c0289611901"), new Guid("a242ae42-b5f3-417e-9277-b89ac16fca21") },
                    { new Guid("371c096d-5c0b-4929-aab5-1c0289611901"), new Guid("a242ae42-b5f3-417e-9277-b89ac16fca22") },
                    { new Guid("371c096d-5c0b-4929-aab5-1c0289611902"), new Guid("a242ae42-b5f3-417e-9277-b89ac16fca21") }
                });

            migrationBuilder.InsertData(
                table: "FoodOrderFoods",
                columns: new[] { "FoodOrdersId", "FoodsId" },
                values: new object[,]
                {
                    { new Guid("41d65c90-de3e-49be-8802-8cbc5b4e2961"), new Guid("a9063d88-88c6-40db-a7e9-868afeb45811") },
                    { new Guid("41d65c90-de3e-49be-8802-8cbc5b4e2961"), new Guid("a9063d88-88c6-40db-a7e9-868afeb45812") },
                    { new Guid("41d65c90-de3e-49be-8802-8cbc5b4e2962"), new Guid("a9063d88-88c6-40db-a7e9-868afeb45813") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActivityRecords_ApplicationUserId",
                table: "ActivityRecords",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ActivityRecords_RoomId",
                table: "ActivityRecords",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_ApplicationUserId",
                table: "Bookings",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_EventUsers_EventsId",
                table: "EventUsers",
                column: "EventsId");

            migrationBuilder.CreateIndex(
                name: "IX_FoodOrderFoods_FoodOrdersId",
                table: "FoodOrderFoods",
                column: "FoodOrdersId");

            migrationBuilder.CreateIndex(
                name: "IX_FoodOrders_ApplicationUserId",
                table: "FoodOrders",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_FoodOrders_RoomId",
                table: "FoodOrders",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_ApplicationUserId",
                table: "Reviews",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_FoodId",
                table: "Reviews",
                column: "FoodId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_RoomId",
                table: "Reviews",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomBookings_RoomsId",
                table: "RoomBookings",
                column: "RoomsId");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_RoomTypeId",
                table: "Rooms",
                column: "RoomTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActivityRecords");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "EventUsers");

            migrationBuilder.DropTable(
                name: "FoodOrderFoods");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "RoomBookings");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "FoodOrders");

            migrationBuilder.DropTable(
                name: "Foods");

            migrationBuilder.DropTable(
                name: "Bookings");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "RoomTypes");
        }
    }
}
