using System;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Education.DataAccessLayer.Models.UserModels;
using System.Data.Entity;
using Education.DataAccessLayer.Models.RoleModels;
using Education.DataAccessLayer.Initialize;
using Aggregator.DataAccess.ModelConfigurations;

namespace Education.DataAccessLayer.Context
{
    public class EducationContext : IdentityDbContext<User>
    {
        static EducationContext()
        {
           // Database.SetInitializer<EducationContext>(new EducationDbInitializer());
        }
        public EducationContext() : base("EducationDB") { }

        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<UserRoleProfile> RoleProfiles { get; set; }
        public DbSet<Models.TaskModels.Task> Tasks { get; set; }
        public DbSet<Models.SkillModels.Skill> Skills { get; set; }
        public DbSet<Models.SkillModels.CategoryOfSkill> CategoryOfSkills { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserDbModelConfiguration());
            modelBuilder.Configurations.Add(new UserProfileDbModelConfiguration());
            base.OnModelCreating(modelBuilder);
        }

    }
}
