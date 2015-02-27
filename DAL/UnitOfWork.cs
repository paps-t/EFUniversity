using DAL.Repo;
using DBModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UnitOfWork : IDisposable
    {
        private UniversityContext context;
        private GenericRepository<Group> groupRepo;
        private GenericRepository<Student> studentRepo;
        private GenericRepository<Subject> subjectRepo;
        
        public UnitOfWork()
        {
            context = new UniversityContext();

        }

        public GenericRepository<Group> GroupRepository
        {
            get
            {
                if (groupRepo == null) groupRepo = new GenericRepository<Group>(context);
                return groupRepo;
            }
        }

        public GenericRepository<Student> StudentRepository
        {
            get
            {
                if (studentRepo == null) studentRepo = new GenericRepository<Student>(context);
                return studentRepo;
            }
        }

        public GenericRepository<Subject> SubjectRepository
        {
            get
            {
                if (subjectRepo == null) subjectRepo = new GenericRepository<Subject>(context);
                return subjectRepo;
            }
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
