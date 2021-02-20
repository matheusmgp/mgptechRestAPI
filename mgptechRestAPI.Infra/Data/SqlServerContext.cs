using mgptechRestAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace mgptechRestAPI.Infra.Data
{
    public class SqlServerContext : DbContext
    {

        public SqlServerContext(DbContextOptions<SqlServerContext> options) : base(options) { }


        DbSet<Ambiente> Ambientes { get; set; }
        DbSet<Role> Roles { get; set; }
        DbSet<User> Users { get; set; }

        
    }
}
