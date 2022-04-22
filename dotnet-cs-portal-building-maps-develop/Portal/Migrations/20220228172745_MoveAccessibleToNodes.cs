using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KSU.CS.Portal.Migrations
{
    public partial class MoveAccessibleToNodes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccessibleEnterance",
                table: "Door");

            migrationBuilder.AddColumn<bool>(
                name: "Accessible",
                table: "Node",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Building",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 2, 28, 11, 27, 44, 668, DateTimeKind.Local).AddTicks(8941), new DateTime(2022, 2, 28, 11, 27, 44, 671, DateTimeKind.Local).AddTicks(1012) });

            migrationBuilder.UpdateData(
                table: "Floor",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 2, 28, 11, 27, 44, 671, DateTimeKind.Local).AddTicks(8489), new DateTime(2022, 2, 28, 11, 27, 44, 671, DateTimeKind.Local).AddTicks(8491) });

            migrationBuilder.UpdateData(
                table: "Floor",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 2, 28, 11, 27, 44, 671, DateTimeKind.Local).AddTicks(8484), new DateTime(2022, 2, 28, 11, 27, 44, 671, DateTimeKind.Local).AddTicks(8486) });

            migrationBuilder.UpdateData(
                table: "Floor",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 2, 28, 11, 27, 44, 671, DateTimeKind.Local).AddTicks(8474), new DateTime(2022, 2, 28, 11, 27, 44, 671, DateTimeKind.Local).AddTicks(8481) });

            migrationBuilder.UpdateData(
                table: "Floor",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 2, 28, 11, 27, 44, 671, DateTimeKind.Local).AddTicks(8025), new DateTime(2022, 2, 28, 11, 27, 44, 671, DateTimeKind.Local).AddTicks(8275) });

            migrationBuilder.UpdateData(
                table: "Node",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 2, 28, 11, 27, 44, 671, DateTimeKind.Local).AddTicks(3361), new DateTime(2022, 2, 28, 11, 27, 44, 671, DateTimeKind.Local).AddTicks(3604) });

            migrationBuilder.UpdateData(
                table: "Node",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 2, 28, 11, 27, 44, 671, DateTimeKind.Local).AddTicks(8649), new DateTime(2022, 2, 28, 11, 27, 44, 671, DateTimeKind.Local).AddTicks(8653) });

            migrationBuilder.UpdateData(
                table: "Node",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 2, 28, 11, 27, 44, 671, DateTimeKind.Local).AddTicks(9566), new DateTime(2022, 2, 28, 11, 27, 44, 671, DateTimeKind.Local).AddTicks(9577) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Accessible",
                table: "Node");

            migrationBuilder.AddColumn<bool>(
                name: "AccessibleEnterance",
                table: "Door",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Building",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 2, 24, 16, 14, 10, 228, DateTimeKind.Local).AddTicks(6801), new DateTime(2022, 2, 24, 16, 14, 10, 231, DateTimeKind.Local).AddTicks(4125) });

            migrationBuilder.UpdateData(
                table: "Floor",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 2, 24, 16, 14, 10, 232, DateTimeKind.Local).AddTicks(3233), new DateTime(2022, 2, 24, 16, 14, 10, 232, DateTimeKind.Local).AddTicks(3237) });

            migrationBuilder.UpdateData(
                table: "Floor",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 2, 24, 16, 14, 10, 232, DateTimeKind.Local).AddTicks(3227), new DateTime(2022, 2, 24, 16, 14, 10, 232, DateTimeKind.Local).AddTicks(3230) });

            migrationBuilder.UpdateData(
                table: "Floor",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 2, 24, 16, 14, 10, 232, DateTimeKind.Local).AddTicks(3211), new DateTime(2022, 2, 24, 16, 14, 10, 232, DateTimeKind.Local).AddTicks(3223) });

            migrationBuilder.UpdateData(
                table: "Floor",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 2, 24, 16, 14, 10, 232, DateTimeKind.Local).AddTicks(2494), new DateTime(2022, 2, 24, 16, 14, 10, 232, DateTimeKind.Local).AddTicks(2795) });

            migrationBuilder.UpdateData(
                table: "Node",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 2, 24, 16, 14, 10, 231, DateTimeKind.Local).AddTicks(6910), new DateTime(2022, 2, 24, 16, 14, 10, 231, DateTimeKind.Local).AddTicks(7218) });

            migrationBuilder.UpdateData(
                table: "Node",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 2, 24, 16, 14, 10, 232, DateTimeKind.Local).AddTicks(3431), new DateTime(2022, 2, 24, 16, 14, 10, 232, DateTimeKind.Local).AddTicks(3436) });

            migrationBuilder.UpdateData(
                table: "Node",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 2, 24, 16, 14, 10, 232, DateTimeKind.Local).AddTicks(4472), new DateTime(2022, 2, 24, 16, 14, 10, 232, DateTimeKind.Local).AddTicks(4484) });
        }
    }
}
