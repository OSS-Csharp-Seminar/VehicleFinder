using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace VehicleFinder.Pages
{
    [Authorize(Roles = "ADMIN")]
    public class AdminModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
