using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BilgeHotel.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class ReservationEmployeeNull : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_AspNetUsers_EmployeId",
                table: "Reservations");

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

            migrationBuilder.AlterColumn<string>(
                name: "EmployeId",
                table: "Reservations",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_AspNetUsers_EmployeId",
                table: "Reservations",
                column: "EmployeId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_AspNetUsers_EmployeId",
                table: "Reservations");

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

            migrationBuilder.AlterColumn<string>(
                name: "EmployeId",
                table: "Reservations",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_AspNetUsers_EmployeId",
                table: "Reservations",
                column: "EmployeId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
