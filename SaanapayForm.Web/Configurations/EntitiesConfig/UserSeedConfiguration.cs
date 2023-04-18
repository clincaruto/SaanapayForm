using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SaanapayForm.Web.Models.Domain;

namespace SaanapayForm.Web.Configurations.EntitiesConfig
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasData(
                new Employee
                {
                    Id = "11bdd8e1-0747-407b-8850-017a5457c337",
                    Email = ""
                }

              );
        }
    }
}