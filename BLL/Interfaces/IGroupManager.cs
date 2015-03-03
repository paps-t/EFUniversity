using DBModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IGroupManager
    {
        Group AddGroup(Group group);
        IEnumerable<Group> GetGroups();
        Group GetGroupById(int groupId);
        void DeleteGroup(Group group);
    }
}
