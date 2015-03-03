using DBModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface ISubjectManager
    {
        Subject AddSubject(Subject subject);
        IEnumerable<Subject> GetSubjects();
        Subject GetSubjectById(int subjectId);
        void DeleteSubject(Subject subject);
    }
}
