using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VehicleFinder.Entities;

namespace VehicleFinder.Pages
{
    [Authorize(Roles = "USER")]
    public class UserModel : PageModel
    {
        private readonly UserManager<User> userManager;

        public User? appUser;

        public UserModel(UserManager<User> userManager)
        {
            this.userManager = userManager;
        }

        public void OnGet()
        {
            var task = userManager.GetUserAsync(User);
            task.Wait();
            appUser = task.Result;
        }
    }
}
