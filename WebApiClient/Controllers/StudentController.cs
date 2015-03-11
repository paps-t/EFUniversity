using DAL;
using DBModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiClient.Controllers
{
    public class StudentController : ApiController
    {
        private UniversityContext context;

        public StudentController()
        {
            context = new UniversityContext();

            //context.Students.Add(new Student { Name = "Nikita", Surname = "Chayka", Age = 19 });
            //context.SaveChanges();
        }

        [HttpPost]
        public IHttpActionResult InsertStudent(Student student)
        {
            try
            {
                context.Students.Add(student);
                context.SaveChanges();
            }
            catch (Exception e)
            {
                return InternalServerError(e);
            }

            return Created<Student>(this.Request.RequestUri, student);
        }

        [HttpPut]
        public HttpResponseMessage UpdateStudent(Student student)
        {
            try
            {
                context.Students.Attach(student);
                context.Entry<Student>(student).State = System.Data.Entity.EntityState.Modified;

                context.SaveChanges();
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e);
            }
            return Request.CreateResponse(HttpStatusCode.OK, student);
        }

        [HttpGet]
        public IEnumerable<Student> GetStudents()
        {
            IEnumerable<Student> students = null;
            try
            {
                students = context.Students.AsEnumerable<Student>();
            }
            catch (Exception e)
            {
                //this.ActionContext.Response.StatusCode = HttpStatusCode.InternalServerError;
            }

            return students;
        }

        [HttpGet]
        public Student GetStudentById(int id)
        {
            Student student = null;
            try
            {
                context = null;
                student = context.Students.FirstOrDefault<Student>(std => std.Id == id);
            }
            catch (Exception e)
            {
                //this.ActionContext.Response.StatusCode = HttpStatusCode.InternalServerError;
            }

            if (student == null) { }
                //this.ActionContext.Response.StatusCode = HttpStatusCode.NotFound;

            return student;
        }

        [HttpDelete]
        public bool DeleteStudent(int id)
        {
            try
            {
                Student student = context.Students.FirstOrDefault<Student>(st => st.Id == id);
                if (student == null)
                {
                    //this.ActionContext.Response.StatusCode = HttpStatusCode.NotFound;
                    return false;
                }

                context.Students.Remove(student);
                context.SaveChanges();
            }
            catch (Exception e)
            {
                //this.ActionContext.Response.StatusCode = HttpStatusCode.InternalServerError;
                return false;
            }

            return true;
        }

        [Route("api/Student/GetStudentsCount")]
        [HttpGet]
        public int GetStudentsCount()
        {
            return context.Students.Count();
        }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
                context.Dispose();

            base.Dispose(disposing);
        }
    }
}
