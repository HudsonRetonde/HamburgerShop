using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HamburguerShop.Migrations
{
    /// <inheritdoc />
    public partial class PopularCategorias : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome, Descricao)" +
                "VALUES('Normal', 'Lanches feitos com igredientes normais')");

			migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome, Descricao)" +
				"VALUES('Naturais', 'Lanches feitos com igredientes naturais e integrais')");

		}

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Categorias");
        }
    }
}
