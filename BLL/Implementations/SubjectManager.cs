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
    public class SubjectManager : BaseManager, ISubjectManager
    {
        public SubjectManager(UnitOfWork uof) : base(uof) { }

        public Subject AddSubject(Subject subject)
        {
            uof.SubjectRepository.Insert(subject);
            uof.Save();
            return subject;
        }

        public IEnumerable<Subject> GetSubjects()
        {
            return uof.SubjectRepository.All.ToList();
        }

        public Subject GetSubjectById(int subjectId)
        {
            return uof.SubjectRepository.GetByID(subjectId);
        }

        public void DeleteSubject(Subject subject)
        {
            uof.SubjectRepository.Delete(subject);
            uof.Save();
        }
    }
}
