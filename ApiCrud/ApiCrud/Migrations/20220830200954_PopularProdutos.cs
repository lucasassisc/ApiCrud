using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiCrud.Migrations
{
    public partial class PopularProdutos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Produtos (Nome,Descricao,Preco,ImagemUrl,Estoque, DataCadastro, CategoriaId)" +
                                "VALUES('Coca-Cola Diet', 'Refrigerante de Cola 350 ml', 5.45, 'cocacola.jpg',50,getdate(),1)");

            migrationBuilder.Sql("INSERT INTO Produtos (Nome,Descricao,Preco,ImagemUrl,Estoque, DataCadastro, CategoriaId)" +
                                 "VALUES('Lanche de Atum', 'Lanche de atum com maionese', 8.50, 'atum.jpg',10,getdate(),2)");

            migrationBuilder.Sql("INSERT INTO Produtos (Nome,Descricao,Preco,ImagemUrl,Estoque, DataCadastro, CategoriaId)" +
                                 "VALUES('Pudim 100 g', 'Pudim de leite condensado 100g', 6.75, 'pudim.jpg',20,getdate(),3)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DElETE FROM  Produtos");
        }
    }
}
