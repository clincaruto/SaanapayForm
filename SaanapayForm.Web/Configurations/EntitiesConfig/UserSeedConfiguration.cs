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
            var hasher = new PasswordHasher<Employee>();
            builder.HasData(
                new Employee
                {
                    Id = "a565265f-3bc4-495d-95c7-0d8bfe2564d3",
                    Email = "admin3@test.com",
                    NormalizedEmail = "ADMIN3@TEST.COM",
                    Firstname = "System",
                    Lastname = "Admin",
                    PasswordHash = hasher.HashPassword(null, "Admin@123")
                }

              );
        }
    }
}