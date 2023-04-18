using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SaanapayForm.Web.Configurations.EntitiesConfig
{
    internal class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId= "21edd8e1-0747-407b-2150-017a5457c337",
                    UserId= "a565265f-3bc4-495d-95c7-0d8bfe2564d3"
                },
                 new IdentityUserRole<string>
                 {
                     RoleId = "21ebb8e1-0747-407cS-2150-017a5457c337",
                     UserId = "4e9b4d5d-4196-4a1c-9324-0b487b213ce9"
                 }

             );
        }
    }
}