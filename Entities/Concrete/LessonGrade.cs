namespace Entities.Concrete
{
    public class LessonGrade
    {
        public int Id { get; set; }
        public int LessonId { get; set; }
        public int GradeId { get; set; }

        public Lesson Lesson { get; set; }
        public Grade Grade { get; set; }

    }
}
