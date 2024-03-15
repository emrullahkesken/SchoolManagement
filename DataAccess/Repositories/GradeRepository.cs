using Business.Services;
using Core.Repositories.Concretes;
using DataAccess.Contexts;
using Entities.Concretes;

namespace DataAccess.Repositories
{
    public class GradeRepository : RepositoryBase<Grade, AppDbContext>, IGradeRepository
    {
        public GradeRepository(AppDbContext context) : base(context)
        {
        }
    }
}
