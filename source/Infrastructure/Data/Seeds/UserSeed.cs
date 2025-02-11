using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Domain.Constants;
using Project.Domain.Entities;

namespace Project.Infrastructure.Data.Seeds;

internal class UserSeed : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasData(
            new User
            (
                id: new Guid("f7d4d7a9-4d1e-4a8d-9a8e-9b9a9b9a9b9e"),
                username: "admin",
                password: "secretaria",
                email: "admin@admin.com",
                roleId: RoleConstants.Admin
            ),
            new User
            (
                id: new Guid("f7d4d7a9-4d1e-4a8d-9a8e-9b9a9b9a9b9f"),
                username: "user",
                password: "secretaria",
                email: "user@user.com",
                roleId: RoleConstants.User
            )
        );
    }
}
