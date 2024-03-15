namespace Core.Repositories.Abstracts
{
    public interface IQuery<TEntity>
    {
        IQueryable<TEntity> Query();
    }
}
