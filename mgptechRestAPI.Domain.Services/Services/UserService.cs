using mgptechRestAPI.Domain.Core.Interfaces.Repositories;
using mgptechRestAPI.Domain.Core.Interfaces.Services;
using mgptechRestAPI.Domain.Entities;

namespace mgptechRestAPI.Domain.Service.Services
{
    public class UserService : BaseService<User>, IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository) : base(userRepository)
        {
            _userRepository = userRepository;
        }
    }
}