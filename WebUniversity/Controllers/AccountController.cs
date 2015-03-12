using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebUniversity.Models;

namespace WebUniversity.Controllers
{
    public class AccountController : Controller
    {
        //
        // GET: /Action/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View(new Login());
        }
	}
}