using Core.Entites.Concretes;

namespace Entities.Concretes
{
    public class Lesson : EntityBase
    {

        public string Name { get; set; }

        public int SchoolId { get; set; }
        public School School { get; set; }

        public virtual ICollection<Teacher> Teachers { get; set; }
            = new HashSet<Teacher>();
        public virtual ICollection<StudentLesson> StudentLessons { get; set; }
            = new HashSet<StudentLesson>();
        public virtual ICollection<LessonGrade> LessonGrades { get; set; }
            = new HashSet<LessonGrade>();

        public Lesson(string name)
        {
            Name = name;
        }
    }
}
