using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FlashTest.Migrations
{
    public partial class DisplayNumberHistory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DisplayNumberHistories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    InputNumber = table.Column<int>(nullable: false),
                    OutputResult = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DisplayNumberHistories", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DisplayNumberHistories");
        }
    }
}
