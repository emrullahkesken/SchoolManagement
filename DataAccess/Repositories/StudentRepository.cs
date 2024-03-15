using Business.Services;
using Core.Repositories.Concretes;
using DataAccess.Contexts;
using Entities.Concretes;

namespace DataAccess.Repositories
{
    public class StudentRepository : RepositoryBase<Student, AppDbContext>, IStudentRepository
    {
        public StudentRepository(AppDbContext context) : base(context)
        {
        }
    }
}
