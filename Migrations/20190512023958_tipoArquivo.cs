using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoQualyteam.Migrations
{
    public partial class tipoArquivo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Tipo",
                table: "documento",
                nullable: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Tipo",
                table: "documento");
        }
    }
}
