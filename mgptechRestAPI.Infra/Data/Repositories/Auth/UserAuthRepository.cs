using mgptechRestAPI.Application.Dtos.Request;
using mgptechRestAPI.Domain.Core.Interfaces.Repositories.Auth;
using mgptechRestAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;

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
            var user = _sqlServerContext.Users.Where(x =>
                        x.Email == userAuthDtoRequest.Email
                        && x.Senha == userAuthDtoRequest.Senha).FirstOrDefault();

            if (user == null)
                return null;

            return user;
        }
    }
}