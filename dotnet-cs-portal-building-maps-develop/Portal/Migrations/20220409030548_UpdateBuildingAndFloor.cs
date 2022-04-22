using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KSU.CS.Portal.Migrations
{
    public partial class UpdateBuildingAndFloor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FloorLevel",
                table: "Floor",
                newName: "FloorString");

            migrationBuilder.AddColumn<int>(
                name: "FloorNumber",
                table: "Floor",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Slug",
                table: "Building",
                type: "TEXT",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Building",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "Slug", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 4, 8, 22, 5, 47, 158, DateTimeKind.Local).AddTicks(3099), "Anderson", new DateTime(2022, 4, 8, 22, 5, 47, 162, DateTimeKind.Local).AddTicks(6525) });

            migrationBuilder.InsertData(
                table: "Building",
                columns: new[] { "Id", "BuildingAbrev", "BuildingName", "CreatedOn", "Slug", "UpdatedOn", "X", "Y" },
                values: new object[] { 2, "ENGG", "Engineering Building", new DateTime(2022, 4, 8, 22, 5, 47, 162, DateTimeKind.Local).AddTicks(7349), "Engineering", new DateTime(2022, 4, 8, 22, 5, 47, 162, DateTimeKind.Local).AddTicks(7372), 0ul, 200ul });

            migrationBuilder.InsertData(
                table: "Building",
                columns: new[] { "Id", "BuildingAbrev", "BuildingName", "CreatedOn", "Slug", "UpdatedOn", "X", "Y" },
                values: new object[] { 3, "BB", "Business Building", new DateTime(2022, 4, 8, 22, 5, 47, 162, DateTimeKind.Local).AddTicks(7380), "Business", new DateTime(2022, 4, 8, 22, 5, 47, 162, DateTimeKind.Local).AddTicks(7386), 300ul, 400ul });

            migrationBuilder.UpdateData(
                table: "Floor",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "FloorMap", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 4, 8, 22, 5, 47, 164, DateTimeKind.Local).AddTicks(159), "Anderson_0.svg", new DateTime(2022, 4, 8, 22, 5, 47, 164, DateTimeKind.Local).AddTicks(164) });

            migrationBuilder.UpdateData(
                table: "Floor",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "FloorMap", "FloorNumber", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 4, 8, 22, 5, 47, 164, DateTimeKind.Local).AddTicks(148), "Anderson_1.svg", 1, new DateTime(2022, 4, 8, 22, 5, 47, 164, DateTimeKind.Local).AddTicks(152) });

            migrationBuilder.UpdateData(
                table: "Floor",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "FloorMap", "FloorNumber", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 4, 8, 22, 5, 47, 164, DateTimeKind.Local).AddTicks(131), "Anderson_2.svg", 2, new DateTime(2022, 4, 8, 22, 5, 47, 164, DateTimeKind.Local).AddTicks(142) });

            migrationBuilder.UpdateData(
                table: "Floor",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "FloorMap", "FloorNumber", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 4, 8, 22, 5, 47, 163, DateTimeKind.Local).AddTicks(9371), "Anderson_3.svg", 3, new DateTime(2022, 4, 8, 22, 5, 47, 163, DateTimeKind.Local).AddTicks(9778) });

            migrationBuilder.UpdateData(
                table: "Node",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 4, 8, 22, 5, 47, 163, DateTimeKind.Local).AddTicks(1232), new DateTime(2022, 4, 8, 22, 5, 47, 163, DateTimeKind.Local).AddTicks(1662) });

            migrationBuilder.UpdateData(
                table: "Node",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 4, 8, 22, 5, 47, 164, DateTimeKind.Local).AddTicks(519), new DateTime(2022, 4, 8, 22, 5, 47, 164, DateTimeKind.Local).AddTicks(527) });

            migrationBuilder.UpdateData(
                table: "Node",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 4, 8, 22, 5, 47, 164, DateTimeKind.Local).AddTicks(1932), new DateTime(2022, 4, 8, 22, 5, 47, 164, DateTimeKind.Local).AddTicks(1950) });

            migrationBuilder.InsertData(
                table: "Floor",
                columns: new[] { "Id", "BuildingId", "CreatedOn", "FloorMap", "FloorNumber", "FloorString", "UpdatedOn" },
                values: new object[] { 5, 2, new DateTime(2022, 4, 8, 22, 5, 47, 164, DateTimeKind.Local).AddTicks(169), "Engineering_0.svg", 0, "Basement", new DateTime(2022, 4, 8, 22, 5, 47, 164, DateTimeKind.Local).AddTicks(174) });

            migrationBuilder.InsertData(
                table: "Floor",
                columns: new[] { "Id", "BuildingId", "CreatedOn", "FloorMap", "FloorNumber", "FloorString", "UpdatedOn" },
                values: new object[] { 6, 2, new DateTime(2022, 4, 8, 22, 5, 47, 164, DateTimeKind.Local).AddTicks(179), "Engineering_1.svg", 1, "First", new DateTime(2022, 4, 8, 22, 5, 47, 164, DateTimeKind.Local).AddTicks(183) });

            migrationBuilder.InsertData(
                table: "Floor",
                columns: new[] { "Id", "BuildingId", "CreatedOn", "FloorMap", "FloorNumber", "FloorString", "UpdatedOn" },
                values: new object[] { 7, 2, new DateTime(2022, 4, 8, 22, 5, 47, 164, DateTimeKind.Local).AddTicks(188), "Engineering_2.svg", 2, "Second", new DateTime(2022, 4, 8, 22, 5, 47, 164, DateTimeKind.Local).AddTicks(192) });

            migrationBuilder.InsertData(
                table: "Floor",
                columns: new[] { "Id", "BuildingId", "CreatedOn", "FloorMap", "FloorNumber", "FloorString", "UpdatedOn" },
                values: new object[] { 8, 2, new DateTime(2022, 4, 8, 22, 5, 47, 164, DateTimeKind.Local).AddTicks(197), "Engineering_3.svg", 3, "Third", new DateTime(2022, 4, 8, 22, 5, 47, 164, DateTimeKind.Local).AddTicks(201) });

            migrationBuilder.InsertData(
                table: "Floor",
                columns: new[] { "Id", "BuildingId", "CreatedOn", "FloorMap", "FloorNumber", "FloorString", "UpdatedOn" },
                values: new object[] { 9, 3, new DateTime(2022, 4, 8, 22, 5, 47, 164, DateTimeKind.Local).AddTicks(206), "Business_0.svg", 0, "Basement", new DateTime(2022, 4, 8, 22, 5, 47, 164, DateTimeKind.Local).AddTicks(210) });

            migrationBuilder.InsertData(
                table: "Floor",
                columns: new[] { "Id", "BuildingId", "CreatedOn", "FloorMap", "FloorNumber", "FloorString", "UpdatedOn" },
                values: new object[] { 10, 3, new DateTime(2022, 4, 8, 22, 5, 47, 164, DateTimeKind.Local).AddTicks(216), "Business_1.svg", 1, "First", new DateTime(2022, 4, 8, 22, 5, 47, 164, DateTimeKind.Local).AddTicks(220) });

            migrationBuilder.InsertData(
                table: "Floor",
                columns: new[] { "Id", "BuildingId", "CreatedOn", "FloorMap", "FloorNumber", "FloorString", "UpdatedOn" },
                values: new object[] { 11, 3, new DateTime(2022, 4, 8, 22, 5, 47, 164, DateTimeKind.Local).AddTicks(227), "Business_2.svg", 2, "Second", new DateTime(2022, 4, 8, 22, 5, 47, 164, DateTimeKind.Local).AddTicks(232) });

            migrationBuilder.InsertData(
                table: "Floor",
                columns: new[] { "Id", "BuildingId", "CreatedOn", "FloorMap", "FloorNumber", "FloorString", "UpdatedOn" },
                values: new object[] { 12, 3, new DateTime(2022, 4, 8, 22, 5, 47, 164, DateTimeKind.Local).AddTicks(237), "Business_3.svg", 3, "Third", new DateTime(2022, 4, 8, 22, 5, 47, 164, DateTimeKind.Local).AddTicks(241) });

            migrationBuilder.InsertData(
                table: "Floor",
                columns: new[] { "Id", "BuildingId", "CreatedOn", "FloorMap", "FloorNumber", "FloorString", "UpdatedOn" },
                values: new object[] { 13, 3, new DateTime(2022, 4, 8, 22, 5, 47, 164, DateTimeKind.Local).AddTicks(246), "Business_4.svg", 4, "Fourth", new DateTime(2022, 4, 8, 22, 5, 47, 164, DateTimeKind.Local).AddTicks(250) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Floor",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Floor",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Floor",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Floor",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Floor",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Floor",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Floor",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Floor",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Floor",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Building",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Building",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "FloorNumber",
                table: "Floor");

            migrationBuilder.DropColumn(
                name: "Slug",
                table: "Building");

            migrationBuilder.RenameColumn(
                name: "FloorString",
                table: "Floor",
                newName: "FloorLevel");

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
                columns: new[] { "CreatedOn", "FloorMap", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 2, 28, 11, 27, 44, 671, DateTimeKind.Local).AddTicks(8489), "null", new DateTime(2022, 2, 28, 11, 27, 44, 671, DateTimeKind.Local).AddTicks(8491) });

            migrationBuilder.UpdateData(
                table: "Floor",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "FloorMap", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 2, 28, 11, 27, 44, 671, DateTimeKind.Local).AddTicks(8484), "null", new DateTime(2022, 2, 28, 11, 27, 44, 671, DateTimeKind.Local).AddTicks(8486) });

            migrationBuilder.UpdateData(
                table: "Floor",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "FloorMap", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 2, 28, 11, 27, 44, 671, DateTimeKind.Local).AddTicks(8474), "null", new DateTime(2022, 2, 28, 11, 27, 44, 671, DateTimeKind.Local).AddTicks(8481) });

            migrationBuilder.UpdateData(
                table: "Floor",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "FloorMap", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 2, 28, 11, 27, 44, 671, DateTimeKind.Local).AddTicks(8025), "null", new DateTime(2022, 2, 28, 11, 27, 44, 671, DateTimeKind.Local).AddTicks(8275) });

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
    }
}
