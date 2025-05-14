using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using PROG_7311_POE_Part_2.Models;

namespace PROG_7311_POE_Part_2.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public HomeController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                var user = await _userManager.GetUserAsync(User);

                if (await _userManager.IsInRoleAsync(user, "Farmer"))
                {
                    return RedirectToAction("Dashboard", "Farmer");
                }
                else if (await _userManager.IsInRoleAsync(user, "Employee"))
                {
                    return RedirectToAction("Dashboard", "Employee");
                }
            }

            return View(); // default landing page for unauthenticated users
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
