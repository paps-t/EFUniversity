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

        public StudentController(IStudentManager mngr)
        {
            this.mngr = mngr;
            //mngr = new StudentManager(new UnitOfWork());
        }

        //
        // GET: /Student/
        public ActionResult Index()
        {
            var students = mngr.GetStudents();
            return View(students);
        }

        public ActionResult Delete(int id)
        {
            var groups = mngr.GetStudentById(id);
            mngr.DeleteStudent(groups);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult AddStudent()
        {
            var groupsMan = new GroupManager(new UnitOfWork());
            StudentModelView student = new StudentModelView();
            student.Groups = groupsMan.GetGroups();
            return View(student);
        }

        [HttpPost]
        public ActionResult AddStudent(Student student)
        {
            mngr.AddStudent(student);
            return RedirectToAction("Index");
        }
    }
}