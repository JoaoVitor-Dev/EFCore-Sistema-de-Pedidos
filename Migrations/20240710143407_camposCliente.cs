using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreSistemaDePedidos.Migrations
{
    /// <inheritdoc />
    public partial class camposCliente : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Clientes",
                type: "VARCHAR(80)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Clientes");
        }
    }
}
