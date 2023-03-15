using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HamburguerShop.Migrations
{
    /// <inheritdoc />
    public partial class PopularLanches : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId, DescricaoCurta, DescricaoDetalhada, EmEstoque, ImagemThumbnailUrl, ImagemUrl, IsLanchePreferido, Nome, Preco) VALUES(1, 'Pão, hambúrguer, ovo, presunto, queijo e batata palha', 'Delicioso pão de hambúrguer com ovo frito, presunto e queijo de primeira qualidade acompanhado com batata palha', 1, 'http://www.macoratti.net/Imagens/lanches/cheesesalad1.jpg', 'http://www.macorati.net/Imagens/lanches1.jpg', 0, 'Cheese Salada', 12.50)");
			migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId, DescricaoCurta, DescricaoDetalhada, EmEstoque, ImagemThumbnailUrl, ImagemUrl, IsLanchePreferido, Nome, Preco) VALUES(1, 'Pão, presunto, mussarela e tomate', 'Delicioso pão de hambúrguer com ovo frito, presunto e queijo de primeira qualidade acompanhado com batata palha', 1, 'http://www.macoratti.net/Imagens/lanches/mistoquente4.jpg', 'http://www.macoratti.net/Imagens/lanches/mistoquente4.jpg', 0, 'Misto Quente', 8.00)");
			migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId, DescricaoCurta, DescricaoDetalhada, EmEstoque, ImagemThumbnailUrl, ImagemUrl, IsLanchePreferido, Nome, Preco) VALUES(1, 'Pão, hambúrguer, presunto, mussarela e batata palha', 'Delicioso pão de hambúrguer com ovo frito, presunto e queijo de primeira qualidade acompanhado com batata palha', 1, 'http://www.macoratti.net/Imagens/lanches/cheeseburguer1.jpg', 'http://www.macoratti.net/Imagens/lanches/cheeseburguer1.jpg', 0, 'Cheese Burguer', 11.00)");
			migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId, DescricaoCurta, DescricaoDetalhada, EmEstoque, ImagemThumbnailUrl, ImagemUrl, IsLanchePreferido, Nome, Preco) VALUES(2, 'Pão integral, queijo branco, peito de peru, cenoura, alface, iogurte', 'Delicioso pão de hambúrguer com ovo frito, presunto e queijo de primeira qualidade acompanhado com batata palha', 1, 'http://www.macoratti.net/Imagens/lanches/lanchenatural.jpg', 'http://www.macoratti.net/Imagens/lanches/lanchenatural.jpg', 1, 'Lanche Natural Peito de Peru', 15.00)");

		}

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Lanches");
        }
    }
}
