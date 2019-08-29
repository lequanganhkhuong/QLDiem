using Microsoft.EntityFrameworkCore.Migrations;

namespace MockProject.Migrations
{
    public partial class graduateUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsGraduated",
                table: "Users",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsGraduated",
                table: "Users");
        }
    }
}
