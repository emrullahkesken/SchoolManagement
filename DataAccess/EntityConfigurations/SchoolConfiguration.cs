using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations
{
    public class SchoolConfiguration : IEntityTypeConfiguration<School>
    {
        public void Configure(EntityTypeBuilder<School> builder)
        {

            builder.ToTable("Schools").HasKey(x => x.Id);

            builder.Property(x => x.Name).HasColumnName("Name").IsRequired().HasMaxLength(50);

            builder.HasMany(x => x.Teachers);

            builder.HasMany(x => x.Students);

            builder.HasMany(x => x.Lessons);

            builder.HasQueryFilter(b => !b.DeletedDate.HasValue);

        }
    }
}
