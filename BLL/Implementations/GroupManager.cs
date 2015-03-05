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
    public class GroupManager : BaseManager, IGroupManager
    {
        public GroupManager(UnitOfWork uof) : base(uof) { }

        public Group AddGroup(Group group)
        {
            uof.GroupRepository.Insert(group);
            uof.Save();
            return group;
        }


        public IEnumerable<Group> GetGroups()
        {
            try
            {
                return uof.GroupRepository.All.ToList();
            }
            catch (Exception) { }
            return null;
        }

        public Group GetGroupById(int groupId)
        {
            return uof.GroupRepository.GetByID(groupId);
        }

        public void DeleteGroup(Group group)
        {
            uof.GroupRepository.Delete(group);
            uof.Save();
        }

        public void EditGroup(Group group)
        {
            uof.GroupRepository.Update(group);
            uof.Save();
        }
    }
}
