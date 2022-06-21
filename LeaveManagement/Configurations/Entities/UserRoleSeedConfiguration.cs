using LeaveManagement.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Configurations.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    UserId = "1d39cc8e-111d-47e8-1117-b5fc36f048cc",
                    RoleId = "8d39cc8e-771d-47e8-2117-b5fc36f048cc" 

                },
                new IdentityUserRole<string>
                {
                    UserId = "2d39cc8e-222b-47e8-2227-b5fc36f048cc",
                    RoleId = "9d39cc8e-441d-47e8-3221-b5fc36f048cc",

                }

             );
        }
    }
}