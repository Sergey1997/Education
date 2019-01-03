using Education.DataAccessLayer.Models.RoleModels;
using Education.DataAccessLayer.Models.SkillModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Education.DataAccessLayer.Models.UserModels
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public DateTime? DateOfCreation { get; set; } = DateTime.Now;
        public string Gender { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public virtual ICollection<TaskModels.Task> Tasks { get; set; }
        public virtual ICollection<Skill> Skills { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
        public User()
        {
            Tasks = new List<TaskModels.Task>();
            Skills = new List<Skill>();
        }
    }
}
