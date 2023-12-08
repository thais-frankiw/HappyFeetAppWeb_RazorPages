using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HappyFeetAppWeb.Data;
using HappyFeetAppWeb.Models;

namespace HappyFeetAppWeb.Pages.Generos
{
    public class IndexModel : PageModel
    {
        private readonly HappyFeetAppWeb.Data.HappyFeetDBContext _context;

        public IndexModel(HappyFeetAppWeb.Data.HappyFeetDBContext context)
        {
            _context = context;
        }

        public IList<Genero> Genero { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Genero != null)
            {
                Genero = await _context.Genero.ToListAsync();
            }
        }
    }
}
