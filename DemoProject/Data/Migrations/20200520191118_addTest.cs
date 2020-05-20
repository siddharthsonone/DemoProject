using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DemoProject.Data.Migrations
{
    public partial class addTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Test",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Feature = table.Column<string>(nullable: false),
                    TestCase = table.Column<string>(nullable: true),
                    Expected = table.Column<string>(nullable: true),
                    Observed = table.Column<string>(nullable: true),
                    Result = table.Column<string>(nullable: true),
                    LastExecuted = table.Column<DateTime>(nullable: false),
                    Notes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Test", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Test");
        }
    }
}
