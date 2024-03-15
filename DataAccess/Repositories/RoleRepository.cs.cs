using Business.Services;
using Core.Repositories.Concretes;
using DataAccess.Contexts;
using Entities.Concretes;

namespace DataAccess.Repositories
{
    public class RoleRepository : RepositoryBase<Role, AppDbContext>, IRoleRepository
    {
        public RoleRepository(AppDbContext context) : base(context)
        {
        }
    }
}
