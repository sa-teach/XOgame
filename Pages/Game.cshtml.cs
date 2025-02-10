using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace XOgame_x2.Pages
{
    public class GameModel : PageModel
    {
        //[BindProperty(SupportsGet = true)]
        public string PlayerX { get; set; }

        //[BindProperty(SupportsGet = true)]
        public string PlayerO { get; set; }

        public void OnGet()
        {
            PlayerX = TempData["PlayerX"] as string ?? "Игрок X";
            PlayerO = TempData["PlayerO"] as string ?? "Игрок O";
        }
    }
}
