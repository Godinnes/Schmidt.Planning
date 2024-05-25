using Schmidt.Planning.Common.Abstractions;

namespace Schmidt.Planning.Data
{
    public interface IRepository<TEntity>
        where TEntity : IEntity
    {
        TEntity Find(Guid id);
        IEnumerable<TEntity> All { get; }
        void Add(TEntity entity);
        void Remove(TEntity entity);
        Task SaveChangesAsync();
    }
}
