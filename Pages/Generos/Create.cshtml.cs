using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using HappyFeetAppWeb.Data;
using HappyFeetAppWeb.Models;

namespace HappyFeetAppWeb.Pages.Generos
{
    public class CreateModel : PageModel
    {
        private readonly HappyFeetAppWeb.Data.HappyFeetDBContext _context;

        public CreateModel(HappyFeetAppWeb.Data.HappyFeetDBContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Genero Genero { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Genero == null || Genero == null)
            {
                return Page();
            }

            _context.Genero.Add(Genero);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
