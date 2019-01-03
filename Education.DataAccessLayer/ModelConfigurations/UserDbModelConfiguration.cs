using Education.DataAccessLayer.Models.UserModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Aggregator.DataAccess.ModelConfigurations
{
    public class UserDbModelConfiguration : EntityTypeConfiguration<User>
    {
        public UserDbModelConfiguration()
        {
            ToTable("Users");
            HasKey(p => p.Id);
            Property(p => p.Id).HasColumnName("id").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.Login).HasColumnName("login").IsRequired();
            Property(p => p.Password).HasColumnName("password").IsRequired();
            Property(p => p.PhoneNumber).HasColumnName("phone_number").IsRequired();
            Property(p => p.Email).HasColumnName("email").IsRequired();
            Property(p => p.Gender).HasColumnName("gender").IsRequired();
            Property(p => p.DateOfCreation).HasColumnName("create_date").IsRequired();

        }
    }
}
