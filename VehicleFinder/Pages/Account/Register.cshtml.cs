using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace VehicleFinder.Pages
{
    public class RegisterModel : PageModel
    {
        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            public string Email { get; set; }
            public string Password { get; set; }
            public string ConfirmPassword { get; set; }
        }

        public void OnGet() { }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                // Perform registration logic
                return RedirectToPage("/Index");
            }

            return Page();
        }
    }
}
