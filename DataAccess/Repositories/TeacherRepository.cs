using Business.Services;
using Core.Repositories.Concretes;
using DataAccess.Contexts;
using Entities.Concretes;

namespace DataAccess.Repositories
{
    public class TeacherRepository : RepositoryBase<Teacher, AppDbContext>, ITeacherRepository
    {
        public TeacherRepository(AppDbContext context) : base(context)
        {
        }
    }
}
