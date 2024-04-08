using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BilgeHotel.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class employeNullableRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "214e4ce5-d605-44fe-a3cc-4706c11f5f16");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3eaf43bc-b0b6-4511-838e-ade7d2e947d3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "624e69a8-c918-49e8-be3c-2b705231adcd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6c13a5b3-65ca-4bbc-b62e-957c62c056cc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7553d943-7f7a-47e2-9640-17b9bac12bdf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "964bbd8c-8601-456b-909e-55560ec424c7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e3516b9f-aa31-4b9e-b53b-4771eaa9be5c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ee69e1a7-487b-4b9e-a92a-bf2867919423");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "EmployeeId", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1091864b-6292-45a1-babe-e3217e511a15", null, null, "Temizlik görevlisi", null },
                    { "11bd9fc8-3cda-466b-a160-6d46508475b2", null, null, "Aşçı", null },
                    { "2056dedb-d90d-4c47-b879-476f503a6e45", null, null, "Resepsiyon görevlisi", null },
                    { "847c817c-18ec-4324-ad55-eee185a77126", null, null, "Elektrikçi", null },
                    { "afc83e04-fea6-4abd-aff2-a3e20c19fa80", null, null, "Garson", null },
                    { "c80b0c26-281e-4ea4-ae54-f734a46a5b05", null, null, "Yönetim", null },
                    { "e24cb940-6027-40c1-b3a9-1f6d3a9ca725", null, null, "Bilgi işlem sorumlusu", null },
                    { "e3e4bd3b-17a9-4e64-8b93-cc67c93abaf4", null, null, "Admin", null }
                });

            migrationBuilder.UpdateData(
                table: "PriceTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 6, 16, 15, 48, 431, DateTimeKind.Local).AddTicks(8552));

            migrationBuilder.UpdateData(
                table: "PriceTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 6, 16, 15, 48, 431, DateTimeKind.Local).AddTicks(8568));

            migrationBuilder.UpdateData(
                table: "PriceTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 6, 16, 15, 48, 431, DateTimeKind.Local).AddTicks(8569));

            migrationBuilder.UpdateData(
                table: "ReservationsStates",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 6, 16, 15, 48, 432, DateTimeKind.Local).AddTicks(3492));

            migrationBuilder.UpdateData(
                table: "ReservationsStates",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 6, 16, 15, 48, 432, DateTimeKind.Local).AddTicks(3501));

            migrationBuilder.UpdateData(
                table: "ReservationsStates",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 6, 16, 15, 48, 432, DateTimeKind.Local).AddTicks(3503));

            migrationBuilder.UpdateData(
                table: "ReservationsStates",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 6, 16, 15, 48, 432, DateTimeKind.Local).AddTicks(3504));

            migrationBuilder.UpdateData(
                table: "ReservationsTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 6, 16, 15, 48, 432, DateTimeKind.Local).AddTicks(4098));

            migrationBuilder.UpdateData(
                table: "ReservationsTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 6, 16, 15, 48, 432, DateTimeKind.Local).AddTicks(4103));

            migrationBuilder.UpdateData(
                table: "RoomsStates",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 6, 16, 15, 48, 432, DateTimeKind.Local).AddTicks(7481));

            migrationBuilder.UpdateData(
                table: "RoomsStates",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 6, 16, 15, 48, 432, DateTimeKind.Local).AddTicks(7492));

            migrationBuilder.UpdateData(
                table: "RoomsStates",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 6, 16, 15, 48, 432, DateTimeKind.Local).AddTicks(7493));

            migrationBuilder.UpdateData(
                table: "RoomsStates",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 6, 16, 15, 48, 432, DateTimeKind.Local).AddTicks(7494));

            migrationBuilder.UpdateData(
                table: "RoomsTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 6, 16, 15, 48, 432, DateTimeKind.Local).AddTicks(8007));

            migrationBuilder.UpdateData(
                table: "RoomsTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 6, 16, 15, 48, 432, DateTimeKind.Local).AddTicks(8039));

            migrationBuilder.UpdateData(
                table: "RoomsTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 6, 16, 15, 48, 432, DateTimeKind.Local).AddTicks(8040));

            migrationBuilder.UpdateData(
                table: "RoomsTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 6, 16, 15, 48, 432, DateTimeKind.Local).AddTicks(8041));

            migrationBuilder.UpdateData(
                table: "RoomsTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 6, 16, 15, 48, 432, DateTimeKind.Local).AddTicks(8042));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1091864b-6292-45a1-babe-e3217e511a15");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "11bd9fc8-3cda-466b-a160-6d46508475b2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2056dedb-d90d-4c47-b879-476f503a6e45");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "847c817c-18ec-4324-ad55-eee185a77126");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "afc83e04-fea6-4abd-aff2-a3e20c19fa80");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c80b0c26-281e-4ea4-ae54-f734a46a5b05");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e24cb940-6027-40c1-b3a9-1f6d3a9ca725");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e3e4bd3b-17a9-4e64-8b93-cc67c93abaf4");

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

            migrationBuilder.UpdateData(
                table: "PriceTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 31, 20, 47, 22, 414, DateTimeKind.Local).AddTicks(7987));

            migrationBuilder.UpdateData(
                table: "PriceTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 31, 20, 47, 22, 414, DateTimeKind.Local).AddTicks(8010));

            migrationBuilder.UpdateData(
                table: "PriceTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 31, 20, 47, 22, 414, DateTimeKind.Local).AddTicks(8012));

            migrationBuilder.UpdateData(
                table: "ReservationsStates",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 31, 20, 47, 22, 415, DateTimeKind.Local).AddTicks(6515));

            migrationBuilder.UpdateData(
                table: "ReservationsStates",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 31, 20, 47, 22, 415, DateTimeKind.Local).AddTicks(6523));

            migrationBuilder.UpdateData(
                table: "ReservationsStates",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 31, 20, 47, 22, 415, DateTimeKind.Local).AddTicks(6525));

            migrationBuilder.UpdateData(
                table: "ReservationsStates",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 31, 20, 47, 22, 415, DateTimeKind.Local).AddTicks(6526));

            migrationBuilder.UpdateData(
                table: "ReservationsTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 31, 20, 47, 22, 415, DateTimeKind.Local).AddTicks(7115));

            migrationBuilder.UpdateData(
                table: "ReservationsTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 31, 20, 47, 22, 415, DateTimeKind.Local).AddTicks(7120));

            migrationBuilder.UpdateData(
                table: "RoomsStates",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 31, 20, 47, 22, 416, DateTimeKind.Local).AddTicks(3790));

            migrationBuilder.UpdateData(
                table: "RoomsStates",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 31, 20, 47, 22, 416, DateTimeKind.Local).AddTicks(3797));

            migrationBuilder.UpdateData(
                table: "RoomsStates",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 31, 20, 47, 22, 416, DateTimeKind.Local).AddTicks(3798));

            migrationBuilder.UpdateData(
                table: "RoomsStates",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 31, 20, 47, 22, 416, DateTimeKind.Local).AddTicks(3800));

            migrationBuilder.UpdateData(
                table: "RoomsTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 31, 20, 47, 22, 416, DateTimeKind.Local).AddTicks(5209));

            migrationBuilder.UpdateData(
                table: "RoomsTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 31, 20, 47, 22, 416, DateTimeKind.Local).AddTicks(5216));

            migrationBuilder.UpdateData(
                table: "RoomsTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 31, 20, 47, 22, 416, DateTimeKind.Local).AddTicks(5217));

            migrationBuilder.UpdateData(
                table: "RoomsTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 31, 20, 47, 22, 416, DateTimeKind.Local).AddTicks(5218));

            migrationBuilder.UpdateData(
                table: "RoomsTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 31, 20, 47, 22, 416, DateTimeKind.Local).AddTicks(5219));
        }
    }
}
