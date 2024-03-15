using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations
{
    internal class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.ToTable("Roles").HasKey(x => x.Id);

            builder.Property(x => x.Name).HasColumnName("Name").IsRequired().HasMaxLength(50);

            builder.HasQueryFilter(b => !b.DeletedDate.HasValue);

        }
    }
}
