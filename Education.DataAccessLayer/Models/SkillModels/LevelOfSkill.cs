using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Education.DataAccessLayer.Models.SkillModels
{
    public class LevelOfSkill
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public virtual ICollection<Skill> Skills { get; set; }
    }
}