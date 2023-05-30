using BurgerRestaurant.Models;
using BurgerRestaurant.Services;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BurgerRestaurant.Pages
{
    public class BurgerListModel : PageModel
    {
        private readonly BurgerService _service;
        public IList<Burger> BurgerList { get; set; } = default!;
        [BindProperty]
        public Burger NewBurger { get; set; } = default!;

        public BurgerListModel(BurgerService service)
        {
            _service = service;
        }

        public void OnGet()
        {
            BurgerList = _service.GetBurgers();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid || NewBurger == null)
            {
                return Page();
            }

            _service.AddBurger(NewBurger);

            return RedirectToAction("Get");
        }

        public IActionResult OnPostDelete(int id)
        {
            _service.DeleteBurger(id);

            return RedirectToAction("Get");
        }
    }
}
