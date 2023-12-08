using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HappyFeetAppWeb.Data.Migrations
{
    /// <inheritdoc />
    public partial class AdicionarRelacionamentoProdutoGenero : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GeneroProduto",
                columns: table => new
                {
                    GenerosGeneroId = table.Column<int>(type: "int", nullable: false),
                    GenerosProdutoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeneroProduto", x => new { x.GenerosGeneroId, x.GenerosProdutoId });
                    table.ForeignKey(
                        name: "FK_GeneroProduto_Genero_GenerosGeneroId",
                        column: x => x.GenerosGeneroId,
                        principalTable: "Genero",
                        principalColumn: "GeneroId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GeneroProduto_Produto_GenerosProdutoId",
                        column: x => x.GenerosProdutoId,
                        principalTable: "Produto",
                        principalColumn: "ProdutoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GeneroProduto_GenerosProdutoId",
                table: "GeneroProduto",
                column: "GenerosProdutoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GeneroProduto");
        }
    }
}
