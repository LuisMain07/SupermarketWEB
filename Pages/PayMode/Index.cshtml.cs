using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SupermarketWEB.Data;
using SupermarketWEB.Models;

namespace SupermarketWeb.Pages.PayModes
{
    public class IndexModel : PageModel
    {
        private readonly SupermarketContext _context;

        public IndexModel(SupermarketContext context)
        {
            _context = context;
        }
        public IList<PayMode> PayMode { get; set; } = default!;

        public async Task OnGetAsync()
        {
            PayMode = await _context.PayModes.ToListAsync();
        }
    }
}
