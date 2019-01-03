namespace Education.DataAccessLayer.Migrations
{
    using Education.DataAccessLayer.Models.RoleModels;
    using Education.DataAccessLayer.Models.UserModels;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Education.DataAccessLayer.Context.EducationContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Education.DataAccessLayer.Context.EducationContext db)
        {

            db.Roles.Add(new UserRole { Description = "admin" });
            db.Users.Add(new User { Login = "Sergey", Gender = "M", Password = "Pass", PhoneNumber = "+375291638636", Email = "serdanilovich@mail.ru", Name = "Sergey"});
            db.CategoryOfSkills.Add(new Models.SkillModels.CategoryOfSkill { CategoryId = 1, Description = "Programming" })
            db.Skills.Add(new Models.SkillModels.Skill { Id = 1, CategoryId = 1, Description = ".NET skill",Name = ".NET"});
            db.SaveChanges();
        }
    }
}