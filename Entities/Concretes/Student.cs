using Core.Entites.Concretes;

namespace Entities.Concretes
{
    public class Student : EntityBase
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Number { get; set; }
        public int SchoolId { get; set; }

        public School School { get; set; }
        public virtual ICollection<TeacherStudent> TeacherStudents { get; set; }
            = new HashSet<TeacherStudent>();
        public virtual ICollection<StudentLesson> StudentLessons { get; set; }
            = new HashSet<StudentLesson>();

        public Student()
        {

        }

        public Student(string firstName, string lastName, int number, int schoolId)
        {
            FirstName = firstName;
            LastName = lastName;
            Number = number;
            SchoolId = schoolId;
        }
    }
}
