using Microsoft.Extensions.Configuration;
using Schmidt.Planning.Domain.Entities;

namespace Schmidt.Planning.Data.Services
{
    internal class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(IConfiguration configuration)
            : base(configuration) { }
    }
}
