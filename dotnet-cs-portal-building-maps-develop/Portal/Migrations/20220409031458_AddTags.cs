using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KSU.CS.Portal.Migrations
{
    public partial class AddTags : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Building",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 4, 8, 22, 14, 54, 500, DateTimeKind.Local).AddTicks(5455), new DateTime(2022, 4, 8, 22, 14, 54, 530, DateTimeKind.Local).AddTicks(8991) });

            migrationBuilder.UpdateData(
                table: "Building",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 4, 8, 22, 14, 54, 531, DateTimeKind.Local).AddTicks(1544), new DateTime(2022, 4, 8, 22, 14, 54, 531, DateTimeKind.Local).AddTicks(1619) });

            migrationBuilder.UpdateData(
                table: "Building",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 4, 8, 22, 14, 54, 531, DateTimeKind.Local).AddTicks(1641), new DateTime(2022, 4, 8, 22, 14, 54, 531, DateTimeKind.Local).AddTicks(1653) });

            migrationBuilder.UpdateData(
                table: "Floor",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 4, 8, 22, 14, 54, 546, DateTimeKind.Local).AddTicks(4828), new DateTime(2022, 4, 8, 22, 14, 54, 546, DateTimeKind.Local).AddTicks(4841) });

            migrationBuilder.UpdateData(
                table: "Floor",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 4, 8, 22, 14, 54, 546, DateTimeKind.Local).AddTicks(4795), new DateTime(2022, 4, 8, 22, 14, 54, 546, DateTimeKind.Local).AddTicks(4811) });

            migrationBuilder.UpdateData(
                table: "Floor",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 4, 8, 22, 14, 54, 546, DateTimeKind.Local).AddTicks(4624), new DateTime(2022, 4, 8, 22, 14, 54, 546, DateTimeKind.Local).AddTicks(4773) });

            migrationBuilder.UpdateData(
                table: "Floor",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 4, 8, 22, 14, 54, 544, DateTimeKind.Local).AddTicks(6357), new DateTime(2022, 4, 8, 22, 14, 54, 545, DateTimeKind.Local).AddTicks(7505) });

            migrationBuilder.UpdateData(
                table: "Floor",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 4, 8, 22, 14, 54, 546, DateTimeKind.Local).AddTicks(4856), new DateTime(2022, 4, 8, 22, 14, 54, 546, DateTimeKind.Local).AddTicks(4873) });

            migrationBuilder.UpdateData(
                table: "Floor",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 4, 8, 22, 14, 54, 546, DateTimeKind.Local).AddTicks(4888), new DateTime(2022, 4, 8, 22, 14, 54, 546, DateTimeKind.Local).AddTicks(4901) });

            migrationBuilder.UpdateData(
                table: "Floor",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 4, 8, 22, 14, 54, 546, DateTimeKind.Local).AddTicks(4916), new DateTime(2022, 4, 8, 22, 14, 54, 546, DateTimeKind.Local).AddTicks(4928) });

            migrationBuilder.UpdateData(
                table: "Floor",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 4, 8, 22, 14, 54, 546, DateTimeKind.Local).AddTicks(4943), new DateTime(2022, 4, 8, 22, 14, 54, 546, DateTimeKind.Local).AddTicks(4956) });

            migrationBuilder.UpdateData(
                table: "Floor",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 4, 8, 22, 14, 54, 546, DateTimeKind.Local).AddTicks(4971), new DateTime(2022, 4, 8, 22, 14, 54, 546, DateTimeKind.Local).AddTicks(4984) });

            migrationBuilder.UpdateData(
                table: "Floor",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 4, 8, 22, 14, 54, 546, DateTimeKind.Local).AddTicks(4998), new DateTime(2022, 4, 8, 22, 14, 54, 546, DateTimeKind.Local).AddTicks(5011) });

            migrationBuilder.UpdateData(
                table: "Floor",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 4, 8, 22, 14, 54, 546, DateTimeKind.Local).AddTicks(5027), new DateTime(2022, 4, 8, 22, 14, 54, 546, DateTimeKind.Local).AddTicks(5039) });

            migrationBuilder.UpdateData(
                table: "Floor",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 4, 8, 22, 14, 54, 546, DateTimeKind.Local).AddTicks(5054), new DateTime(2022, 4, 8, 22, 14, 54, 546, DateTimeKind.Local).AddTicks(5068) });

            migrationBuilder.UpdateData(
                table: "Floor",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 4, 8, 22, 14, 54, 546, DateTimeKind.Local).AddTicks(5083), new DateTime(2022, 4, 8, 22, 14, 54, 546, DateTimeKind.Local).AddTicks(5096) });

            migrationBuilder.UpdateData(
                table: "Node",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 4, 8, 22, 14, 54, 534, DateTimeKind.Local).AddTicks(2492), new DateTime(2022, 4, 8, 22, 14, 54, 534, DateTimeKind.Local).AddTicks(5466) });

            migrationBuilder.UpdateData(
                table: "Node",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 4, 8, 22, 14, 54, 546, DateTimeKind.Local).AddTicks(7441), new DateTime(2022, 4, 8, 22, 14, 54, 546, DateTimeKind.Local).AddTicks(7480) });

            migrationBuilder.UpdateData(
                table: "Node",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 4, 8, 22, 14, 54, 548, DateTimeKind.Local).AddTicks(4912), new DateTime(2022, 4, 8, 22, 14, 54, 548, DateTimeKind.Local).AddTicks(5083) });

            migrationBuilder.InsertData(
                table: "Tag",
                columns: new[] { "Id", "TagName" },
                values: new object[] { 5, "Computer Lab" });

            migrationBuilder.InsertData(
                table: "Tag",
                columns: new[] { "Id", "TagName" },
                values: new object[] { 4, "Study Room" });

            migrationBuilder.InsertData(
                table: "Tag",
                columns: new[] { "Id", "TagName" },
                values: new object[] { 3, "Classroom" });

            migrationBuilder.InsertData(
                table: "Tag",
                columns: new[] { "Id", "TagName" },
                values: new object[] { 2, "Office" });

            migrationBuilder.InsertData(
                table: "Tag",
                columns: new[] { "Id", "TagName" },
                values: new object[] { 6, "Conference Room" });

            migrationBuilder.InsertData(
                table: "Tag",
                columns: new[] { "Id", "TagName" },
                values: new object[] { 1, "Bathroom" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tag",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tag",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tag",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tag",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Tag",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Tag",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "Building",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 4, 8, 22, 5, 47, 158, DateTimeKind.Local).AddTicks(3099), new DateTime(2022, 4, 8, 22, 5, 47, 162, DateTimeKind.Local).AddTicks(6525) });

            migrationBuilder.UpdateData(
                table: "Building",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 4, 8, 22, 5, 47, 162, DateTimeKind.Local).AddTicks(7349), new DateTime(2022, 4, 8, 22, 5, 47, 162, DateTimeKind.Local).AddTicks(7372) });

            migrationBuilder.UpdateData(
                table: "Building",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 4, 8, 22, 5, 47, 162, DateTimeKind.Local).AddTicks(7380), new DateTime(2022, 4, 8, 22, 5, 47, 162, DateTimeKind.Local).AddTicks(7386) });

            migrationBuilder.UpdateData(
                table: "Floor",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 4, 8, 22, 5, 47, 164, DateTimeKind.Local).AddTicks(159), new DateTime(2022, 4, 8, 22, 5, 47, 164, DateTimeKind.Local).AddTicks(164) });

            migrationBuilder.UpdateData(
                table: "Floor",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 4, 8, 22, 5, 47, 164, DateTimeKind.Local).AddTicks(148), new DateTime(2022, 4, 8, 22, 5, 47, 164, DateTimeKind.Local).AddTicks(152) });

            migrationBuilder.UpdateData(
                table: "Floor",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 4, 8, 22, 5, 47, 164, DateTimeKind.Local).AddTicks(131), new DateTime(2022, 4, 8, 22, 5, 47, 164, DateTimeKind.Local).AddTicks(142) });

            migrationBuilder.UpdateData(
                table: "Floor",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 4, 8, 22, 5, 47, 163, DateTimeKind.Local).AddTicks(9371), new DateTime(2022, 4, 8, 22, 5, 47, 163, DateTimeKind.Local).AddTicks(9778) });

            migrationBuilder.UpdateData(
                table: "Floor",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 4, 8, 22, 5, 47, 164, DateTimeKind.Local).AddTicks(169), new DateTime(2022, 4, 8, 22, 5, 47, 164, DateTimeKind.Local).AddTicks(174) });

            migrationBuilder.UpdateData(
                table: "Floor",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 4, 8, 22, 5, 47, 164, DateTimeKind.Local).AddTicks(179), new DateTime(2022, 4, 8, 22, 5, 47, 164, DateTimeKind.Local).AddTicks(183) });

            migrationBuilder.UpdateData(
                table: "Floor",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 4, 8, 22, 5, 47, 164, DateTimeKind.Local).AddTicks(188), new DateTime(2022, 4, 8, 22, 5, 47, 164, DateTimeKind.Local).AddTicks(192) });

            migrationBuilder.UpdateData(
                table: "Floor",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 4, 8, 22, 5, 47, 164, DateTimeKind.Local).AddTicks(197), new DateTime(2022, 4, 8, 22, 5, 47, 164, DateTimeKind.Local).AddTicks(201) });

            migrationBuilder.UpdateData(
                table: "Floor",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 4, 8, 22, 5, 47, 164, DateTimeKind.Local).AddTicks(206), new DateTime(2022, 4, 8, 22, 5, 47, 164, DateTimeKind.Local).AddTicks(210) });

            migrationBuilder.UpdateData(
                table: "Floor",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 4, 8, 22, 5, 47, 164, DateTimeKind.Local).AddTicks(216), new DateTime(2022, 4, 8, 22, 5, 47, 164, DateTimeKind.Local).AddTicks(220) });

            migrationBuilder.UpdateData(
                table: "Floor",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 4, 8, 22, 5, 47, 164, DateTimeKind.Local).AddTicks(227), new DateTime(2022, 4, 8, 22, 5, 47, 164, DateTimeKind.Local).AddTicks(232) });

            migrationBuilder.UpdateData(
                table: "Floor",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 4, 8, 22, 5, 47, 164, DateTimeKind.Local).AddTicks(237), new DateTime(2022, 4, 8, 22, 5, 47, 164, DateTimeKind.Local).AddTicks(241) });

            migrationBuilder.UpdateData(
                table: "Floor",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2022, 4, 8, 22, 5, 47, 164, DateTimeKind.Local).AddTicks(246), new DateTime(2022, 4, 8, 22, 5, 47, 164, DateTimeKind.Local).AddTicks(250) });

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
        }
    }
}
