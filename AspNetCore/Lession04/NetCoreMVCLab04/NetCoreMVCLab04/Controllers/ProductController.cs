using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using NetCoreMVCLab04.Models;
using System.Reflection;

namespace NetCoreMVCLab04.Controllers
{
    public class ProductController : Controller
    {
        // GET: ProductController
        public ActionResult Index()
        {
            var products = DataLocal.GetProduct();
            var categories = DataLocal.GetCategory();
            ViewBag.Categories = categories;
            return View(products);
        }

        // GET: ProductController/Details/5
        public ActionResult Details(int id)
        {
            var product = DataLocal.GetProductById(id);
            ViewBag.Categories = new SelectList(DataLocal.categories, "Id", "Name", product.Id);
            return View(product);
        }

        // GET: ProductController/Create
        public ActionResult Create()
        {
            Product product = new Product();
            ViewBag.Categories = new SelectList(DataLocal.categories, "Id", "Name", 1);
            var Id = DataLocal.products.MaxBy(x => x.Id).Id;
            ViewBag.Id = Id + 1;
            return View(product);
        }

        // POST: ProductController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Product model)
        {
            try
            {
                var files = HttpContext.Request.Form.Files;
                if (files.Count() > 0 && files[0].Length > 0)
                {
                    var file = files[0];
                    var fileName = file.FileName;

                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images\\Product", fileName);
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        file.CopyTo(stream);
                        model.Image = "images/Product/" + fileName;
                    }
                }

                model.CreatedDate = DateTime.Now;
                DataLocal.products.Add(model);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(model);
            }
        }

        // GET: ProductController/Edit/5
        public ActionResult Edit(int id)
        {
            var product = DataLocal.GetProductById(id);
            ViewBag.Categories = new SelectList(DataLocal.categories,"Id","Name", product.Id);
            return View(product);
        }

        // POST: ProductController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Product model)
        {
            try
            {
                var files = HttpContext.Request.Form.Files;
                if (files.Count() > 0 && files[0] != null)
                {
                    var file = files[0];
                    var fileName = file.FileName;

                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images\\Product", fileName);
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        file.CopyTo(stream);
                        model.Image = "images/Product/" + fileName;
                    }
                }

                for (int i = 0; i < DataLocal.products.Count; i++)
                {
                    if (DataLocal.products[i].Id == id)
                    {
                        DataLocal.products[i] = model;
                        break;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(model);
            }
        }

        // GET: ProductController/Delete/5
        public ActionResult Delete(int id)
        {
            var product = DataLocal.GetProductById(id);
            ViewBag.Categories = new SelectList(DataLocal.categories, "Id", "Name", product.Id);
            return View(product);
        }

        // POST: ProductController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Product model)
        {
            try
            {
                for (int i = 0; i < DataLocal.products.Count; i++)
                {
                    if (DataLocal.products[i].Id == id)
                    {
                        DataLocal.products.RemoveAt(i);
                        break;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
