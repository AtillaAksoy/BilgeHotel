using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BilgeHotel.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddedOtherObject : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IdentificationNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
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
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployePassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdentificationNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsPassive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PriceTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsPassive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PriceTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReservationsStates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StateName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsPassive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReservationsStates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReservationsTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsPassive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReservationsTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoomsStates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    State = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Note = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsPassive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomsStates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoomsTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsPassive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomsTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ShiftStates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    IsPassive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShiftStates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WorkTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    IsPassive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    EmployeeId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoles_AspNetUsers_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                name: "EmployeePrices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<decimal>(type: "money", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    EmployeeId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PriceTypeId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsPassive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeePrices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeePrices_AspNetUsers_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeePrices_PriceTypes_PriceTypeId",
                        column: x => x.PriceTypeId,
                        principalTable: "PriceTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoomNumber = table.Column<short>(type: "smallint", nullable: false),
                    price = table.Column<decimal>(type: "money", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    RoomTypeId = table.Column<int>(type: "int", nullable: false),
                    RoomStateId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsPassive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rooms_RoomsStates_RoomStateId",
                        column: x => x.RoomStateId,
                        principalTable: "RoomsStates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Rooms_RoomsTypes_RoomTypeId",
                        column: x => x.RoomTypeId,
                        principalTable: "RoomsTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Shifts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RealStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RealEndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExcuseDescription = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    EmployeeId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    WorkTypeId = table.Column<int>(type: "int", nullable: false),
                    ShiftStateId = table.Column<int>(type: "int", nullable: false),
                    IsPassive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shifts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Shifts_AspNetUsers_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Shifts_ShiftStates_ShiftStateId",
                        column: x => x.ShiftStateId,
                        principalTable: "ShiftStates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Shifts_WorkTypes_WorkTypeId",
                        column: x => x.WorkTypeId,
                        principalTable: "WorkTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImagePath = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    RoomId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsPassive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Images_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "money", nullable: false),
                    RealPrice = table.Column<decimal>(type: "money", nullable: false),
                    RefuendedPrice = table.Column<decimal>(type: "money", nullable: true),
                    CancelDescription = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ReservationTypeId = table.Column<int>(type: "int", nullable: false),
                    ReservationStateId = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    RoomId = table.Column<int>(type: "int", nullable: false),
                    EmployeId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsPassive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reservations_AspNetUsers_EmployeId",
                        column: x => x.EmployeId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reservations_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reservations_ReservationsStates_ReservationStateId",
                        column: x => x.ReservationStateId,
                        principalTable: "ReservationsStates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reservations_ReservationsTypes_ReservationTypeId",
                        column: x => x.ReservationTypeId,
                        principalTable: "ReservationsTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reservations_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "EmployeeId", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "214e4ce5-d605-44fe-a3cc-4706c11f5f16", null, null, "Elektrikçi", null },
                    { "3eaf43bc-b0b6-4511-838e-ade7d2e947d3", null, null, "Garson", null },
                    { "624e69a8-c918-49e8-be3c-2b705231adcd", null, null, "Admin", null },
                    { "6c13a5b3-65ca-4bbc-b62e-957c62c056cc", null, null, "Temizlik görevlisi", null },
                    { "7553d943-7f7a-47e2-9640-17b9bac12bdf", null, null, "Bilgi işlem sorumlusu", null },
                    { "964bbd8c-8601-456b-909e-55560ec424c7", null, null, "Yönetim", null },
                    { "e3516b9f-aa31-4b9e-b53b-4771eaa9be5c", null, null, "Resepsiyon görevlisi", null },
                    { "ee69e1a7-487b-4b9e-a92a-bf2867919423", null, null, "Aşçı", null }
                });

            migrationBuilder.InsertData(
                table: "PriceTypes",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "IsPassive", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 31, 20, 47, 22, 414, DateTimeKind.Local).AddTicks(7987), false, false, "Saatlik", null },
                    { 2, new DateTime(2024, 3, 31, 20, 47, 22, 414, DateTimeKind.Local).AddTicks(8010), false, false, "Günlük", null },
                    { 3, new DateTime(2024, 3, 31, 20, 47, 22, 414, DateTimeKind.Local).AddTicks(8012), false, false, "Aylık", null }
                });

            migrationBuilder.InsertData(
                table: "ReservationsStates",
                columns: new[] { "Id", "CreatedDate", "Description", "IsDeleted", "IsPassive", "StateName", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 31, 20, 47, 22, 415, DateTimeKind.Local).AddTicks(6515), "ödemesi alındı gerçekleştirilecek", false, false, "Planlandı", null },
                    { 2, new DateTime(2024, 3, 31, 20, 47, 22, 415, DateTimeKind.Local).AddTicks(6523), "Kiralama işlemi başarıyla gerçekleşti", false, false, "Tamamlandı", null },
                    { 3, new DateTime(2024, 3, 31, 20, 47, 22, 415, DateTimeKind.Local).AddTicks(6525), "rezervasyonu güncelleyerek iade edilecek tutarı yazmayı ve iade sebebini açıklamayı unutmayınız", false, false, "İptal-iadeli", null },
                    { 4, new DateTime(2024, 3, 31, 20, 47, 22, 415, DateTimeKind.Local).AddTicks(6526), "rezervasyonu güncelleyerek açıklamaya iade sebebini yazmayı unutmayınız", false, false, "İptal-iadesiz", null }
                });

            migrationBuilder.InsertData(
                table: "ReservationsTypes",
                columns: new[] { "Id", "CreatedDate", "Description", "IsDeleted", "IsPassive", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 31, 20, 47, 22, 415, DateTimeKind.Local).AddTicks(7115), "Konaklama ücretine kahvaltı, öğle yemeği ve akşam yemeği dahildir.", false, false, "Tam pansiyon", null },
                    { 2, new DateTime(2024, 3, 31, 20, 47, 22, 415, DateTimeKind.Local).AddTicks(7120), "Konaklama ücretine yemeklerin yanı sıra içecekler ve bazı aktiviteler de dahildir.", false, false, "Her şey dahil", null }
                });

            migrationBuilder.InsertData(
                table: "RoomsStates",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "IsPassive", "Note", "State", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 31, 20, 47, 22, 416, DateTimeKind.Local).AddTicks(3790), false, false, "Kiralama yapılamaz", "Dolu", null },
                    { 2, new DateTime(2024, 3, 31, 20, 47, 22, 416, DateTimeKind.Local).AddTicks(3797), false, false, "Temizlendi eksikleri giderildi yeni müşterisini bekliyor", "Boş", null },
                    { 3, new DateTime(2024, 3, 31, 20, 47, 22, 416, DateTimeKind.Local).AddTicks(3798), false, false, "Oda boşaldı temizlik personeli bekliyor", "Temizlenecek", null },
                    { 4, new DateTime(2024, 3, 31, 20, 47, 22, 416, DateTimeKind.Local).AddTicks(3800), false, false, "Oda'da arıza mevcut teknisyen bekliyor", "Bakım", null }
                });

            migrationBuilder.InsertData(
                table: "RoomsTypes",
                columns: new[] { "Id", "CreatedDate", "Description", "IsDeleted", "IsPassive", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 31, 20, 47, 22, 416, DateTimeKind.Local).AddTicks(5209), "Tek kişilik yataklı odalar. Her katta bulunabilir. Oda özellikleri: Kahvaltı, öğle yemeği ve akşam yemeği dahil değildir. Minibar, klima, TV, saç kurutma makinesi ve kablosuz internet standarttır.", false, false, "Tek Kişilik Oda", null },
                    { 2, new DateTime(2024, 3, 31, 20, 47, 22, 416, DateTimeKind.Local).AddTicks(5216), "İki kişilik yataklı odalar. Her katta bulunabilir. Oda özellikleri: Kahvaltı, öğle yemeği ve akşam yemeği dahil değildir. Minibar, klima, TV, saç kurutma makinesi ve kablosuz internet standarttır.", false, false, "İki Kişilik Oda", null },
                    { 3, new DateTime(2024, 3, 31, 20, 47, 22, 416, DateTimeKind.Local).AddTicks(5217), "Üç kişilik yataklı odalar. Yalnızca birinci katta bulunabilir. Oda özellikleri: Kahvaltı, öğle yemeği ve akşam yemeği dahil değildir. Minibar, klima, TV, saç kurutma makinesi ve kablosuz internet standarttır.", false, false, "Üç Kişilik Oda", null },
                    { 4, new DateTime(2024, 3, 31, 20, 47, 22, 416, DateTimeKind.Local).AddTicks(5218), "Dört kişilik yataklı odalar. Yalnızca dördüncü katta bulunabilir. Oda özellikleri: Kahvaltı, öğle yemeği ve akşam yemeği dahil değildir. Minibar, klima, TV, saç kurutma makinesi ve kablosuz internet standarttır.", false, false, "Dört Kişilik Oda", null },
                    { 5, new DateTime(2024, 3, 31, 20, 47, 22, 416, DateTimeKind.Local).AddTicks(5219), "Özel bir konaklama deneyimi sunan lüks daire. Yalnızca dördüncü katta bulunabilir. Oda özellikleri: Kahvaltı, öğle yemeği ve akşam yemeği dahil değildir. Balkon bulunmaktadır. Minibar, klima, TV, saç kurutma makinesi ve kablosuz internet standarttır.", false, false, "Kral Dairesi", null }
                });

            migrationBuilder.InsertData(
                table: "ShiftStates",
                columns: new[] { "Id", "Description", "IsDeleted", "IsPassive", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "Planlama gerçekleşti uyulması bekleniyor.", false, false, "Planlanan", null },
                    { 2, "Uyum sağlandı tam zamanlı çalışıldı.", false, false, "Tamamlandı", null },
                    { 3, "Çalışan geç geldiyse shifti güncelleyerek gerçek giriş saatini doldurunuz ve açıklamasını yazınız.", false, false, "Geç Geldi", null },
                    { 4, "Çalışan erken çıktı ise shifti güncelleyerek gerçek çıkış saatini doldurunuz ve açıklamasını yazınız.", false, false, "Erken Çıktı", null },
                    { 5, "Çalışan geç gelip erken çıktı ise shifti güncelleyerek gerçek giriş ve çıkış saatlerini doldurunuz ayrıca açıklamasını yazınız.", false, false, "Geç Geldi Ve Erken Çıktı", null },
                    { 6, "Çalışan haberli veya habersiz gelmedi ise shifti güncelleyerek çalışma tipini 'Ücretli Mazeret İzni' veya 'Ücretsiz Mazeret İzni' olarak güncelleyiniz.", false, false, "Gelmedi", null }
                });

            migrationBuilder.InsertData(
                table: "WorkTypes",
                columns: new[] { "Id", "Description", "IsDeleted", "IsPassive", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "Sabah vardiyası: 08:00 - 16:00 1/3", false, false, "Normal Mesai Sabah ", null },
                    { 2, "Akşam vardiyası: 16:00 - 00:00 1/3", false, false, "Normal Mesai Akşam ", null },
                    { 3, "Gece vardiyası: 00:00 - 08:00 1/3", false, false, "Normal Mesai Gece", null },
                    { 4, "mesai saatleri 8:00 ile 18:00", false, false, "Normal Mesai", null },
                    { 5, "Ücretli Ek Mesai", false, false, "Ek Mesai", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoles_EmployeeId",
                table: "AspNetRoles",
                column: "EmployeeId");

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
                name: "IX_EmployeePrices_EmployeeId",
                table: "EmployeePrices",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeePrices_PriceTypeId",
                table: "EmployeePrices",
                column: "PriceTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Images_RoomId",
                table: "Images",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_CustomerId",
                table: "Reservations",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_EmployeId",
                table: "Reservations",
                column: "EmployeId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_ReservationStateId",
                table: "Reservations",
                column: "ReservationStateId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_ReservationTypeId",
                table: "Reservations",
                column: "ReservationTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_RoomId",
                table: "Reservations",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_RoomStateId",
                table: "Rooms",
                column: "RoomStateId");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_RoomTypeId",
                table: "Rooms",
                column: "RoomTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Shifts_EmployeeId",
                table: "Shifts",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Shifts_ShiftStateId",
                table: "Shifts",
                column: "ShiftStateId");

            migrationBuilder.CreateIndex(
                name: "IX_Shifts_WorkTypeId",
                table: "Shifts",
                column: "WorkTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                name: "EmployeePrices");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "Shifts");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "PriceTypes");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "ReservationsStates");

            migrationBuilder.DropTable(
                name: "ReservationsTypes");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "ShiftStates");

            migrationBuilder.DropTable(
                name: "WorkTypes");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "RoomsStates");

            migrationBuilder.DropTable(
                name: "RoomsTypes");
        }
    }
}
