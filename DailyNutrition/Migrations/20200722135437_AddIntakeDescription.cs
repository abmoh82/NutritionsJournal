using Microsoft.EntityFrameworkCore.Migrations;

namespace DailyNutrition.Migrations
{
    public partial class AddIntakeDescription : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "D_Vitamin_Intake",
                table: "Schemas",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Schemas",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "D_Vitamin_Intake",
                table: "Schemas");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Schemas");
        }
    }
}
