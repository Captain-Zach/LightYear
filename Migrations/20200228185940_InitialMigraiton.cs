using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LightYear.Migrations
{
    public partial class InitialMigraiton : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Instances",
                columns: table => new
                {
                    GameId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    p1Turn = table.Column<bool>(nullable: false),
                    p2Turn = table.Column<bool>(nullable: false),
                    turnNumber = table.Column<int>(nullable: false),
                    p1Population = table.Column<int>(nullable: false),
                    p2Population = table.Column<int>(nullable: false),
                    p1Damage = table.Column<int>(nullable: false),
                    p2Damage = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instances", x => x.GameId);
                });

            migrationBuilder.CreateTable(
                name: "LightYearDebug",
                columns: table => new
                {
                    LightYearDebuggerId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    P1_Pop_lost_In_Turn = table.Column<int>(nullable: false),
                    P2_Pop_lost_In_Turn = table.Column<int>(nullable: false),
                    P1_Total_Ship_Kills = table.Column<int>(nullable: false),
                    P2_Total_Ship_Kills = table.Column<int>(nullable: false),
                    P1_Total_Pop_Lost = table.Column<int>(nullable: false),
                    P2_Total_Pop_Lost = table.Column<int>(nullable: false),
                    Total_Ships_Lost = table.Column<int>(nullable: false),
                    Total_Pop_Lost = table.Column<int>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LightYearDebug", x => x.LightYearDebuggerId);
                });

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    PlayerId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    PlayerState = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    LightYearDebuggerId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.PlayerId);
                    table.ForeignKey(
                        name: "FK_Players_LightYearDebug_LightYearDebuggerId",
                        column: x => x.LightYearDebuggerId,
                        principalTable: "LightYearDebug",
                        principalColumn: "LightYearDebuggerId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ships",
                columns: table => new
                {
                    ShipId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    GameId = table.Column<int>(nullable: false),
                    PlayerState = table.Column<int>(nullable: false),
                    Health = table.Column<int>(nullable: false),
                    Damage = table.Column<int>(nullable: false),
                    Cost = table.Column<int>(nullable: false),
                    LightYearDebuggerId = table.Column<int>(nullable: true),
                    LightYearDebuggerId1 = table.Column<int>(nullable: true),
                    LightYearDebuggerId2 = table.Column<int>(nullable: true),
                    LightYearDebuggerId3 = table.Column<int>(nullable: true),
                    LightYearDebuggerId4 = table.Column<int>(nullable: true),
                    PlayerId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ships", x => x.ShipId);
                    table.ForeignKey(
                        name: "FK_Ships_LightYearDebug_LightYearDebuggerId",
                        column: x => x.LightYearDebuggerId,
                        principalTable: "LightYearDebug",
                        principalColumn: "LightYearDebuggerId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ships_LightYearDebug_LightYearDebuggerId1",
                        column: x => x.LightYearDebuggerId1,
                        principalTable: "LightYearDebug",
                        principalColumn: "LightYearDebuggerId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ships_LightYearDebug_LightYearDebuggerId2",
                        column: x => x.LightYearDebuggerId2,
                        principalTable: "LightYearDebug",
                        principalColumn: "LightYearDebuggerId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ships_LightYearDebug_LightYearDebuggerId3",
                        column: x => x.LightYearDebuggerId3,
                        principalTable: "LightYearDebug",
                        principalColumn: "LightYearDebuggerId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ships_LightYearDebug_LightYearDebuggerId4",
                        column: x => x.LightYearDebuggerId4,
                        principalTable: "LightYearDebug",
                        principalColumn: "LightYearDebuggerId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ships_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "PlayerId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Players_LightYearDebuggerId",
                table: "Players",
                column: "LightYearDebuggerId");

            migrationBuilder.CreateIndex(
                name: "IX_Ships_LightYearDebuggerId",
                table: "Ships",
                column: "LightYearDebuggerId");

            migrationBuilder.CreateIndex(
                name: "IX_Ships_LightYearDebuggerId1",
                table: "Ships",
                column: "LightYearDebuggerId1");

            migrationBuilder.CreateIndex(
                name: "IX_Ships_LightYearDebuggerId2",
                table: "Ships",
                column: "LightYearDebuggerId2");

            migrationBuilder.CreateIndex(
                name: "IX_Ships_LightYearDebuggerId3",
                table: "Ships",
                column: "LightYearDebuggerId3");

            migrationBuilder.CreateIndex(
                name: "IX_Ships_LightYearDebuggerId4",
                table: "Ships",
                column: "LightYearDebuggerId4");

            migrationBuilder.CreateIndex(
                name: "IX_Ships_PlayerId",
                table: "Ships",
                column: "PlayerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Instances");

            migrationBuilder.DropTable(
                name: "Ships");

            migrationBuilder.DropTable(
                name: "Players");

            migrationBuilder.DropTable(
                name: "LightYearDebug");
        }
    }
}
