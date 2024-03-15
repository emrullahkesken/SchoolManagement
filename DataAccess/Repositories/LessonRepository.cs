using Business.Services;
using Core.Repositories.Concretes;
using DataAccess.Contexts;
using Entities.Concretes;

namespace DataAccess.Repositories
{
    public class LessonRepository : RepositoryBase<Lesson, AppDbContext>, ILessonRepository
    {
        public LessonRepository(AppDbContext context) : base(context)
        {
        }
    }
}
