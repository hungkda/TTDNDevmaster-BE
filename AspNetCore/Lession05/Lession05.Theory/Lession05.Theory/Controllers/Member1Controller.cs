using Lession05.Theory.Models.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lession05.Theory.Controllers
{
    public class Member1Controller : Controller
    {
        public static List<MemberView> members = new List<MemberView>();
        // GET: MemberViewController
        public ActionResult Index()
        {
            
            return View(members);
        }

        // GET: MemberViewController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MemberViewController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MemberViewController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MemberView member)
        {

            if(ModelState.IsValid)
            {
                members.Add(member);
                return RedirectToAction(nameof(Index));
            } else
            {
                return View(member);
            }
        }

        // GET: MemberViewController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MemberViewController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MemberViewController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MemberViewController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
