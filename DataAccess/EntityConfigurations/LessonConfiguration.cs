using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations
{
    public class LessonConfiguration : IEntityTypeConfiguration<Lesson>
    {

        public void Configure(EntityTypeBuilder<Lesson> builder)
        {
            builder.ToTable("Lessons").HasKey(x => x.Id);

            builder.Property(x => x.Name).HasColumnName("Name").IsRequired().HasMaxLength(50);

            builder.HasMany(x => x.StudentLessons)
                   .WithOne(x => x.Lesson)
                   .HasForeignKey(x => x.LessonId);

            builder.HasMany(x => x.Teachers);

            builder.HasMany(x => x.LessonGrades)
                   .WithOne(x => x.Lesson)
                   .HasForeignKey(x => x.LessonId);

            builder.HasOne(x => x.School);

            builder.HasQueryFilter(b => !b.DeletedDate.HasValue);
        }
    }
}
