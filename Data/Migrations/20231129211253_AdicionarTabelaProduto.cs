using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HappyFeetAppWeb.Data.Migrations
{
    /// <inheritdoc />
    public partial class AdicionarTabelaProduto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Produto",
                columns: table => new
                {
                    ProdutoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProdutoTitulo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ProdutoDescricao = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    ImagemUri = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Preco = table.Column<double>(type: "float", nullable: false),
                    TamanhosDisponiveis = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProdutoEmEstoque = table.Column<bool>(type: "bit", nullable: false),
                    DataDeEnvio = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produto", x => x.ProdutoId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Produto");
        }
    }
}
