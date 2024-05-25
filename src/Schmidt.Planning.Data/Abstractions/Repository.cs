using Microsoft.Extensions.Configuration;
using Schmidt.Planning.Common.Abstractions;

namespace Schmidt.Planning.Data
{
    internal abstract class Repository<TEntity> : IRepository<TEntity>
        where TEntity : IEntity
    {
        private readonly List<TEntity> _entities;
        private readonly string _repository;
        public Repository(IConfiguration configuration)
        {
            _entities = new List<TEntity>();
        }
        public TEntity Find(Guid id)
        {
            return _entities.Find(e => e.ID == id);
        }
        public IEnumerable<TEntity> All => _entities;
        public void Add(TEntity entity)
        {
            _entities.Add(entity);
        }
        public void Remove(TEntity entity)
        {
            _entities.Remove(entity);
        }
        public async Task SaveChangesAsync()
        {
        }
    }
}
