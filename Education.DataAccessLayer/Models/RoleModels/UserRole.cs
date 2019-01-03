using Education.DataAccessLayer.Models.UserModels;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Education.DataAccessLayer.Models.RoleModels
{
    public class UserRole : IdentityRole
    {
        public virtual UserRoleProfile UserRoleProfile { get; set; }
    }
}