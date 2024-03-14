using Core.Entites.Concrete;

namespace Entities.Concrete
{
    public class Teacher : EntityBase
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int LessonId { get; set; }
        public virtual Lesson Lesson { get; set; }

        public int SchoolId { get; set; }
        public virtual School School { get; set; }

        public virtual ICollection<TeacherStudent> TeacherStudents { get; set; }
            = new HashSet<TeacherStudent>();

        public Teacher()
        {

        }

        public Teacher(string firstName, string lastName, int lessonId)
        {
            FirstName = firstName;
            LastName = lastName;
            LessonId = lessonId;
        }
    }
}
