using HappyFeetAppWeb.Models;
using HappyFeetAppWeb.Servicos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HappyFeetAppWeb.Pages
{
    public class CriarModel : PageModel
    {
        public SelectList CategoriaOpcaoItens{ get; set; }

        private IProdutoServico _servico;
        public CriarModel(IProdutoServico servico)
        {
            _servico = servico;
        }

        public void OnGet()
        {
            CategoriaOpcaoItens = new SelectList(_servico.ObterTodasCategorias(), 
                nameof(Categoria.CategoriaId), 
                nameof(Categoria.Descricao));
        }

        [BindProperty]
        public Produto Produto { get; set; }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid) 
            { 
                return Page();
            }
            
            _servico.Incluir(Produto);

            return RedirectToPage("/Index");
        }
    }
}

