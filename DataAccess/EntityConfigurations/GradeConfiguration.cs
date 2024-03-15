using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations
{
    public class GradeConfiguration : IEntityTypeConfiguration<Grade>
    {

        public void Configure(EntityTypeBuilder<Grade> builder)
        {
            builder.ToTable("Grades").HasKey(x => x.Id);

            builder.Property(x => x.Score).HasColumnName("Score").IsRequired().HasMaxLength(50);

            builder.HasMany(x => x.LessonGrades)
                   .WithOne(x => x.Grade)
                   .HasForeignKey(x => x.GradeId);

            builder.HasQueryFilter(b => !b.DeletedDate.HasValue);
        }
    }
}
