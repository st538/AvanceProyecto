using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmpresaPedidos.API.Migrations
{
    /// <inheritdoc />
    public partial class v02 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pedido_Clientes_ClientesId",
                table: "Pedido");

            migrationBuilder.AlterColumn<int>(
                name: "ClientesId",
                table: "Pedido",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddForeignKey(
                name: "FK_Pedido_Clientes_ClientesId",
                table: "Pedido",
                column: "ClientesId",
                principalTable: "Clientes",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pedido_Clientes_ClientesId",
                table: "Pedido");

            migrationBuilder.AlterColumn<int>(
                name: "ClientesId",
                table: "Pedido",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Pedido_Clientes_ClientesId",
                table: "Pedido",
                column: "ClientesId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
