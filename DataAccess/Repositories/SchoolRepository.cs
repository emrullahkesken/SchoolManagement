using Business.Services;
using Core.Repositories.Concretes;
using DataAccess.Contexts;
using Entities.Concretes;

namespace DataAccess.Repositories
{
    public class SchoolRepository : RepositoryBase<School, AppDbContext>, ISchoolRepository
    {
        public SchoolRepository(AppDbContext context) : base(context)
        {
        }
    }
}
