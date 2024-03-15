using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.ToTable("Students").HasKey(x => x.Id);

            builder.Property(x => x.FirstName).HasColumnName("FirstName").IsRequired().HasMaxLength(50);

            builder.Property(x => x.LastName).HasColumnName("LastName").IsRequired().HasMaxLength(50);

            builder.Property(x => x.Number).HasColumnName("Number").IsRequired().HasMaxLength(50);
            builder.HasOne(x => x.School);

            builder.HasMany(x => x.TeacherStudents)
                .WithOne(x => x.Student)
                .HasForeignKey(x => x.StudentId);

            builder.HasMany(x => x.StudentLessons)
               .WithOne(x => x.Student)
               .HasForeignKey(x => x.StudentId);

            builder.HasQueryFilter(b => !b.DeletedDate.HasValue);

        }
    }
}
