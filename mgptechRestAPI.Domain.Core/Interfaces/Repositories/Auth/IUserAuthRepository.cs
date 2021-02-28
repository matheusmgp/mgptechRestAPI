using mgptechRestAPI.Application.Dtos.Request;
using mgptechRestAPI.Domain.Entities;

namespace mgptechRestAPI.Domain.Core.Interfaces.Repositories.Auth
{
    public interface IUserAuthRepository
    {
        User Authenticate(UserAuthDtoRequest userAuthDtoRequest);
    }
}