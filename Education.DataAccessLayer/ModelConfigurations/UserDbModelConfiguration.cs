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
            Property(p => p.UserName).HasColumnName("user_name").IsRequired();
            Property(p => p.Email).HasColumnName("email").IsRequired();
            Property(p => p.PhoneNumber).HasColumnName("phone_number").IsRequired();
        }
    }
}
