using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SupermarketWEB.Data;
using SupermarketWEB.Models;

namespace SupermarketWEB.Pages.Customers
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly SupermarketContext _context;

        public IndexModel(SupermarketContext context)
        {
            _context = context;
        }
        public IList<Customer> Customers { get; set; } = default!;

        public async Task OnGetAsync()
        {
            Customers = await _context.Customers.ToListAsync();
        }
    }
}