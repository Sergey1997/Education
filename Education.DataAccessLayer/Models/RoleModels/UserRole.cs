using Education.DataAccessLayer.Models.UserModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Education.DataAccessLayer.Models.RoleModels
{
    public class UserRole
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime? DateOfCreation { get; set; } = DateTime.Now;
        public virtual ICollection<User> Users { get; set; }
    }
}