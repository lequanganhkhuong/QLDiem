using Microsoft.EntityFrameworkCore.Migrations;

namespace MockProject.Migrations
{
    public partial class Validation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsPassed",
                table: "Transcripts",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsPassed",
                table: "Transcripts",
                nullable: true,
                oldClrType: typeof(bool));
        }
    }
}
