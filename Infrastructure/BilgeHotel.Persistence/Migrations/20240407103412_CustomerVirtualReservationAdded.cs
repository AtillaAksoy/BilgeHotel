using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BilgeHotel.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class CustomerVirtualReservationAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "EmployeeId", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "22fe8d34-85ed-4696-9939-f4d017a8ec3b", null, null, "Aşçı", null },
                    { "7b02acfb-2459-4f42-b150-30e66e690cbb", null, null, "Yönetim", null },
                    { "aab88dbb-6463-4aab-aef2-ef524dea23ff", null, null, "Admin", null },
                    { "acb505aa-445f-4d9b-b307-0af1b3347919", null, null, "Temizlik görevlisi", null },
                    { "bda561f1-6891-4e02-947a-3fce4a0606e5", null, null, "Garson", null },
                    { "cd775c3f-dcd2-4bc5-b7a0-f852d1903611", null, null, "Bilgi işlem sorumlusu", null },
                    { "dc84f30b-9751-4cce-b364-e1a5a050696e", null, null, "Elektrikçi", null },
                    { "e99acf4c-8e5c-49fb-9018-0d4109956c56", null, null, "Resepsiyon görevlisi", null }
                });

            migrationBuilder.UpdateData(
                table: "PriceTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 7, 13, 34, 12, 528, DateTimeKind.Local).AddTicks(5256));

            migrationBuilder.UpdateData(
                table: "PriceTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 7, 13, 34, 12, 528, DateTimeKind.Local).AddTicks(5280));

            migrationBuilder.UpdateData(
                table: "PriceTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 7, 13, 34, 12, 528, DateTimeKind.Local).AddTicks(5283));

            migrationBuilder.UpdateData(
                table: "ReservationsStates",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 7, 13, 34, 12, 529, DateTimeKind.Local).AddTicks(4673));

            migrationBuilder.UpdateData(
                table: "ReservationsStates",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 7, 13, 34, 12, 529, DateTimeKind.Local).AddTicks(4687));

            migrationBuilder.UpdateData(
                table: "ReservationsStates",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 7, 13, 34, 12, 529, DateTimeKind.Local).AddTicks(4690));

            migrationBuilder.UpdateData(
                table: "ReservationsStates",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 7, 13, 34, 12, 529, DateTimeKind.Local).AddTicks(4692));

            migrationBuilder.UpdateData(
                table: "ReservationsTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 7, 13, 34, 12, 529, DateTimeKind.Local).AddTicks(5891));

            migrationBuilder.UpdateData(
                table: "ReservationsTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 7, 13, 34, 12, 529, DateTimeKind.Local).AddTicks(5900));

            migrationBuilder.UpdateData(
                table: "RoomsStates",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 7, 13, 34, 12, 530, DateTimeKind.Local).AddTicks(2453));

            migrationBuilder.UpdateData(
                table: "RoomsStates",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 7, 13, 34, 12, 530, DateTimeKind.Local).AddTicks(2466));

            migrationBuilder.UpdateData(
                table: "RoomsStates",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 7, 13, 34, 12, 530, DateTimeKind.Local).AddTicks(2468));

            migrationBuilder.UpdateData(
                table: "RoomsStates",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 7, 13, 34, 12, 530, DateTimeKind.Local).AddTicks(2469));

            migrationBuilder.UpdateData(
                table: "RoomsTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 7, 13, 34, 12, 530, DateTimeKind.Local).AddTicks(3664));

            migrationBuilder.UpdateData(
                table: "RoomsTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 7, 13, 34, 12, 530, DateTimeKind.Local).AddTicks(3672));

            migrationBuilder.UpdateData(
                table: "RoomsTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 7, 13, 34, 12, 530, DateTimeKind.Local).AddTicks(3674));

            migrationBuilder.UpdateData(
                table: "RoomsTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 7, 13, 34, 12, 530, DateTimeKind.Local).AddTicks(3676));

            migrationBuilder.UpdateData(
                table: "RoomsTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 7, 13, 34, 12, 530, DateTimeKind.Local).AddTicks(3678));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "22fe8d34-85ed-4696-9939-f4d017a8ec3b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7b02acfb-2459-4f42-b150-30e66e690cbb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aab88dbb-6463-4aab-aef2-ef524dea23ff");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "acb505aa-445f-4d9b-b307-0af1b3347919");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bda561f1-6891-4e02-947a-3fce4a0606e5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cd775c3f-dcd2-4bc5-b7a0-f852d1903611");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dc84f30b-9751-4cce-b364-e1a5a050696e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e99acf4c-8e5c-49fb-9018-0d4109956c56");

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
    }
}
