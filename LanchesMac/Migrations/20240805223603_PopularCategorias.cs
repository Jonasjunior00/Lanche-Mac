using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanchesMac.Migrations
{
    public partial class PopularCategorias : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Insert into Categorias(CategoriaNome,Descricao) " +
                "Values('Normal','Lanche feito com ingredientes normais')");
            migrationBuilder.Sql("Insert into Categorias(CategoriaNome,Descricao) " +
              "Values('Natural','Lanche feito com ingredientes light, integrais e naturais')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete from Categorias");
        }
    }
}
