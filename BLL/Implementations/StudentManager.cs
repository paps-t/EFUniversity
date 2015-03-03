using BLL.Interfaces;
using DAL;
using DBModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Implementations
{
    public class StudentManager : BaseManager, IStudentManager
    {
        public StudentManager(UnitOfWork uof) : base(uof) { }

        public Student AddStudent(Student student)
        {
            uof.StudentRepository.Insert(student);
            uof.Save();
            return student;
        }

        public IEnumerable<Student> GetStudents()
        {
            return uof.StudentRepository.All.ToList();
        }

        public Student GetStudentById(int studentId)
        {
            return uof.StudentRepository.GetByID(studentId);
        }

        public void DeleteStudent(Student student)
        {
            uof.StudentRepository.Delete(student);
            uof.Save();
        }

    }
}
