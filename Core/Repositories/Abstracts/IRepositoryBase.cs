using Core.Entites.Concretes;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace Core.Repositories.Abstracts
{
    public interface IRepositoryBase<TEntity> : IQuery<TEntity>
        where TEntity : EntityBase
    {
        Task<TEntity?> GetAsync(
            Expression<Func<TEntity, bool>> predicate,
            Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null,
            bool withDeleted = false,
            bool enableTracking = true,
            CancellationToken cancellationToken = default);

        Task<ICollection<TEntity>> GetListAsync(
            Expression<Func<TEntity, bool>>? predicate = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null,
            Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null,
            bool withDeleted = false,
            bool enableTracking = true,
            CancellationToken cancellationToken = default);


        Task<bool> AnyAsync(
           Expression<Func<TEntity, bool>>? predicate = null,
           bool withDeleted = false,
           bool enableTracking = true,
           CancellationToken cancellationToken = default);

        Task<TEntity> AddAsync(TEntity entity);

        Task<ICollection<TEntity>> AddRangeAsync(ICollection<TEntity> entities);

        Task<TEntity> UpdateAsync(TEntity entity);

        Task<ICollection<TEntity>> UpdateRangeAsync(ICollection<TEntity> entities);

        Task<TEntity> DeleteAsync(TEntity entity, bool permanent = false);

        Task<ICollection<TEntity>> DeleteRangeAsync(ICollection<TEntity> entities, bool permanent = false);
    }
}
