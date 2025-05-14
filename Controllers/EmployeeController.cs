using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PROG_7311_POE_Part_2.Data;
using PROG_7311_POE_Part_2.Models;

namespace PROG_7311_POE_Part_2.Controllers
{
    [Authorize(Roles = "Employee")]
    public class EmployeeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EmployeeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Dashboard()
        {
            return View();
        }

        public async Task<IActionResult> ViewProducts(string category, DateTime? fromDate, DateTime? toDate)
        {
            var query = _context.Products
                .Include(p => p.Farmer)
                .AsQueryable();

            if (!string.IsNullOrEmpty(category))
                query = query.Where(p => p.Category.Contains(category));

            if (fromDate.HasValue)
                query = query.Where(p => p.ProductionDate >= fromDate.Value);

            if (toDate.HasValue)
                query = query.Where(p => p.ProductionDate <= toDate.Value);

            return View(await query.ToListAsync());
        }

        public IActionResult CreateFarmer()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateFarmer(Farmer model)
        {
            if (ModelState.IsValid)
            {
                _context.Farmers.Add(model);
                await _context.SaveChangesAsync();
                return RedirectToAction("Dashboard");
            }

            return View(model);
        }
    }
}
