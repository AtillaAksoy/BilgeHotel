using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BilgeHotel.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class employeeaddedIsDeleted : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "AspNetUsers",
                type: "bit",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "EmployeeId", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "17a98e81-4bf9-497a-bc2e-4cb453c00e15", null, null, "Resepsiyon görevlisi", null },
                    { "1d865739-543f-4a6e-9dcf-a80bc5adfeca", null, null, "Aşçı", null },
                    { "288aae38-5108-4632-b738-9fcf0e88e383", null, null, "Bilgi işlem sorumlusu", null },
                    { "2f9d0b97-e9d3-4191-8567-a3f30cb483ff", null, null, "Temizlik görevlisi", null },
                    { "d15bc933-f383-41b2-9d7d-471dddeb1a8a", null, null, "Yönetim", null },
                    { "db7a520b-48a8-411d-a689-e0ca25075b70", null, null, "Garson", null },
                    { "e0d275c2-8957-4fa3-9ae4-c80acad36351", null, null, "Elektrikçi", null },
                    { "f0f6567c-5f18-4ac1-b097-99d48a9dea59", null, null, "Admin", null }
                });

            migrationBuilder.UpdateData(
                table: "PriceTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 7, 3, 49, 28, 645, DateTimeKind.Local).AddTicks(3564));

            migrationBuilder.UpdateData(
                table: "PriceTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 7, 3, 49, 28, 645, DateTimeKind.Local).AddTicks(3584));

            migrationBuilder.UpdateData(
                table: "PriceTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 7, 3, 49, 28, 645, DateTimeKind.Local).AddTicks(3587));

            migrationBuilder.UpdateData(
                table: "ReservationsStates",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 7, 3, 49, 28, 646, DateTimeKind.Local).AddTicks(3947));

            migrationBuilder.UpdateData(
                table: "ReservationsStates",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 7, 3, 49, 28, 646, DateTimeKind.Local).AddTicks(3962));

            migrationBuilder.UpdateData(
                table: "ReservationsStates",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 7, 3, 49, 28, 646, DateTimeKind.Local).AddTicks(3964));

            migrationBuilder.UpdateData(
                table: "ReservationsStates",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 7, 3, 49, 28, 646, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "ReservationsTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 7, 3, 49, 28, 646, DateTimeKind.Local).AddTicks(4806));

            migrationBuilder.UpdateData(
                table: "ReservationsTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 7, 3, 49, 28, 646, DateTimeKind.Local).AddTicks(4854));

            migrationBuilder.UpdateData(
                table: "RoomsStates",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 7, 3, 49, 28, 647, DateTimeKind.Local).AddTicks(2303));

            migrationBuilder.UpdateData(
                table: "RoomsStates",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 7, 3, 49, 28, 647, DateTimeKind.Local).AddTicks(2312));

            migrationBuilder.UpdateData(
                table: "RoomsStates",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 7, 3, 49, 28, 647, DateTimeKind.Local).AddTicks(2314));

            migrationBuilder.UpdateData(
                table: "RoomsStates",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 7, 3, 49, 28, 647, DateTimeKind.Local).AddTicks(2316));

            migrationBuilder.UpdateData(
                table: "RoomsTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 7, 3, 49, 28, 647, DateTimeKind.Local).AddTicks(3139));

            migrationBuilder.UpdateData(
                table: "RoomsTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 7, 3, 49, 28, 647, DateTimeKind.Local).AddTicks(3146));

            migrationBuilder.UpdateData(
                table: "RoomsTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 7, 3, 49, 28, 647, DateTimeKind.Local).AddTicks(3148));

            migrationBuilder.UpdateData(
                table: "RoomsTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 7, 3, 49, 28, 647, DateTimeKind.Local).AddTicks(3149));

            migrationBuilder.UpdateData(
                table: "RoomsTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 7, 3, 49, 28, 647, DateTimeKind.Local).AddTicks(3151));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "17a98e81-4bf9-497a-bc2e-4cb453c00e15");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1d865739-543f-4a6e-9dcf-a80bc5adfeca");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "288aae38-5108-4632-b738-9fcf0e88e383");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2f9d0b97-e9d3-4191-8567-a3f30cb483ff");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d15bc933-f383-41b2-9d7d-471dddeb1a8a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "db7a520b-48a8-411d-a689-e0ca25075b70");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e0d275c2-8957-4fa3-9ae4-c80acad36351");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f0f6567c-5f18-4ac1-b097-99d48a9dea59");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "AspNetUsers");

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
    }
}
