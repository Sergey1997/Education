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
    public class UserProfileDbModelConfiguration : EntityTypeConfiguration<UserProfile>
    {
        public UserProfileDbModelConfiguration()
        {
            ToTable("UserProfiles");
            HasKey(p => p.Id);
            Property(p => p.Id).HasColumnName("id").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.DateOfCreation).HasColumnName("created_date").IsRequired();
            Property(p => p.Gender).HasColumnName("gender").IsRequired().HasMaxLength(20);
        }
    }
}
