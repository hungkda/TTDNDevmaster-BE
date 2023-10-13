using Microsoft.AspNetCore.Mvc;
using ASP.NET02.Models;
using System.Numerics;

namespace ASP.NET02.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            List<Account> accounts = new List<Account>()
            {
                new Account()
                {
                    Id = 1,
                    Name = "Hung",
                    Email = "ga@ga.com",
                    Phone = "012345678",
                    Address = "Hà Nội",
                    Avatar = Url.Content("~/images/Avatar/01.png"),
                    Gender = 0,
                    Bio = "You are too strong",
                    Birthday = new DateTime(2003,07,08)
                },
                new Account()
                {
                    Id = 2,
                    Name = "Nam",
                    Email = "gacsc@ga.com",
                    Phone = "012345678",
                    Address = "Hà Nội",
                    Avatar = Url.Content("~/images/Avatar/02.png"),
                    Gender = 1,
                    Bio = "You are too strong",
                    Birthday = new DateTime(2003,07,08)
                },
                new Account()
                {
                    Id = 3,
                    Name = "B",
                    Email = "gafc@ga.com",
                    Phone = "012345678",
                    Address = "Hà Nội",
                    Avatar = Url.Content("~/images/Avatar/03.png"),
                    Gender = 1,
                    Bio = "You are too strong",
                    Birthday = new DateTime(2003,07,08)
                },
                new Account()
                {
                    Id = 4,
                    Name = "C",
                    Email = "qwega@ga.com",
                    Phone = "012345678",
                    Address = "Hà Nội",
                    Avatar = Url.Content("~/images/Avatar/04.png"),
                    Gender = 0,
                    Bio = "You are too strong",
                    Birthday = new DateTime(2003,07,08)
                },
                new Account()
                {
                    Id = 5,
                    Name = "F",
                    Email = "gdsa@ga.com",
                    Phone = "012345678",
                    Address = "Hà Nội",
                    Avatar = Url.Content("~/images/Avatar/01.png"),
                    Gender = 1,
                    Bio = "You are too strong",
                    Birthday = new DateTime(2003,07,08)
                },
                new Account()
                {
                    Id = 6,
                    Name = "E",
                    Email = "g12a@ga.com",
                    Phone = "012345678",
                    Address = "Hà Nội",
                    Avatar = Url.Content("~/images/Avatar/02.png"),
                    Gender = 0,
                    Bio = "You are too strong",
                    Birthday = new DateTime(2003,07,08)
                },
            };

            ViewBag.accounts = accounts;
            return View();
        }

        [Route("ho-so-cua-toi", Name = "profile")]
        public IActionResult Profile(int id)
        {
            List<Account> accounts = new List<Account>()
            {
                new Account()
                {
                    Id = 1,
                    Name = "Hung",
                    Email = "ga@ga.com",
                    Phone = "012345678",
                    Address = "Hà Nội",
                    Avatar = Url.Content("~/images/Avatar/01.png"),
                    Gender = 0,
                    Bio = "You are too strong",
                    Birthday = new DateTime(2003,07,08)
                },
                new Account()
                {
                    Id = 2,
                    Name = "Nam",
                    Email = "gacsc@ga.com",
                    Phone = "012345678",
                    Address = "Hà Nội",
                    Avatar = Url.Content("~/images/Avatar/02.png"),
                    Gender = 1,
                    Bio = "You are too strong",
                    Birthday = new DateTime(2003,07,08)
                },
                new Account()
                {
                    Id = 3,
                    Name = "B",
                    Email = "gafc@ga.com",
                    Phone = "012345678",
                    Address = "Hà Nội",
                    Avatar = Url.Content("~/images/Avatar/03.png"),
                    Gender = 1,
                    Bio = "You are too strong",
                    Birthday = new DateTime(2003,07,08)
                },
                new Account()
                {
                    Id = 4,
                    Name = "C",
                    Email = "qwega@ga.com",
                    Phone = "012345678",
                    Address = "Hà Nội",
                    Avatar = Url.Content("~/images/Avatar/04.png"),
                    Gender = 0,
                    Bio = "You are too strong",
                    Birthday = new DateTime(2003,07,08)
                },
                new Account()
                {
                    Id = 5,
                    Name = "F",
                    Email = "gdsa@ga.com",
                    Phone = "012345678",
                    Address = "Hà Nội",
                    Avatar = Url.Content("~/images/Avatar/01.png"),
                    Gender = 1,
                    Bio = "You are too strong",
                    Birthday = new DateTime(2003,07,08)
                },
                new Account()
                {
                    Id = 6,
                    Name = "E",
                    Email = "g12a@ga.com",
                    Phone = "012345678",
                    Address = "Hà Nội",
                    Avatar = Url.Content("~/images/Avatar/02.png"),
                    Gender = 0,
                    Bio = "You are too strong",
                    Birthday = new DateTime(2003,07,08)
                },
            };

            Account account = accounts.FirstOrDefault( a => a.Id == id );
            ViewBag.account = account;
            return View();
        }
    }
}
