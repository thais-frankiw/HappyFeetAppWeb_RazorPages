using HappyFeetAppWeb.Models;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HappyFeetAppWeb.Data.Migrations
{
    /// <inheritdoc />
    public partial class AdicionarDadosTabelaCategoria : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var context = new HappyFeetDBContext();
            context.Categoria.AddRange(ObterCargaInicalCategoria());
            context.SaveChanges();
        }

        private IList<Categoria> ObterCargaInicalCategoria()
        {
            return new List<Categoria>()
            {
                new Categoria(){Descricao = "Chinelo/Slider"},
                new Categoria(){Descricao = "Pantufa"}
            };
        }
    }
}
