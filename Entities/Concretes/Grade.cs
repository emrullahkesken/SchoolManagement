﻿using Core.Entites.Concretes;

namespace Entities.Concretes
{
    public class Grade : EntityBase
    {
        public double Score { get; set; }
        public virtual ICollection<LessonGrade> LessonGrades { get; set; }
            = new HashSet<LessonGrade>();


    }
}
