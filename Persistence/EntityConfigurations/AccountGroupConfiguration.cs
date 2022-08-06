using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Persistence.EntityConfigurations
{
    public class AccountGroupConfiguration : IEntityTypeConfiguration<AccountGroups>
    {
        public void Configure(EntityTypeBuilder<AccountGroups> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(100).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(100).IsRequired();
            builder.Property(x => x.Code).HasPrecision(10, 2);

            builder.HasData(
                new AccountGroups
                {
                    Id = 1,
                    Name = "Godspeed Church",
                    Description = "A faith assembly",
                    Code = 8998
                },
                 new AccountGroups
                 {
                     Id = 2,
                     Name = "Faith Church",
                     Description = "A chosen Race",
                     Code = 8999
                 },
                  new AccountGroups
                  {
                      Id = 3,
                      Name = "Redeemed",
                      Description = "The LORD is here",
                      Code = 8910
                  });
        }
    }
}
