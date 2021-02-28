using mgptechRestAPI.Application.Dtos.Request;
using mgptechRestAPI.Domain.Core.Interfaces.Repositories.Auth;
using mgptechRestAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using BC = BCrypt.Net.BCrypt;

namespace mgptechRestAPI.Infra.Data.Repositories.Auth
{
    internal class UserAuthRepository : IUserAuthRepository
    {
        private readonly SqlServerContext _sqlServerContext;

        public UserAuthRepository(SqlServerContext sqlServerContext)
        {
            _sqlServerContext = sqlServerContext;
            _sqlServerContext.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        public User Authenticate(UserAuthDtoRequest userAuthDtoRequest)
        {
            var userFoundByEmail = _sqlServerContext.Users.Where(x =>
                        x.Email == userAuthDtoRequest.Email).FirstOrDefault();
            if (userFoundByEmail == null || !BC.Verify(
                userAuthDtoRequest.Senha, userFoundByEmail.Senha))
            {
                // authentication failed
                return null;
            }          

            return userFoundByEmail;
        }
    }
}