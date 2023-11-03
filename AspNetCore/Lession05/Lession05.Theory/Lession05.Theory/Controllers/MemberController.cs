using Lession05.Theory.Models.DataModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.RegularExpressions;

namespace Lession05.Theory.Controllers
{
    public class MemberController : Controller
    {
        public static List<Member> members = new List<Member>();
        // GET: MemberController
        public ActionResult Index()
        {
            return View(members);
        }

        // GET: MemberController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MemberController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MemberController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Member member)
        {
            string msg = "";
            bool validate = true;

            if (member.UserName.Length < 3 || member.UserName.Length > 20)
            {
                msg += "<li>Username có độ dài từ 3-10 kí tự</li>";
                validate = false;
            }

            string patternemail = @"[a-zA-Z0-9._+-]+@[a-z0-9._]+\.[a-z]{2,4}$";
            if (!Regex.IsMatch(member.Email, patternemail))
            {
                msg += "<li>Email chưa đúng định dạng (abc@gmail.com)</li>";
                validate = false;
            }

            if (member.Birthday.Value.AddYears(18) > DateTime.Now)
            {
                msg += "<li>Bạn chưa đủ 18 tuổi</li>";
                validate = false;
            }

            string patternPhone = @"^0\d{9,12}$";
            if (!Regex.IsMatch(member.Phone, patternPhone))
            {
                msg += "<li>Số điện thoại chưa đúng</li>";
                validate = false;
            }

            if (validate)
            {
                member.MemberId = new Guid().ToString();
                members.Add(member);
                return RedirectToAction(nameof(Index));
            }
            else
            {
                ViewBag.msg = "<div>" + msg + "</div>";
                return View(member);
            }
        }

        // GET: MemberController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MemberController/Edit/5
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

        // GET: MemberController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MemberController/Delete/5
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
