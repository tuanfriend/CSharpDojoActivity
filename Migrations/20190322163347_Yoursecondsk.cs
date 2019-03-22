using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BeltExamCSharp.Migrations
{
    public partial class Yoursecondsk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ActConnects_Activitys_ActivityId",
                table: "ActConnects");

            migrationBuilder.DropTable(
                name: "Activitys");

            migrationBuilder.CreateTable(
                name: "NewActivitys",
                columns: table => new
                {
                    ActivityId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: false),
                    Time = table.Column<string>(nullable: false),
                    ActDate = table.Column<DateTime>(nullable: false),
                    Duration = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false),
                    Created_at = table.Column<DateTime>(nullable: false),
                    Updated_at = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewActivitys", x => x.ActivityId);
                    table.ForeignKey(
                        name: "FK_NewActivitys_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_NewActivitys_UserId",
                table: "NewActivitys",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ActConnects_NewActivitys_ActivityId",
                table: "ActConnects",
                column: "ActivityId",
                principalTable: "NewActivitys",
                principalColumn: "ActivityId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ActConnects_NewActivitys_ActivityId",
                table: "ActConnects");

            migrationBuilder.DropTable(
                name: "NewActivitys");

            migrationBuilder.CreateTable(
                name: "Activitys",
                columns: table => new
                {
                    ActivityId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ActDate = table.Column<DateTime>(nullable: false),
                    Created_at = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Duration = table.Column<int>(nullable: false),
                    Time = table.Column<string>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    Updated_at = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activitys", x => x.ActivityId);
                    table.ForeignKey(
                        name: "FK_Activitys_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Activitys_UserId",
                table: "Activitys",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ActConnects_Activitys_ActivityId",
                table: "ActConnects",
                column: "ActivityId",
                principalTable: "Activitys",
                principalColumn: "ActivityId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
