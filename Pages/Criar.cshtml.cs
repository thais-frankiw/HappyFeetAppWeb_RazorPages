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
    public class CriarModel : PageModel
    {
        public SelectList CategoriaOpcaoItens { get; set; }
        public SelectList GeneroOpcaoTipos { get; set; }

        private IProdutoServico _servico;
        private IToastNotification _toastNotification;
        public CriarModel(IProdutoServico servico, IToastNotification toastNotification)
        {
            _servico = servico;
            _toastNotification = toastNotification;
        }

        public void OnGet()
        {
            CategoriaOpcaoItens = new SelectList(_servico.ObterTodasCategorias(), 
                nameof(Categoria.CategoriaId), 
                nameof(Categoria.Descricao));

            GeneroOpcaoTipos = new SelectList(_servico.ObterTodosGeneros(),
               nameof(Genero.GeneroId),
               nameof(Genero.GeneroNome));
        }

        [BindProperty]
        public Produto Produto { get; set; }

        [BindProperty]
        public IList<int> GeneroIds{ get; set; }

        public IActionResult OnPost()
        {
            Produto.Generos = _servico.ObterTodosGeneros()
                                .Where(item => GeneroIds.Contains(item.GeneroId))
                                .ToList();

            if (!ModelState.IsValid) 
            { 
                return Page();
            }
            
            _servico.Incluir(Produto);
            _toastNotification.AddSuccessToastMessage("Operação realizada com sucesso.");

            return RedirectToPage("/Index");
        }
    }
}

