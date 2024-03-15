using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations
{
    public class TeacherConfiguration : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> builder)
        {
            builder.ToTable("Teachers").HasKey(x => x.Id);

            builder.Property(x => x.FirstName).HasColumnName("FirstName").IsRequired().HasMaxLength(50);

            builder.Property(x => x.LastName).HasColumnName("LastName").IsRequired().HasMaxLength(50);

            builder.HasMany(x => x.TeacherStudents)
               .WithOne(x => x.Teacher)
               .HasForeignKey(x => x.TeacherId);

            builder.HasOne(x => x.School);

            builder.HasOne(x => x.Lesson);

            builder.HasQueryFilter(b => !b.DeletedDate.HasValue);
        }
    }
}
