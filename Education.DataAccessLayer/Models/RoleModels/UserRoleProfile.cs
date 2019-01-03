using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education.DataAccessLayer.Models.RoleModels
{
    public class UserRoleProfile
    {
        [Key]
        [ForeignKey("UserRole")]
        public string Id { get; set; }
        public virtual UserRole UserRole { get; set; }

        public DateTime? DateOfCreation { get; set; } = DateTime.Now;
        public string Description { get; set; }
        public UserRoleProfile() { }
    }
}
