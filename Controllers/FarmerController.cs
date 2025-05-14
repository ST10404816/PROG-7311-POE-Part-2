using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PROG_7311_POE_Part_2.Data;
using PROG_7311_POE_Part_2.Models;

namespace PROG_7311_POE_Part_2.Controllers
{
    [Authorize(Roles = "Farmer")]
    public class FarmerController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public FarmerController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task<IActionResult> Dashboard()
        {
            var user = await _userManager.GetUserAsync(User);
            var farmer = await _context.Farmers
                .Include(f => f.Products)
                .FirstOrDefaultAsync(f => f.UserId == user.Id);

            if (farmer == null)
                return RedirectToAction("CreateProfile");

            return View(farmer.Products.ToList());
        }

        public IActionResult CreateProfile()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateProfile(Farmer model)
        {
            var user = await _userManager.GetUserAsync(User);
            model.UserId = user.Id;

            _context.Farmers.Add(model);
            await _context.SaveChangesAsync();

            return RedirectToAction("Dashboard");
        }

        public IActionResult CreateProduct()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct(Product product)
        {
            var user = await _userManager.GetUserAsync(User);
            var farmer = await _context.Farmers.FirstOrDefaultAsync(f => f.UserId == user.Id);

            if (farmer == null)
                return RedirectToAction("CreateProfile");

            product.FarmerId = farmer.Id;
            _context.Products.Add(product);
            await _context.SaveChangesAsync();

            return RedirectToAction("Dashboard");
        }
    }
}
