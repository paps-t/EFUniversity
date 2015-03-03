using DBModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace DAL
{
    public class GroupToSubjectRepository : IGroupToSubjectRepository, IDisposable
    {
        private UniversityContext context;

        public GroupToSubjectRepository(UniversityContext context)
        {
            this.context = context;
        }


        public IEnumerable<GroupToSubject> GetGTS()
        {
            return context.GroupsToSubjects.ToList();
        }

        public GroupToSubject GetGTSById(int id)
        {
            return context.GroupsToSubjects.Find(id);
        }

        public void InsertGTS(GroupToSubject gts)
        {
            context.GroupsToSubjects.Add(gts);
        }

        public void DeleteGTS(int gtsId)
        {
            GroupToSubject gts = context.GroupsToSubjects.Find(gtsId);
            context.GroupsToSubjects.Remove(gts);
        }

        public void UpdateGTS(GroupToSubject gts)
        {
            context.Entry(gts).State = EntityState.Modified;
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
