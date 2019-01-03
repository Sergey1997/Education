using Education.DataAccessLayer.Models.SkillModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education.DataAccessLayer.Models.UserModels
{
    public class UserProfile
    {
        [Key]
        [ForeignKey("User")]
        public string Id { get; set; }
        public virtual User User { get; set; }
        public DateTime? DateOfCreation { get; set; } = DateTime.Now;
        public string Gender { get; set; }
        public virtual ICollection<TaskModels.Task> Tasks { get; set; }
        public virtual ICollection<Skill> Skills { get; set; }
        public UserProfile()
        {
            Tasks = new List<TaskModels.Task>();
            Skills = new List<Skill>();
        }
    }
}
