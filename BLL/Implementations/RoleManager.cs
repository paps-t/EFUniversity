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
    public class RoleManager : BaseManager, IRoleManager
    {
        /*public RoleManager(UnitOfWork uof)
            : base(uof)
        {
        }

        public IEnumerable<Role> GetRoles()
        {
            return uof.RoleRepository.Get().ToList();
        }

        public Role GetRoleById(int roleId)
        {
            return uof.RoleRepo.GetByID(roleId);
        }

        public Role InsertRole(DBModels.Role role)
        {
            uOW.RoleRepo.Insert(role);
            uOW.Save();
            return role;
        }

        public void DeleteRole(int roleId)
        {
            uOW.RoleRepo.Delete(uOW.RoleRepo.GetByID(roleId));
            uOW.Save();
        }

        public DBModels.Role UpdateRole(DBModels.Role role)
        {
            uOW.RoleRepo.Update(role);
            uOW.Save();
            return role;
        }

        public DBModels.Role GetRoleByName(string name)
        {
            return uOW.RoleRepo.Get().Where(s => s.Name == name).FirstOrDefault();
        }*/
    }
}
