using DBModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace DAL
{
    public interface IGroupRepository : IDisposable
    {
        IEnumerable<Group> GetGroups();
        Group GetGroupById(int groupId);
        void InsertGroup(Group group);
        void DeleteGroup(int groupId);
        void UpdateGroup(Group group);
        void Save();
    }
}
