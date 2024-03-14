using Core.Entites.Concrete;

namespace Entities.Concrete
{
    public class School : EntityBase
    {
        public string Name { get; set; }

        public virtual ICollection<Teacher> Teachers { get; set; } = new HashSet<Teacher>();
        public virtual ICollection<Student> Students { get; set; } = new HashSet<Student>();
        public virtual ICollection<Lesson> Lessons { get; set; } = new HashSet<Lesson>();

        public School()
        {

        }

        public School(string name)
        {
            Name = name;
        }
    }
}
