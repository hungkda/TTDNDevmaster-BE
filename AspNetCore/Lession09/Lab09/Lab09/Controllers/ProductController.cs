using Lab09.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Lab09.Controllers
{
    public class ProductController : Controller
    {
        private readonly DevXuongMocContext _content;
        public ProductController(DevXuongMocContext content)
        {
            _content = content;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _content.Products.ToListAsync();
            return View(data);
        }
    }
}
