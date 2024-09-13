using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanchesMac.Migrations
{
    public partial class CarrinhoCompraItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "DescriptionDetail",
                table: "Lanches",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(80)",
                oldMaxLength: 80);

            migrationBuilder.CreateTable(
                name: "CarrinhoCompraItens",
                columns: table => new
                {
                    CarrinhoCompraItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LancheId = table.Column<int>(type: "int", nullable: true),
                    Quantidade = table.Column<int>(type: "int", nullable: false),
                    CarrinhoCompraId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarrinhoCompraItens", x => x.CarrinhoCompraItemId);
                    table.ForeignKey(
                        name: "FK_CarrinhoCompraItens_Lanches_LancheId",
                        column: x => x.LancheId,
                        principalTable: "Lanches",
                        principalColumn: "LancheId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CarrinhoCompraItens_LancheId",
                table: "CarrinhoCompraItens",
                column: "LancheId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarrinhoCompraItens");

            migrationBuilder.AlterColumn<string>(
                name: "DescriptionDetail",
                table: "Lanches",
                type: "nvarchar(80)",
                maxLength: 80,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);
        }
    }
}
