using HappyFeetAppWeb.Models;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HappyFeetAppWeb.Data.Migrations
{
    /// <inheritdoc />
    public partial class AdicionarDadosGenero1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var context = new HappyFeetDBContext();
            context.Genero.AddRange(ObterCargaInicalGenero());
            context.SaveChanges();
        }

        private IList<Genero> ObterCargaInicalGenero()
        {
            return new List<Genero>()
            {
                new Genero(){GeneroNome = "Masculino"},
                new Genero(){GeneroNome = "Feminino"},
                new Genero(){GeneroNome = "Menino"},
                new Genero(){GeneroNome = "Menina"}
            };
        }

    }
}
