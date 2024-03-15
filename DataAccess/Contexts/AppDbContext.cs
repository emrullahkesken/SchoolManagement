using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace DataAccess.Contexts
{
    public class AppDbContext : DbContext
    {
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<LessonGrade> LessonGrades { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<School> Schools { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentLesson> StudentLessons { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<TeacherStudent> TeacherStudents { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }




    }
}
