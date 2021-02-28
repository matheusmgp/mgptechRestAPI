using mgptechRestAPI.Application.Dtos.Request;
using mgptechRestAPI.Application.Dtos.Response;
using mgptechRestAPI.Domain.Entities;

namespace mgptechRestAPI.Domain.Core.Interfaces.Services
{
    public interface IUserAuthService
    {
        string GenerateTokem(UserAuthDtoResponse userAuthDtoResponse);
        User Authenticate(UserAuthDtoRequest userAuthDtoRequest);
    }
}