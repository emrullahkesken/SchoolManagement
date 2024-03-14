namespace Entities.Concrete
{
    public class StudentLesson
    {
        public int Id { get; set; }

        public int StudentId { get; set; }
        public int LessonId { get; set; }

        public Student Student { get; set; }
        public Lesson Lesson { get; set; }

        public StudentLesson(int ıd)
        {
            Id = ıd;
        }
    }
}
