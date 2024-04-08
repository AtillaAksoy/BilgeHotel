using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BilgeHotel.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class ReservationStateSomeAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "323a4f0c-41e5-402f-9fff-4654ffd8c4d5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "452b4ffd-9db8-4125-b349-ec2ad77bd2d7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "62d199ca-66aa-40d1-be2a-fd6911530471");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "78b4d3bc-f20c-48ee-a936-3ed74dd4fc68");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8c9b7ac2-dbf3-435a-8eb6-efe2cd560660");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c9fb2f4e-d9fd-4492-aa88-9a3e65890ed3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e30d0045-d56f-4a22-ab5d-99affb84cbca");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e96f4de5-e5b1-46a2-9593-bbd55c64644c");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "EmployeeId", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0421cd79-aded-4ed9-83cb-ff2a4f600bc7", null, null, "Admin", null },
                    { "0e99a3ea-8766-41fa-81ce-18404d27ab09", null, null, "Elektrikçi", null },
                    { "31f0d778-5841-4d1e-ae3a-9ef45408df63", null, null, "Resepsiyon görevlisi", null },
                    { "80d0101f-5679-4709-85b4-58ed47976100", null, null, "Yönetim", null },
                    { "9a8aaae6-e99f-4d37-aa2b-661b7e55d509", null, null, "Bilgi işlem sorumlusu", null },
                    { "cc9f54ef-46ea-42e0-ad1e-981794f28dd2", null, null, "Temizlik görevlisi", null },
                    { "ce293218-7d18-46dc-b65c-360836e78d5b", null, null, "Aşçı", null },
                    { "e37868b4-7c7d-411d-8876-0c918e1551a9", null, null, "Garson", null }
                });

            migrationBuilder.UpdateData(
                table: "PriceTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 8, 0, 20, 32, 669, DateTimeKind.Local).AddTicks(3146));

            migrationBuilder.UpdateData(
                table: "PriceTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 8, 0, 20, 32, 669, DateTimeKind.Local).AddTicks(3165));

            migrationBuilder.UpdateData(
                table: "PriceTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 8, 0, 20, 32, 669, DateTimeKind.Local).AddTicks(3166));

            migrationBuilder.UpdateData(
                table: "ReservationsStates",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 8, 0, 20, 32, 669, DateTimeKind.Local).AddTicks(8482));

            migrationBuilder.UpdateData(
                table: "ReservationsStates",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 8, 0, 20, 32, 669, DateTimeKind.Local).AddTicks(8491));

            migrationBuilder.UpdateData(
                table: "ReservationsStates",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 8, 0, 20, 32, 669, DateTimeKind.Local).AddTicks(8492));

            migrationBuilder.UpdateData(
                table: "ReservationsStates",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 8, 0, 20, 32, 669, DateTimeKind.Local).AddTicks(8494));

            migrationBuilder.InsertData(
                table: "ReservationsStates",
                columns: new[] { "Id", "CreatedDate", "Description", "IsDeleted", "IsPassive", "StateName", "UpdatedDate" },
                values: new object[,]
                {
                    { 5, new DateTime(2024, 4, 8, 0, 20, 32, 669, DateTimeKind.Local).AddTicks(8494), "Ödeme almayı unutmayınız", false, false, "Başladı ödeme alınmadı", null },
                    { 6, new DateTime(2024, 4, 8, 0, 20, 32, 669, DateTimeKind.Local).AddTicks(8497), "durum tamamlandıya çevrilebilir", false, false, "Başladı ödeme alındı", null }
                });

            migrationBuilder.UpdateData(
                table: "ReservationsTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 8, 0, 20, 32, 669, DateTimeKind.Local).AddTicks(9214));

            migrationBuilder.UpdateData(
                table: "ReservationsTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 8, 0, 20, 32, 669, DateTimeKind.Local).AddTicks(9220));

            migrationBuilder.UpdateData(
                table: "RoomsStates",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 8, 0, 20, 32, 670, DateTimeKind.Local).AddTicks(3138));

            migrationBuilder.UpdateData(
                table: "RoomsStates",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 8, 0, 20, 32, 670, DateTimeKind.Local).AddTicks(3147));

            migrationBuilder.UpdateData(
                table: "RoomsStates",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 8, 0, 20, 32, 670, DateTimeKind.Local).AddTicks(3148));

            migrationBuilder.UpdateData(
                table: "RoomsStates",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 8, 0, 20, 32, 670, DateTimeKind.Local).AddTicks(3149));

            migrationBuilder.UpdateData(
                table: "RoomsTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 8, 0, 20, 32, 670, DateTimeKind.Local).AddTicks(4059));

            migrationBuilder.UpdateData(
                table: "RoomsTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 8, 0, 20, 32, 670, DateTimeKind.Local).AddTicks(4066));

            migrationBuilder.UpdateData(
                table: "RoomsTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 8, 0, 20, 32, 670, DateTimeKind.Local).AddTicks(4068));

            migrationBuilder.UpdateData(
                table: "RoomsTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 8, 0, 20, 32, 670, DateTimeKind.Local).AddTicks(4069));

            migrationBuilder.UpdateData(
                table: "RoomsTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 8, 0, 20, 32, 670, DateTimeKind.Local).AddTicks(4071));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0421cd79-aded-4ed9-83cb-ff2a4f600bc7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0e99a3ea-8766-41fa-81ce-18404d27ab09");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "31f0d778-5841-4d1e-ae3a-9ef45408df63");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "80d0101f-5679-4709-85b4-58ed47976100");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9a8aaae6-e99f-4d37-aa2b-661b7e55d509");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cc9f54ef-46ea-42e0-ad1e-981794f28dd2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ce293218-7d18-46dc-b65c-360836e78d5b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e37868b4-7c7d-411d-8876-0c918e1551a9");

            migrationBuilder.DeleteData(
                table: "ReservationsStates",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ReservationsStates",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "EmployeeId", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "323a4f0c-41e5-402f-9fff-4654ffd8c4d5", null, null, "Bilgi işlem sorumlusu", null },
                    { "452b4ffd-9db8-4125-b349-ec2ad77bd2d7", null, null, "Resepsiyon görevlisi", null },
                    { "62d199ca-66aa-40d1-be2a-fd6911530471", null, null, "Aşçı", null },
                    { "78b4d3bc-f20c-48ee-a936-3ed74dd4fc68", null, null, "Yönetim", null },
                    { "8c9b7ac2-dbf3-435a-8eb6-efe2cd560660", null, null, "Admin", null },
                    { "c9fb2f4e-d9fd-4492-aa88-9a3e65890ed3", null, null, "Temizlik görevlisi", null },
                    { "e30d0045-d56f-4a22-ab5d-99affb84cbca", null, null, "Garson", null },
                    { "e96f4de5-e5b1-46a2-9593-bbd55c64644c", null, null, "Elektrikçi", null }
                });

            migrationBuilder.UpdateData(
                table: "PriceTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 8, 0, 12, 13, 728, DateTimeKind.Local).AddTicks(5990));

            migrationBuilder.UpdateData(
                table: "PriceTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 8, 0, 12, 13, 728, DateTimeKind.Local).AddTicks(6014));

            migrationBuilder.UpdateData(
                table: "PriceTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 8, 0, 12, 13, 728, DateTimeKind.Local).AddTicks(6016));

            migrationBuilder.UpdateData(
                table: "ReservationsStates",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 8, 0, 12, 13, 729, DateTimeKind.Local).AddTicks(3187));

            migrationBuilder.UpdateData(
                table: "ReservationsStates",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 8, 0, 12, 13, 729, DateTimeKind.Local).AddTicks(3203));

            migrationBuilder.UpdateData(
                table: "ReservationsStates",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 8, 0, 12, 13, 729, DateTimeKind.Local).AddTicks(3206));

            migrationBuilder.UpdateData(
                table: "ReservationsStates",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 8, 0, 12, 13, 729, DateTimeKind.Local).AddTicks(3207));

            migrationBuilder.UpdateData(
                table: "ReservationsTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 8, 0, 12, 13, 729, DateTimeKind.Local).AddTicks(4108));

            migrationBuilder.UpdateData(
                table: "ReservationsTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 8, 0, 12, 13, 729, DateTimeKind.Local).AddTicks(4116));

            migrationBuilder.UpdateData(
                table: "RoomsStates",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 8, 0, 12, 13, 729, DateTimeKind.Local).AddTicks(8879));

            migrationBuilder.UpdateData(
                table: "RoomsStates",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 8, 0, 12, 13, 729, DateTimeKind.Local).AddTicks(8892));

            migrationBuilder.UpdateData(
                table: "RoomsStates",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 8, 0, 12, 13, 729, DateTimeKind.Local).AddTicks(8895));

            migrationBuilder.UpdateData(
                table: "RoomsStates",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 8, 0, 12, 13, 729, DateTimeKind.Local).AddTicks(8896));

            migrationBuilder.UpdateData(
                table: "RoomsTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 8, 0, 12, 13, 729, DateTimeKind.Local).AddTicks(9722));

            migrationBuilder.UpdateData(
                table: "RoomsTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 8, 0, 12, 13, 729, DateTimeKind.Local).AddTicks(9727));

            migrationBuilder.UpdateData(
                table: "RoomsTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 8, 0, 12, 13, 729, DateTimeKind.Local).AddTicks(9728));

            migrationBuilder.UpdateData(
                table: "RoomsTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 8, 0, 12, 13, 729, DateTimeKind.Local).AddTicks(9730));

            migrationBuilder.UpdateData(
                table: "RoomsTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 8, 0, 12, 13, 729, DateTimeKind.Local).AddTicks(9731));
        }
    }
}
