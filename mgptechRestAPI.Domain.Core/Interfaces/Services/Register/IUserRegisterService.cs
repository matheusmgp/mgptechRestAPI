using mgptechRestAPI.Application.Dtos.Request;
using mgptechRestAPI.Domain.Entities;
using System.Threading.Tasks;

namespace mgptechRestAPI.Domain.Core.Interfaces.Services.Register
{
    public interface IUserRegisterService
    {
        Task<bool> Register(User user);
        Task<bool> EmailExists(User user);
    }
}