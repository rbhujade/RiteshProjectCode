using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_Core_Project.Database;

namespace MVC_Core_Project.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductManagementContext _dbContext;

        public ProductController(ProductManagementContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var result = _dbContext.Products.ToList();
            return View(result);
        }

        public IActionResult Create()
        { 
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id","Name","Price")] Product product) 
        {
            if (ModelState.IsValid)
            {
                _dbContext.Add(product);
                await _dbContext.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _dbContext.Products.FindAsync(id);
            if (result != null) 
            {
                _dbContext.Products.Remove(result);
            }
            await _dbContext.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
