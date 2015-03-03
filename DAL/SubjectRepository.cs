using DBModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SubjectRepository : ISubjectRepository, IDisposable
    {
                private UniversityContext context;

        public SubjectRepository(UniversityContext context)
        {
            this.context = context;
        }

        public IEnumerable<Subject> GetStudents()
        {
            return context.Subjects.ToList();
        }

        public Subject GetSubjectById(int id)
        {
            return context.Subjects.Find(id);
        }

        public void InsertSubjects(Subject subject)
        {
            context.Subjects.Add(subject);
        }

        public void DeleteSubject(int subjectId)
        {
            Subject subject = context.Subjects.Find(subjectId);
            context.Subjects.Remove(subject);
        }

        public void UpdateSubject(Subject subject)
        {
            context.Entry(subject).State = EntityState.Modified;
        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
