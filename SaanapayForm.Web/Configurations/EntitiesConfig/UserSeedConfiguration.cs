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
                    NormalizedUserName = "ADMIN3@TEST.COM",
                    UserName = "admin3@test.com",
                    Firstname = "System",
                    Lastname = "Admin",
                    PasswordHash = hasher.HashPassword(null, "Admin@123"),
                    EmailConfirmed = true
                },
                 new Employee
                 {
                     Id = "4e9b4d5d-4196-4a1c-9324-0b487b213ce9",
                     Email = "user@test.com",
                     NormalizedEmail = "USER@TEST.COM",
                     NormalizedUserName = "USER@TEST.COM",
                     UserName = "user@test.com",
                     Firstname = "System",
                     Lastname = "User",
                     PasswordHash = hasher.HashPassword(null, "Admin@123"),
                     EmailConfirmed = true
                 }

              );
        }
    }
}