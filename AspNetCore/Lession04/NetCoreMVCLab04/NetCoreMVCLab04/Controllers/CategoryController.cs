using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NetCoreMVCLab04.Models;
using System.Reflection;

namespace NetCoreMVCLab04.Controllers
{
    public class CategoryController : Controller
    {
        // GET: CategoryController
        public ActionResult Index()
        {
            var categories = DataLocal.GetCategory();
            return View(categories);
        }

        // GET: CategoryController/Details/5
        public ActionResult Details(int id)
        {
            var category = DataLocal.categories.FirstOrDefault(x => x.Id == id);
            return View(category);
        }

        // GET: CategoryController/Create
        public ActionResult Create()
        {
            var Id = DataLocal.categories.MaxBy(x=>x.Id).Id;
            ViewBag.Id = Id+1;
            return View();
        }

        // POST: CategoryController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Category model)
        {
            try
            {
                //cập nhật giá trị cho cột ẩn
                model.CreateDate = DateTime.Now;
                model.CreateBy = "FuHua";
                //add model vô list categories trong datalocal
                DataLocal.categories.Add(model);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CategoryController/Edit/5
        public ActionResult Edit(int id)
        {
            Category category = DataLocal.categories.FirstOrDefault(x => x.Id == id);
            return View(category);
        }

        // POST: CategoryController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Category model)
        {
            try
            {
                for(int i=0;  i<DataLocal.categories.Count; i++)
                {
                    if (DataLocal.categories[i].Id == id)
                    {
                        DataLocal.categories[i] = model;
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

        // GET: CategoryController/Delete/5
        public ActionResult Delete(int id)
        {
            var category = DataLocal.categories.FirstOrDefault(x => x.Id ==id);
            return View(category);
        }

        // POST: CategoryController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Category model)
        {
            try
            {
                for (int i = 0; i < DataLocal.categories.Count; i++)
                {
                    if (DataLocal.categories[i].Id == id)
                    {
                        DataLocal.categories.RemoveAt(i);
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
