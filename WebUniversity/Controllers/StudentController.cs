using BLL.Interfaces;
using BLL.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL;
using DBModel;
using WebUniversity.Models;

namespace WebUniversity.Controllers
{
    public class StudentController : Controller
    {
        public IStudentManager mngr;
        public IGroupManager grMngr;

        public StudentController(IStudentManager mngr, IGroupManager grMngr)
        {
            this.mngr = mngr;
            this.grMngr = grMngr;
            //mngr = new StudentManager(new UnitOfWork());
        }

        //
        // GET: /Student/
        public ActionResult Index()
        {
            GroupStudents grStudents = new GroupStudents();
            grStudents.Students = mngr.GetStudents();
            grStudents.Groups = grMngr.GetGroups();
            grMngr.GetGroups().Last();
            var students = mngr.GetStudents();
            return View(grStudents);
        }

        public ActionResult Delete(int id)
        {
            var groups = mngr.GetStudentById(id);
            mngr.DeleteStudent(groups);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var groupsMngr = new GroupManager(new UnitOfWork());
            var student = mngr.GetStudentById(id);
            var studModel = new StudentModelView(student);
            studModel.Groups = groupsMngr.GetGroups();
            return View(student);
        }

        [HttpPost]
        public ActionResult Edit(Student student)
        {
            //var group = mngr.GetGroupById(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Add()
        {
            var groupsMan = new GroupManager(new UnitOfWork());
            StudentModelView student = new StudentModelView();
            student.Groups = groupsMan.GetGroups();
            return View(student);
        }

        [HttpPost]
        public ActionResult Add(Student student)
        {
            mngr.AddStudent(student);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult AjaxAdd(Student student)
        {
            mngr.AddStudent(student);
            var model = mngr.GetStudents();//.Last();
            return Json(model);
        }

        public ActionResult AjaxAddForm()
        {
            var groupsMan = new GroupManager(new UnitOfWork());
            return Json(groupsMan.GetGroups());
        }
    }
}