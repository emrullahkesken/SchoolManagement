using Core.Entites.Concrete;

namespace Entities.Concrete
{
    public class Grade : EntityBase
    {
        public double Score { get; set; }
        public virtual ICollection<LessonGrade> LessonGrades { get; set; }
            = new HashSet<LessonGrade>();


    }
}
