using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SaanapayForm.Web.Constants;

namespace SaanapayForm.Web.Configurations.EntitiesConfig
{
    public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Id = "21edd8e1-0747-407b-2150-017a5457c337",
                    Name = Roles.Administrator,
                    NormalizedName = Roles.Administrator.ToUpper()
                },
                 new IdentityRole
                 {
                     Id = "21ebb8e1-0747-407cS-2150-017a5457c337",
                     Name = Roles.User,
                     NormalizedName= Roles.User.ToUpper()
                     //Name = "User",
                     //NormalizedName = "USER"
                 }

              );
        }
    }
}