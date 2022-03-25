using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace ZeissEmpMgmt.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmpId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 25, 1, 12, 0, 223, DateTimeKind.Local).AddTicks(7794));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmpId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 25, 1, 12, 0, 224, DateTimeKind.Local).AddTicks(9266));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmpId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 25, 1, 12, 0, 224, DateTimeKind.Local).AddTicks(9335));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmpId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 25, 1, 12, 0, 224, DateTimeKind.Local).AddTicks(9338));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmpId",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 25, 1, 12, 0, 224, DateTimeKind.Local).AddTicks(9340));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmpId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 25, 1, 4, 13, 913, DateTimeKind.Local).AddTicks(297));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmpId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 25, 1, 4, 13, 914, DateTimeKind.Local).AddTicks(2126));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmpId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 25, 1, 4, 13, 914, DateTimeKind.Local).AddTicks(2189));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmpId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 25, 1, 4, 13, 914, DateTimeKind.Local).AddTicks(2192));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmpId",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 25, 1, 4, 13, 914, DateTimeKind.Local).AddTicks(2194));
        }
    }
}
