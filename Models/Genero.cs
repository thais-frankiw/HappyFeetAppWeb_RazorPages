namespace HappyFeetAppWeb.Models
{
    public class Genero
    {
        public int GeneroId { get; set; }
        public string GeneroNome { get; set; }

        public ICollection<Produto>? Generos { get; set; }
    }
}
