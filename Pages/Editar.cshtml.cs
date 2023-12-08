using HappyFeetAppWeb.Models;
using HappyFeetAppWeb.Servicos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using NToastNotify; 

namespace HappyFeetAppWeb.Pages
{
    [Authorize]
    public class EditarModel : PageModel
    {
        public SelectList CategoriaOpcaoItens { get; set; }
        public SelectList GeneroOpcaoTipos { get; set; }

        private IProdutoServico _servico;
        private IToastNotification _toastNotification;
        public EditarModel(IProdutoServico servico, IToastNotification toastNotification)
        {
            _servico = servico;
            _toastNotification = toastNotification;
        }

        [BindProperty]
        public Produto Produto { get; set; }
        [BindProperty]
        public IList<int> GeneroIds { get; set; }

        public IActionResult OnGet(int id)
        {
            Produto = _servico.Obter(id);

            GeneroIds = Produto.Generos.Select(item => item.GeneroId).ToList();

            CategoriaOpcaoItens = new SelectList(_servico.ObterTodasCategorias(),
                nameof(Categoria.CategoriaId),
                nameof(Categoria.Descricao));

            GeneroOpcaoTipos = new SelectList(_servico.ObterTodosGeneros(),
              nameof(Genero.GeneroId),
              nameof(Genero.GeneroNome));

            if (Produto == null)
            {
                return NotFound();
            }
            return Page();
        }

        public IActionResult OnPost()
        {
            Produto.Generos = _servico.ObterTodosGeneros()
                                .Where(item => GeneroIds.Contains(item.GeneroId))
                                .ToList();

            if (!ModelState.IsValid)
            {
                return Page();
            }
            _servico.Alterar(Produto);

            _toastNotification.AddSuccessToastMessage("Operação realizada com sucesso.");
            return RedirectToPage("/Index");
        }

        public IActionResult OnPostExclusao()
        {
            _servico.Excluir(Produto.ProdutoId);
            _toastNotification.AddSuccessToastMessage("Operação realizada com sucesso.");

            return RedirectToPage("/Index");
        }
    }
}
 