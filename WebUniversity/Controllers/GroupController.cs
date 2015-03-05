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
        public GroupController(IGroupManager mngr)
        {
            this.mngr = mngr;
            //mngr = new GroupManager(new UnitOfWork());
        }

        // GET: /Group/
        public ActionResult Index()
        {
            var groups = mngr.GetGroups();
            return View(groups);
        }

        public ActionResult Delete(int id)
        {
            var group = mngr.GetGroupById(id);
            mngr.DeleteGroup(group);
            return RedirectToAction("Index");
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

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var group = mngr.GetGroupById(id);
            return View(group);
        }

        [HttpPost]
        public ActionResult Edit(Group group)
        {
            //var group = mngr.GetGroupById(id);
            mngr.EditGroup(group);
            return RedirectToAction("Index");
        }
    }
}