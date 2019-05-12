using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoQualyteam.Migrations
{
    public partial class nomeArquivo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Nome",
                table: "documento",
                nullable: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nome",
                table: "documento");
        }
    }
}
