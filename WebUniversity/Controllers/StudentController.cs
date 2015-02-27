using BLL.Interfaces;
using BLL.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebUniversity.Controllers
{
    public class StudentController : Controller
    {
        public IStudentManager mngr;

        public StudentController()
        {
            mngr = new StudentManager();
        }

        //
        // GET: /Student/
        public ActionResult Index()
        {
            return View();
        }
	}
}