using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Education.DataAccessLayer.Context;
using Education.DataAccessLayer.Models.RoleModels;
using Education.DataAccessLayer.Models.UserModels;

namespace Education.DataAccessLayer.Initialize
{
    public class EducationDbInitializer : DropCreateDatabaseIfModelChanges<Context.EducationContext>
    {
        protected override void Seed(EducationContext db)
        {
            UserRoleProfile up1 = new UserRoleProfile() { Description = "default user" };
            db.RoleProfiles.Add(up1);
            db.Roles.Add(new UserRole { Name = "User", UserRoleProfile = up1 });

            UserProfile u1 = new UserProfile() { Gender = "M" };
            db.UserProfiles.Add(u1);
            db.Users.Add(new User { UserName = "Sergey", Email = "serdanilovich@mail.ru", PhoneNumber = "+375291638636", UserProfile = u1 });
            db.SaveChanges();
        }
    }
}
