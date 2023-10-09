using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreMVC_Ex.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
