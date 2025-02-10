
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace XOgame_x2.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public string PlayerX { get; set; }

        [BindProperty]
        public string PlayerO { get; set; }

        public IActionResult OnPost()
        {
            TempData["PlayerX"] = PlayerX;
            TempData["PlayerO"] = PlayerO;

            return RedirectToPage("/Game");
        }
        public void OnGet()
        {
            
        }
    }
}


