using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DailyNutrition.Migrations
{
    public partial class breakfast : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Breakfast",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    Portion = table.Column<double>(nullable: false),
                    Beverage = table.Column<string>(nullable: true),
                    Volym = table.Column<int>(nullable: false),
                    D_Vitamin_Intake = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Breakfast", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Breakfast");
        }
    }
}
