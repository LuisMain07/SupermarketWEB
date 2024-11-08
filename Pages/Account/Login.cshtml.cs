using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;
using SupermarketWEB.Models;
using SupermarketWEB.Data;

namespace SupermarketWEB.Pages.Account
{
    public class LoginModel : PageModel
    {
        private readonly SupermarketContext _context;

        public LoginModel(SupermarketContext context)
        {
            _context = context;
        }

        [BindProperty]
        public User User { get; set; }
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid) return Page();

            var UsersLogin = _context.Users
                .FirstOrDefault(identityDb => identityDb.Email == User.Email && identityDb.Password == User.Password);

            if (UsersLogin != null)
            {
                var clains = new List<Claim>
                {
                new Claim(ClaimTypes.Name, "admin"),
                new Claim(ClaimTypes.Email, User.Email),
                };
                var identity = new ClaimsIdentity(clains, "MycookieAuth");
                ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(identity);

                await HttpContext.SignInAsync("MycookieAuth", claimsPrincipal);
                return RedirectToPage("/Index");
            }
            return Page();
        }
    }
}
