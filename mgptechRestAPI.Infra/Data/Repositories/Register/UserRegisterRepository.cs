using mgptechRestAPI.Application.Dtos.Request;
using mgptechRestAPI.Domain.Core.Interfaces.Repositories.Register;
using mgptechRestAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace mgptechRestAPI.Infra.Data.Repositories.Register
{
    public class UserRegisterRepository : IUserRegisterRepository
    {
        private readonly SqlServerContext _sqlServerContext;

        public UserRegisterRepository(SqlServerContext sqlServerContext)
        {
            _sqlServerContext = sqlServerContext;
            _sqlServerContext.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        public async Task<bool> EmailExists(User user)
        {
            IQueryable<User> query = _sqlServerContext.Users
                                        .Where(n => n.Email.Contains(user.Email));

            var found = await query.ToArrayAsync();

            return (found.Length > 0) ? true : false;

        }
      

        public async Task<bool> Register(User user)
        {
            try
            {
                _sqlServerContext.Users.Add(user);
                var created = await _sqlServerContext.SaveChangesAsync();
                return created > 0;

            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}