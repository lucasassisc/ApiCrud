using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiCrud.Migrations
{
    public partial class PopularCategorias : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Categorias(Nome,Imagem)" +
             "VALUES('Bebidas','bebidas.jpg')");

            migrationBuilder.Sql("INSERT INTO Categorias(Nome,Imagem)" +
            "VALUES('Lanches','lanches.jpg')");

            migrationBuilder.Sql("INSERT INTO Categorias(Nome,Imagem)" +
            "VALUES('Sobremesas','sobremesas.jpg')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DElETE FROM  Categorias");
        }
    }
}
