﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HappyFeetAppWeb.Data;
using HappyFeetAppWeb.Models;

namespace HappyFeetAppWeb.Pages.Categorias
{
    public class DeleteModel : PageModel
    {
        private readonly HappyFeetAppWeb.Data.HappyFeetDBContext _context;

        public DeleteModel(HappyFeetAppWeb.Data.HappyFeetDBContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Categoria Categoria { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Categoria == null)
            {
                return NotFound();
            }

            var categoria = await _context.Categoria.FirstOrDefaultAsync(m => m.CategoriaId == id);

            if (categoria == null)
            {
                return NotFound();
            }
            else 
            {
                Categoria = categoria;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Categoria == null)
            {
                return NotFound();
            }
            var categoria = await _context.Categoria.FindAsync(id);

            if (categoria != null)
            {
                Categoria = categoria;
                _context.Categoria.Remove(Categoria);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
