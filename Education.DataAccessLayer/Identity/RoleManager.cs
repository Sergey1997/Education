using Education.DataAccessLayer.Models.RoleModels;
using Education.DataAccessLayer.Models.UserModels;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education.DataAccessLayer.Identity
{
    public class RoleManager : RoleManager<UserRole>
    {
        public RoleManager(IRoleStore<UserRole> store)
                : base(store)
        {
        }
    }
}
