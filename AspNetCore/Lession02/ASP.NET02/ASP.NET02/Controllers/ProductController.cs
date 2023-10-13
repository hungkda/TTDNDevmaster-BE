using ASP.NET02.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET02.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            List<Product> products = new List<Product>()
            {
                new Product {
                    Id = 1,
                    Title = "Quần áo 1",
                    Img = Url.Content("~/images/Product/quanao.jpg"),
                    Cost = 23.999,
                    Sale = 10.999,
                    IdCategory = 1,
                    Description = "Hàng chất luonjgw cao",
                    date = new DateTime(2000/01/01),
                    status = true
                },
                new Product {
                    Id = 2,
                    Title = "Quần áo 2",
                    Img = Url.Content("~/images/Product/quanao1.jpg"),
                    Cost = 21.999,
                    Sale = 10.999,
                    IdCategory = 1,
                    Description = "Hàng chất luonjgw cao",
                    date = new DateTime(2000/01/01),
                    status = true
                },
                new Product {
                    Id = 3,
                    Title = "TÚi xách 1",
                    Img = Url.Content("~/images/Product/tuixach1.jpg"),
                    Cost = 50.999,
                    Sale = 20.999,
                    IdCategory = 2,
                    Description = "Hàng chất luonjgw cao",
                    date = new DateTime(2000/01/01),
                    status = true
                },
                new Product {
                    Id = 4,
                    Title = "TÚi xách 2",
                    Img = Url.Content("~/images/Product/tuixach2.jpg"),
                    Cost = 63.999,
                    Sale = 21.999,
                    IdCategory = 2,
                    Description = "Hàng chất luonjgw cao",
                    date = new DateTime(2000/01/01),
                    status = true
                },
                new Product {
                    Id = 5,
                    Title = "Đồng hồ 1",
                    Img = Url.Content("~/images/Product/dongho1.jpg"),
                    Cost = 99.999,
                    Sale = 9.999,
                    IdCategory = 3,
                    Description = "Hàng chất luonjgw cao",
                    date = new DateTime(2000/01/01),
                    status = true
                },
                new Product {
                    Id = 6,
                    Title = "Đồng hồ 2",
                    Img = Url.Content("~/images/Product/dongho2.jpg"),
                    Cost = 99.999,
                    Sale = 9.999,
                    IdCategory = 3,
                    Description = "Hàng chất luonjgw cao",
                    date = new DateTime(2000/01/01),
                    status = true
                },
            };

            ViewBag.Products = products;
            return View();
        }

        [Route("San-pham", Name = "category")]
        public IActionResult IndexFilter(int id)
        {
            List<Product> products = new List<Product>()
            {
                new Product {
                    Id = 1,
                    Title = "Quần áo 1",
                    Img = Url.Content("~/images/Product/quanao.jpg"),
                    Cost = 23.999,
                    Sale = 10.999,
                    IdCategory = 1,
                    Description = "Hàng chất luonjgw cao",
                    date = new DateTime(2000/01/01),
                    status = true
                },
                new Product {
                    Id = 2,
                    Title = "Quần áo 2",
                    Img = Url.Content("~/images/Product/quanao1.jpg"),
                    Cost = 21.999,
                    Sale = 10.999,
                    IdCategory = 1,
                    Description = "Hàng chất luonjgw cao",
                    date = new DateTime(2000/01/01),
                    status = true
                },
                new Product {
                    Id = 3,
                    Title = "TÚi xách 1",
                    Img = Url.Content("~/images/Product/tuixach1.jpg"),
                    Cost = 50.999,
                    Sale = 20.999,
                    IdCategory = 2,
                    Description = "Hàng chất luonjgw cao",
                    date = new DateTime(2000/01/01),
                    status = true
                },
                new Product {
                    Id = 4,
                    Title = "TÚi xách 2",
                    Img = Url.Content("~/images/Product/tuixach2.jpg"),
                    Cost = 63.999,
                    Sale = 21.999,
                    IdCategory = 2,
                    Description = "Hàng chất luonjgw cao",
                    date = new DateTime(2000/01/01),
                    status = true
                },
                new Product {
                    Id = 5,
                    Title = "Đồng hồ 1",
                    Img = Url.Content("~/images/Product/dongho1.jpg"),
                    Cost = 99.999,
                    Sale = 9.999,
                    IdCategory = 3,
                    Description = "Hàng chất luonjgw cao",
                    date = new DateTime(2000/01/01),
                    status = true
                },
                new Product {
                    Id = 6,
                    Title = "Đồng hồ 2",
                    Img = Url.Content("~/images/Product/dongho2.jpg"),
                    Cost = 99.999,
                    Sale = 9.999,
                    IdCategory = 3,
                    Description = "Hàng chất luonjgw cao",
                    date = new DateTime(2000/01/01),
                    status = true
                },
            };
            var category = products.Where(p => p.IdCategory == id);
            ViewBag.Products = category;
            return View();
        }

        [Route("chi-tiet-san-pham", Name = "details")]
        public IActionResult Details(int id)
        {
            List<Product> products = new List<Product>()
            {
                new Product {
                    Id = 1,
                    Title = "Quần áo 1",
                    Img = Url.Content("~/images/Product/quanao.jpg"),
                    Cost = 23.999,
                    Sale = 10.999,
                    IdCategory = 1,
                    Description = "Hàng chất luonjgw cao",
                    date = new DateTime(2000/01/01),
                    status = true
                },
                new Product {
                    Id = 2,
                    Title = "Quần áo 2",
                    Img = Url.Content("~/images/Product/quanao1.jpg"),
                    Cost = 21.999,
                    Sale = 10.999,
                    IdCategory = 1,
                    Description = "Hàng chất luonjgw cao",
                    date = new DateTime(2000/01/01),
                    status = true
                },
                new Product {
                    Id = 3,
                    Title = "TÚi xách 1",
                    Img = Url.Content("~/images/Product/tuixach1.jpg"),
                    Cost = 50.999,
                    Sale = 20.999,
                    IdCategory = 2,
                    Description = "Hàng chất luonjgw cao",
                    date = new DateTime(2000/01/01),
                    status = true
                },
                new Product {
                    Id = 4,
                    Title = "TÚi xách 2",
                    Img = Url.Content("~/images/Product/tuixach2.jpg"),
                    Cost = 63.999,
                    Sale = 21.999,
                    IdCategory = 2,
                    Description = "Hàng chất luonjgw cao",
                    date = new DateTime(2000/01/01),
                    status = true
                },
                new Product {
                    Id = 5,
                    Title = "Đồng hồ 1",
                    Img = Url.Content("~/images/Product/dongho1.jpg"),
                    Cost = 99.999,
                    Sale = 9.999,
                    IdCategory = 3,
                    Description = "Hàng chất luonjgw cao",
                    date = new DateTime(2000/01/01),
                    status = true
                },
                new Product {
                    Id = 6,
                    Title = "Đồng hồ 2",
                    Img = Url.Content("~/images/Product/dongho2.jpg"),
                    Cost = 99.999,
                    Sale = 9.999,
                    IdCategory = 3,
                    Description = "Hàng chất luonjgw cao",
                    date = new DateTime(2000/01/01),
                    status = true
                },
            };
            var product = products.FirstOrDefault(product => product.Id == id);
            ViewBag.Product = product;
            return View();
        }
    }
}
