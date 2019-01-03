using Education.DataAccessLayer.Models.SkillModels;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Education.DataAccessLayer.Models.UserModels
{
    public class User : IdentityUser
    {
        public virtual UserProfile UserProfile { get; set; }
    }
}
