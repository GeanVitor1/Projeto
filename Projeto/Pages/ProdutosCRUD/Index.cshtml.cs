using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Projeto.Models;

namespace Projeto.Pages.ProdutosCRUD
{
    public class IndexModel : PageModel
    {
        private readonly Projeto.Data.ApplicationDbContext _context;

        public IndexModel(Projeto.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Produto> Produto { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Produto != null)
            {
                Produto = await _context.Produto.ToListAsync();
            }
        }
    }
}
