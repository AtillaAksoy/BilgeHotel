using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BilgeHotel.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class ReservationAddIsPayyed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<bool>(
                name: "IsPayyed",
                table: "Reservations",
                type: "bit",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "EmployeeId", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "023cb791-149c-4b9d-affd-c58ac5519a52", null, null, "Resepsiyon görevlisi", null },
                    { "3fc44bdb-0a82-43ae-bf5d-c8f1f676452e", null, null, "Bilgi işlem sorumlusu", null },
                    { "a25ecc16-0dd0-4aaf-a545-7d63b7f7a367", null, null, "Temizlik görevlisi", null },
                    { "b74ce0eb-2a7a-4b5b-8b35-596c86958b27", null, null, "Elektrikçi", null },
                    { "d013135d-aa50-4a64-acab-0bd462a51198", null, null, "Admin", null },
                    { "d12536d9-5e60-4ba2-a33a-5f81d18006cd", null, null, "Aşçı", null },
                    { "da74d179-d709-4950-9194-98ebab76c80c", null, null, "Yönetim", null },
                    { "f6f52ba0-f50f-41e4-a84d-c38d2899416d", null, null, "Garson", null }
                });

            migrationBuilder.UpdateData(
                table: "PriceTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 7, 19, 19, 50, 859, DateTimeKind.Local).AddTicks(5004));

            migrationBuilder.UpdateData(
                table: "PriceTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 7, 19, 19, 50, 859, DateTimeKind.Local).AddTicks(5026));

            migrationBuilder.UpdateData(
                table: "PriceTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 7, 19, 19, 50, 859, DateTimeKind.Local).AddTicks(5027));

            migrationBuilder.UpdateData(
                table: "ReservationsStates",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 7, 19, 19, 50, 860, DateTimeKind.Local).AddTicks(4118));

            migrationBuilder.UpdateData(
                table: "ReservationsStates",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 7, 19, 19, 50, 860, DateTimeKind.Local).AddTicks(4131));

            migrationBuilder.UpdateData(
                table: "ReservationsStates",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 7, 19, 19, 50, 860, DateTimeKind.Local).AddTicks(4132));

            migrationBuilder.UpdateData(
                table: "ReservationsStates",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 7, 19, 19, 50, 860, DateTimeKind.Local).AddTicks(4133));

            migrationBuilder.UpdateData(
                table: "ReservationsTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 7, 19, 19, 50, 860, DateTimeKind.Local).AddTicks(4951));

            migrationBuilder.UpdateData(
                table: "ReservationsTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 7, 19, 19, 50, 860, DateTimeKind.Local).AddTicks(4957));

            migrationBuilder.UpdateData(
                table: "RoomsStates",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 7, 19, 19, 50, 860, DateTimeKind.Local).AddTicks(9859));

            migrationBuilder.UpdateData(
                table: "RoomsStates",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 7, 19, 19, 50, 860, DateTimeKind.Local).AddTicks(9868));

            migrationBuilder.UpdateData(
                table: "RoomsStates",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 7, 19, 19, 50, 860, DateTimeKind.Local).AddTicks(9870));

            migrationBuilder.UpdateData(
                table: "RoomsStates",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 7, 19, 19, 50, 860, DateTimeKind.Local).AddTicks(9871));

            migrationBuilder.UpdateData(
                table: "RoomsTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 7, 19, 19, 50, 861, DateTimeKind.Local).AddTicks(478));

            migrationBuilder.UpdateData(
                table: "RoomsTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 7, 19, 19, 50, 861, DateTimeKind.Local).AddTicks(484));

            migrationBuilder.UpdateData(
                table: "RoomsTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 7, 19, 19, 50, 861, DateTimeKind.Local).AddTicks(485));

            migrationBuilder.UpdateData(
                table: "RoomsTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 7, 19, 19, 50, 861, DateTimeKind.Local).AddTicks(486));

            migrationBuilder.UpdateData(
                table: "RoomsTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 7, 19, 19, 50, 861, DateTimeKind.Local).AddTicks(487));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "023cb791-149c-4b9d-affd-c58ac5519a52");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3fc44bdb-0a82-43ae-bf5d-c8f1f676452e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a25ecc16-0dd0-4aaf-a545-7d63b7f7a367");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b74ce0eb-2a7a-4b5b-8b35-596c86958b27");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d013135d-aa50-4a64-acab-0bd462a51198");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d12536d9-5e60-4ba2-a33a-5f81d18006cd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "da74d179-d709-4950-9194-98ebab76c80c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f6f52ba0-f50f-41e4-a84d-c38d2899416d");

            migrationBuilder.DropColumn(
                name: "IsPayyed",
                table: "Reservations");

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
    }
}
