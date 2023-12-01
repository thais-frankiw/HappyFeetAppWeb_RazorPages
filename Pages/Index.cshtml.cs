using Microsoft.AspNetCore.Mvc.RazorPages;
using HappyFeetAppWeb.Models;
using static System.Net.Mime.MediaTypeNames;
using HappyFeetAppWeb.Servicos;

namespace HappyFeetAppWeb.Pages;


public class IndexModel : PageModel
{
    private IProdutoServico _servico;

    public IndexModel(IProdutoServico servico, IConfiguration configuracao)
    {
        _servico = servico;
    }

    public IList<Produto> ListaProduto { get; private set; }

    public void OnGet()
    {
        ViewData["Title"] = "Home page";

        ListaProduto = _servico.ObterTodos();  
    }
}