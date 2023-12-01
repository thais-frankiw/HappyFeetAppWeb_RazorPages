using HappyFeetAppWeb.Models;
using HappyFeetAppWeb.Servicos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HappyFeetAppWeb.Pages
{
    public class EditarModel : PageModel
    {
        public SelectList CategoriaOpcaoItens { get; set; }
       
        private IProdutoServico _servico;
        public EditarModel(IProdutoServico servico)
        {
            _servico = servico;
        }

        [BindProperty]
        public Produto Produto { get; set; }


        public IActionResult OnGet(int id)
        {
            Produto = _servico.Obter(id);

            CategoriaOpcaoItens = new SelectList(_servico.ObterTodasCategorias(),
                nameof(Categoria.CategoriaId),
                nameof(Categoria.Descricao));

            if (Produto == null)
            {
                return NotFound();
            }
            return Page();
        }


        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _servico.Alterar(Produto);

            return RedirectToPage("/Index");
        }

        public IActionResult OnPostExclusao()
        {
            _servico.Excluir(Produto.ProdutoId);

            return RedirectToPage("/Index");
        }
    }
}
 