using Microsoft.EntityFrameworkCore.Migrations;

namespace WebBackEnd_Simbora.Migrations
{
    public partial class CpfEvent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CPF",
                table: "Eventos",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CPF",
                table: "Eventos");
        }
    }
}
