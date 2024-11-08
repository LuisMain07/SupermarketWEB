using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;
using SupermarketWEB.Models;

namespace SupermarketWEB.Pages.Account
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public User User { get; set; }
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid) return Page();
            if (User.Email == "correo@gmail.com" && User.Password == "1234")
            {
                var clains = new List<Claim>
                {
                new Claim(ClaimTypes.Name, "admin"),
                new Claim(ClaimTypes.Email, User.Email),
                };
                var identity = new ClaimsIdentity(clains, "My coockieAuth");
                ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(identity);

                await HttpContext.SignInAsync("MycookieAuth", claimsPrincipal);
                return RedirectToPage("/Index");
            }
            return Page();
        }
    }
}
