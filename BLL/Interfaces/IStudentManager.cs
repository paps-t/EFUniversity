using DBModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IStudentManager
    {
        Student AddStudent(Student student);
        IEnumerable<Student> GetStudents();
        Student GetStudentById(int studentId);
        void DeleteStudent(Student student);
    }
}
