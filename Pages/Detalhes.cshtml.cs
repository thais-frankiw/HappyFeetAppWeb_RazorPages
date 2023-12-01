using HappyFeetAppWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HappyFeetAppWeb.Servicos;

namespace HappyFeetAppWeb.Pages;

public class DetalhesModel : PageModel
{   
    private IProdutoServico _servico;
    public string DescricaoCategoria { get; set; }
    public DetalhesModel(IProdutoServico servico)
    {
        _servico = servico;
    }

    public Produto Produto { get; private set; }

    public IActionResult OnGet(int id)
    {
        Produto = _servico.Obter(id);

        if(Produto.CategoriaId is not null)
        {
            DescricaoCategoria = _servico.ObterCategoria(Produto.CategoriaId.Value).Descricao;
        }

        if (Produto == null)
        {
            return NotFound();
        }  
        return Page();
    }
}
