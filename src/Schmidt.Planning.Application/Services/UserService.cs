using Schmidt.Planning.Data;
using Schmidt.Planning.Domain.Entities;

namespace Schmidt.Planning.Application.Services
{
    internal class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(
            IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public Task<IEnumerable<User>> AllAsync() => Task.FromResult(_userRepository.All);

        public async Task CreateAsync(string name)
        {
            var newUser = new User()
            {
                ID = Guid.NewGuid(),
                Name = name
            };
            _userRepository.Add(newUser);
            await _userRepository.SaveChangesAsync();
        }

        public Task<User> FindAsync(Guid id)
        {
            return Task.FromResult(_userRepository.Find(id));
        }

        public async Task RemoveAsync(Guid id)
        {
            var userToRemove = _userRepository.Find(id);
            _userRepository.Remove(userToRemove);
            await _userRepository.SaveChangesAsync();
        }
    }
}
