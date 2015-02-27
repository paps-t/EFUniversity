using BLL.Implementations;
using BLL.Interfaces;
using DAL;
using DBModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebUniversity.Controllers
{
    public class GroupController : Controller
    {
        public IGroupManager mngr;
        //
        public GroupController()
        {
            mngr = new GroupManager(new UnitOfWork());
        }

        // GET: /Group/
        public ActionResult Index()
        {
            var groups = mngr.GetGroups();
            return View(groups);
        }

        [HttpGet]
        public ActionResult AddGroup()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddGroup(Group group)
        {
            mngr.AddGroup(group);
            return RedirectToAction("Index");
        }
	}
}