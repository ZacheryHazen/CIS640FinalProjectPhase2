using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KSU.CS.Portal.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Building",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BuildingName = table.Column<string>(type: "TEXT", nullable: true),
                    BuildingAbrev = table.Column<string>(type: "TEXT", nullable: true),
                    X = table.Column<ulong>(type: "INTEGER", nullable: false),
                    Y = table.Column<ulong>(type: "INTEGER", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Building", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PortalUser",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Eid = table.Column<string>(type: "TEXT", nullable: true),
                    LastName = table.Column<string>(type: "TEXT", nullable: true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: true),
                    Roles = table.Column<int>(type: "INTEGER", nullable: false),
                    IsStudent = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsTeachingAssistant = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsStaff = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsFaculty = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsAdmin = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PortalUser", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tag",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TagName = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tag", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Floor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FloorLevel = table.Column<string>(type: "TEXT", nullable: true),
                    BuildingId = table.Column<int>(type: "INTEGER", nullable: false),
                    FloorMap = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Floor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Floor_Building_BuildingId",
                        column: x => x.BuildingId,
                        principalTable: "Building",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Node",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    X = table.Column<ulong>(type: "INTEGER", nullable: false),
                    Y = table.Column<ulong>(type: "INTEGER", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    BuildingId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Node", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Node_Building_BuildingId",
                        column: x => x.BuildingId,
                        principalTable: "Building",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Door",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AccessibleEnterance = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Door", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Door_Node_Id",
                        column: x => x.Id,
                        principalTable: "Node",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Edge",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    StartNodeId = table.Column<int>(type: "INTEGER", nullable: false),
                    DestinationNodeId = table.Column<int>(type: "INTEGER", nullable: false),
                    BuildingId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Edge", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Edge_Building_BuildingId",
                        column: x => x.BuildingId,
                        principalTable: "Building",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Edge_Node_DestinationNodeId",
                        column: x => x.DestinationNodeId,
                        principalTable: "Node",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Edge_Node_StartNodeId",
                        column: x => x.StartNodeId,
                        principalTable: "Node",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Room",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoomNumber = table.Column<string>(type: "TEXT", nullable: true),
                    FloorId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Room", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Room_Floor_FloorId",
                        column: x => x.FloorId,
                        principalTable: "Floor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Room_Node_Id",
                        column: x => x.Id,
                        principalTable: "Node",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DoorHours",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DoorId = table.Column<int>(type: "INTEGER", nullable: false),
                    DayOfWeek = table.Column<byte>(type: "INTEGER", nullable: false),
                    OpenTime = table.Column<TimeSpan>(type: "TEXT", nullable: false),
                    CloseTime = table.Column<TimeSpan>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoorHours", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DoorHours_Door_DoorId",
                        column: x => x.DoorId,
                        principalTable: "Door",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoomTag",
                columns: table => new
                {
                    RoomId = table.Column<int>(type: "INTEGER", nullable: false),
                    TagId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomTag", x => new { x.RoomId, x.TagId });
                    table.ForeignKey(
                        name: "FK_RoomTag_Room_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Room",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoomTag_Tag_TagId",
                        column: x => x.TagId,
                        principalTable: "Tag",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Building",
                columns: new[] { "Id", "BuildingAbrev", "BuildingName", "CreatedOn", "UpdatedOn", "X", "Y" },
                values: new object[] { 1, "A", "Anderson Hall", new DateTime(2022, 2, 24, 16, 14, 10, 228, DateTimeKind.Local).AddTicks(6801), new DateTime(2022, 2, 24, 16, 14, 10, 231, DateTimeKind.Local).AddTicks(4125), 100ul, 300ul });

            migrationBuilder.InsertData(
                table: "PortalUser",
                columns: new[] { "Id", "Eid", "FirstName", "IsAdmin", "IsFaculty", "IsStaff", "IsStudent", "IsTeachingAssistant", "LastName", "Roles" },
                values: new object[] { 1, "nhbean", "Nathan", true, true, false, false, false, "Bean", 160 });

            migrationBuilder.InsertData(
                table: "PortalUser",
                columns: new[] { "Id", "Eid", "FirstName", "IsAdmin", "IsFaculty", "IsStaff", "IsStudent", "IsTeachingAssistant", "LastName", "Roles" },
                values: new object[] { 2, "russfeld", "Russ", true, true, false, false, false, "Feldhausen", 160 });

            migrationBuilder.InsertData(
                table: "PortalUser",
                columns: new[] { "Id", "Eid", "FirstName", "IsAdmin", "IsFaculty", "IsStaff", "IsStudent", "IsTeachingAssistant", "LastName", "Roles" },
                values: new object[] { 3, "weeser", "Josh", true, true, false, false, false, "Weese", 160 });

            migrationBuilder.InsertData(
                table: "Floor",
                columns: new[] { "Id", "BuildingId", "CreatedOn", "FloorLevel", "FloorMap", "UpdatedOn" },
                values: new object[] { 4, 1, new DateTime(2022, 2, 24, 16, 14, 10, 232, DateTimeKind.Local).AddTicks(2494), "Third", "null", new DateTime(2022, 2, 24, 16, 14, 10, 232, DateTimeKind.Local).AddTicks(2795) });

            migrationBuilder.InsertData(
                table: "Floor",
                columns: new[] { "Id", "BuildingId", "CreatedOn", "FloorLevel", "FloorMap", "UpdatedOn" },
                values: new object[] { 3, 1, new DateTime(2022, 2, 24, 16, 14, 10, 232, DateTimeKind.Local).AddTicks(3211), "Second", "null", new DateTime(2022, 2, 24, 16, 14, 10, 232, DateTimeKind.Local).AddTicks(3223) });

            migrationBuilder.InsertData(
                table: "Floor",
                columns: new[] { "Id", "BuildingId", "CreatedOn", "FloorLevel", "FloorMap", "UpdatedOn" },
                values: new object[] { 2, 1, new DateTime(2022, 2, 24, 16, 14, 10, 232, DateTimeKind.Local).AddTicks(3227), "First", "null", new DateTime(2022, 2, 24, 16, 14, 10, 232, DateTimeKind.Local).AddTicks(3230) });

            migrationBuilder.InsertData(
                table: "Floor",
                columns: new[] { "Id", "BuildingId", "CreatedOn", "FloorLevel", "FloorMap", "UpdatedOn" },
                values: new object[] { 1, 1, new DateTime(2022, 2, 24, 16, 14, 10, 232, DateTimeKind.Local).AddTicks(3233), "Basement", "null", new DateTime(2022, 2, 24, 16, 14, 10, 232, DateTimeKind.Local).AddTicks(3237) });

            migrationBuilder.InsertData(
                table: "Node",
                columns: new[] { "Id", "BuildingId", "CreatedOn", "UpdatedOn", "X", "Y" },
                values: new object[] { 3, 1, new DateTime(2022, 2, 24, 16, 14, 10, 231, DateTimeKind.Local).AddTicks(6910), new DateTime(2022, 2, 24, 16, 14, 10, 231, DateTimeKind.Local).AddTicks(7218), 400ul, 500ul });

            migrationBuilder.InsertData(
                table: "Node",
                columns: new[] { "Id", "BuildingId", "CreatedOn", "UpdatedOn", "X", "Y" },
                values: new object[] { 1, 1, new DateTime(2022, 2, 24, 16, 14, 10, 232, DateTimeKind.Local).AddTicks(3431), new DateTime(2022, 2, 24, 16, 14, 10, 232, DateTimeKind.Local).AddTicks(3436), 600ul, 600ul });

            migrationBuilder.InsertData(
                table: "Node",
                columns: new[] { "Id", "BuildingId", "CreatedOn", "UpdatedOn", "X", "Y" },
                values: new object[] { 2, 1, new DateTime(2022, 2, 24, 16, 14, 10, 232, DateTimeKind.Local).AddTicks(4472), new DateTime(2022, 2, 24, 16, 14, 10, 232, DateTimeKind.Local).AddTicks(4484), 500ul, 400ul });

            migrationBuilder.InsertData(
                table: "Door",
                columns: new[] { "Id", "AccessibleEnterance" },
                values: new object[] { 3, false });

            migrationBuilder.InsertData(
                table: "Edge",
                columns: new[] { "Id", "BuildingId", "DestinationNodeId", "StartNodeId" },
                values: new object[] { 1, 1, 3, 1 });

            migrationBuilder.InsertData(
                table: "Edge",
                columns: new[] { "Id", "BuildingId", "DestinationNodeId", "StartNodeId" },
                values: new object[] { 3, 1, 1, 3 });

            migrationBuilder.InsertData(
                table: "Edge",
                columns: new[] { "Id", "BuildingId", "DestinationNodeId", "StartNodeId" },
                values: new object[] { 2, 1, 2, 3 });

            migrationBuilder.InsertData(
                table: "Edge",
                columns: new[] { "Id", "BuildingId", "DestinationNodeId", "StartNodeId" },
                values: new object[] { 4, 1, 3, 2 });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "Id", "FloorId", "RoomNumber" },
                values: new object[] { 2, 4, "A308" });

            migrationBuilder.InsertData(
                table: "DoorHours",
                columns: new[] { "Id", "CloseTime", "DayOfWeek", "DoorId", "OpenTime" },
                values: new object[] { 1, new TimeSpan(0, 17, 15, 0, 0), (byte)0, 3, new TimeSpan(0, 8, 0, 0, 0) });

            migrationBuilder.InsertData(
                table: "DoorHours",
                columns: new[] { "Id", "CloseTime", "DayOfWeek", "DoorId", "OpenTime" },
                values: new object[] { 2, new TimeSpan(0, 17, 15, 0, 0), (byte)1, 3, new TimeSpan(0, 8, 0, 0, 0) });

            migrationBuilder.InsertData(
                table: "DoorHours",
                columns: new[] { "Id", "CloseTime", "DayOfWeek", "DoorId", "OpenTime" },
                values: new object[] { 3, new TimeSpan(0, 17, 15, 0, 0), (byte)2, 3, new TimeSpan(0, 8, 0, 0, 0) });

            migrationBuilder.InsertData(
                table: "DoorHours",
                columns: new[] { "Id", "CloseTime", "DayOfWeek", "DoorId", "OpenTime" },
                values: new object[] { 4, new TimeSpan(0, 17, 15, 0, 0), (byte)3, 3, new TimeSpan(0, 8, 0, 0, 0) });

            migrationBuilder.InsertData(
                table: "DoorHours",
                columns: new[] { "Id", "CloseTime", "DayOfWeek", "DoorId", "OpenTime" },
                values: new object[] { 5, new TimeSpan(0, 17, 15, 0, 0), (byte)4, 3, new TimeSpan(0, 8, 0, 0, 0) });

            migrationBuilder.InsertData(
                table: "DoorHours",
                columns: new[] { "Id", "CloseTime", "DayOfWeek", "DoorId", "OpenTime" },
                values: new object[] { 6, new TimeSpan(0, 17, 15, 0, 0), (byte)5, 3, new TimeSpan(0, 8, 0, 0, 0) });

            migrationBuilder.InsertData(
                table: "DoorHours",
                columns: new[] { "Id", "CloseTime", "DayOfWeek", "DoorId", "OpenTime" },
                values: new object[] { 7, new TimeSpan(0, 17, 15, 0, 0), (byte)6, 3, new TimeSpan(0, 8, 0, 0, 0) });

            migrationBuilder.CreateIndex(
                name: "IX_DoorHours_DoorId",
                table: "DoorHours",
                column: "DoorId");

            migrationBuilder.CreateIndex(
                name: "IX_Edge_BuildingId",
                table: "Edge",
                column: "BuildingId");

            migrationBuilder.CreateIndex(
                name: "IX_Edge_DestinationNodeId",
                table: "Edge",
                column: "DestinationNodeId");

            migrationBuilder.CreateIndex(
                name: "IX_Edge_StartNodeId",
                table: "Edge",
                column: "StartNodeId");

            migrationBuilder.CreateIndex(
                name: "IX_Floor_BuildingId",
                table: "Floor",
                column: "BuildingId");

            migrationBuilder.CreateIndex(
                name: "IX_Node_BuildingId",
                table: "Node",
                column: "BuildingId");

            migrationBuilder.CreateIndex(
                name: "IX_PortalUser_Eid",
                table: "PortalUser",
                column: "Eid",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Room_FloorId",
                table: "Room",
                column: "FloorId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomTag_TagId",
                table: "RoomTag",
                column: "TagId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DoorHours");

            migrationBuilder.DropTable(
                name: "Edge");

            migrationBuilder.DropTable(
                name: "PortalUser");

            migrationBuilder.DropTable(
                name: "RoomTag");

            migrationBuilder.DropTable(
                name: "Door");

            migrationBuilder.DropTable(
                name: "Room");

            migrationBuilder.DropTable(
                name: "Tag");

            migrationBuilder.DropTable(
                name: "Floor");

            migrationBuilder.DropTable(
                name: "Node");

            migrationBuilder.DropTable(
                name: "Building");
        }
    }
}
