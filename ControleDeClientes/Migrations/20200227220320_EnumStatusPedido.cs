using Microsoft.EntityFrameworkCore.Migrations;

namespace ControleDeClientes.Migrations
{
    public partial class EnumStatusPedido : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Pedidos",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Pedidos");
        }
    }
}
