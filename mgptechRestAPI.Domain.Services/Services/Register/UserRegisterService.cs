using mgptechRestAPI.Domain.Core.Interfaces.Repositories.Register;
using mgptechRestAPI.Domain.Core.Interfaces.Services.Register;
using mgptechRestAPI.Domain.Entities;
using System.Threading.Tasks;

namespace mgptechRestAPI.Domain.Service.Services.Register
{
    public class UserRegisterService : IUserRegisterService
    {
        private readonly IUserRegisterRepository _userRegisterRepository;

        public UserRegisterService(IUserRegisterRepository userRegisterRepository)
        {
            _userRegisterRepository = userRegisterRepository;
        }

        public Task<bool> EmailExists(User user)
        {
            return _userRegisterRepository.EmailExists(user);
        }

        public Task<bool> Register(User user)
        {
            return _userRegisterRepository.Register(user);
        }
    }
}