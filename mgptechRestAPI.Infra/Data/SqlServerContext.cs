using mgptechRestAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace mgptechRestAPI.Infra.Data
{
    public class SqlServerContext : DbContext
    {
        public SqlServerContext(DbContextOptions<SqlServerContext> options) : base(options)
        {
        }

        private DbSet<Ambiente> Ambientes { get; set; }
        private DbSet<Role> Roles { get; set; }
        private DbSet<User> Users { get; set; }
    }
}