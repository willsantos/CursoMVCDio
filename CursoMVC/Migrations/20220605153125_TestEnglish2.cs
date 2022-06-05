using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CursoMVC.Migrations
{
    public partial class TestEnglish2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "SkipDetectChanges",
                table: "Categorias",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SkipDetectChanges",
                table: "Categorias");
        }
    }
}
