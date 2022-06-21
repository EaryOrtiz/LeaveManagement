using LeaveManagement.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Configurations.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            var hasher = new PasswordHasher<Employee>();
            builder.HasData(
                new Employee
                {
                    Id = "1d39cc8e-111d-47e8-1117-b5fc36f048cc",
                    Email = "admin@localhost.com",
                    NormalizedEmail = "ADMIN@LOCALHOT.COM",
                    UserName = "admin@localhost.com",
                    NormalizedUserName = "ADMIN@LOCALHOT.COM",
                    FirstName = "System",
                    LastName = "Admin",
                    PasswordHash = hasher.HashPassword(null, "Pa55word$"),
                    EmailConfirmed = true
                },
                new Employee
                {
                    Id = "2d39cc8e-222b-47e8-2227-b5fc36f048cc",
                    Email = "user@localhost.com",
                    NormalizedEmail = "USER@LOCALHOT.COM",
                    UserName = "user@localhost.com",
                    NormalizedUserName = "USER@LOCALHOT.COM",
                    FirstName = "Default",
                    LastName = "User",
                    PasswordHash = hasher.HashPassword(null, "Pa55word$"),
                    EmailConfirmed = true
                }
             );
        }
    }
}