using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoQualyteam.Migrations
{
    public partial class RemoverTipo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Tipo",
                table: "documento");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Tipo",
                table: "documento",
                nullable: false,
                defaultValue: "");
        }
    }
}
