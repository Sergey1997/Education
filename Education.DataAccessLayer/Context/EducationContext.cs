using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Education.DataAccessLayer.Models.UserModels;
using System.Data.Entity;
using Education.DataAccessLayer.Models.RoleModels;
using Aggregator.DataAccess.ModelConfigurations;

namespace Education.DataAccessLayer.Context
{
    public class EducationContext : DbContext
    {
        static EducationContext()
        {
            // Database.SetInitializer<EducationContext>(new EducationDbInitializer());
        }
        public EducationContext() : base("EducationDB") { }

        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> Roles { get; set; }
        public DbSet<Models.TaskModels.Task> Tasks { get; set; }
        public DbSet<Models.SkillModels.Skill> Skills { get; set; }
        public DbSet<Models.SkillModels.CategoryOfSkill> CategoryOfSkills { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserDbModelConfiguration());
            base.OnModelCreating(modelBuilder);
        }

    }
}
