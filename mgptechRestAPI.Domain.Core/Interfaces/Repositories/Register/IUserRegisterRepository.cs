using mgptechRestAPI.Application.Dtos.Request;
using mgptechRestAPI.Domain.Entities;
using System.Threading.Tasks;

namespace mgptechRestAPI.Domain.Core.Interfaces.Repositories.Register
{
    public interface IUserRegisterRepository
    {
         Task<bool> Register(User user);
         Task<bool> EmailExists(User user);
    }
}