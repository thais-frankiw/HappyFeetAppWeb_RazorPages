using System.ComponentModel.DataAnnotations;
namespace HappyFeetAppWeb.Models;

public class Produto
{
    public int ProdutoId { get; set; }

    [Required(ErrorMessage = "Campo 'Nome' obrigatório.")]
    [StringLength(50, MinimumLength = 10, ErrorMessage = "Campo 'Nome' deve ter entre 10 e 50 caracteres.")]
    [Display(Name = "Nome")]
    public string ProdutoTitulo { get; set; }
    public string ProdutoTituloSlug => ProdutoTitulo.ToLower().Replace(" ", "-");

    [Required(ErrorMessage = "Campo 'Descrição' obrigatório.")]
    [StringLength(1000, MinimumLength = 100, ErrorMessage = "Campo 'Descrição' deve ter entre 100 e 500 caracteres.")]
    [Display(Name = "Descrição")]
    public string ProdutoDescricao { get; set; }

    [Required(ErrorMessage = "Campo 'Caminho URL da imagem' obrigatório.")]
    [Display(Name = "Caminho URL da imagem")]
    public string ImagemUri { get; set; }

    [Required(ErrorMessage = "Campo 'Preço' obrigatório.")]
    [Display(Name = "Preço")]
    [DataType(DataType.Currency)]
    public double Preco { get; set; }


    [Required(ErrorMessage = "Campo 'Tamanhos disponiveis' obrigatório.")]
    [Display(Name = "Tamanhos disponiveis")]
    public String TamanhosDisponiveis { get; set; }


    [Display(Name = "Produto em estoque")]
    public bool ProdutoEmEstoque { get; set; }
    public string ProdutoEmEstoqueFormatado => ProdutoEmEstoque ? "Sim" : "Não";

    [Required(ErrorMessage = "Campo 'Data de envio' obrigatório.")]
    [Display(Name = "Data de envio")]
    [DisplayFormat(DataFormatString = "{0:dd'/'MM'/'yyyy}")]
    public DateTime DataDeEnvio { get; set; }

    [Display(Name = "Categoria")]
    public int? CategoriaId { get; set; }

}
