using Schmidt.Planning.Domain.Entities;

namespace Schmidt.Planning.Application
{
    public interface IUserService
    {
        public Task<IEnumerable<User>> AllAsync();
        public Task<User> FindAsync(Guid id);
        public Task CreateAsync(string name);
        public Task RemoveAsync(Guid id);
    }
}
