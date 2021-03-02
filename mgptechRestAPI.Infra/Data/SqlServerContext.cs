using mgptechRestAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace mgptechRestAPI.Infra.Data
{
    public class SqlServerContext : DbContext
    {
        public SqlServerContext(DbContextOptions<SqlServerContext> options) : base(options)
        {
        }

        public DbSet<Ambiente> Ambientes { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Agenda> Agendas { get; set; }
        public DbSet<CanalComunicacao> CanaisComunicacao { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<SubCategoria> SubCategorias { get; set; }
        public DbSet<Setor> Setores { get; set; }
        public DbSet<Procedimento> Procedimentos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Filial> Filiais { get; set; }
        public DbSet<Chamado> Chamados { get; set; }
        public DbSet<Pendencia> Pendencias { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /* modelBuilder.Entity<Chamado>()
                 .HasMany(c => c.Pendencias)
                 .WithOne(e => e.Chamado);*/

            /*modelBuilder.Entity<Users>()
               .HasMany(c => c.Pendencias)
               .WithOne(e => e.User);*/

            /* modelBuilder.Entity<Users>()
                .HasMany(c => c.Chamados)
                .WithOne(e => e.User);*/
            modelBuilder.Entity<Ambiente>()
            .HasMany(c => c.Users)
            .WithOne(e => e.Ambiente);

            modelBuilder.Entity<Ambiente>()
           .HasMany(c => c.Roles)
           .WithOne(e => e.Ambiente);

            modelBuilder.Entity<Chamado>()
           .HasMany(c => c.Pendencias)
           .WithOne(e => e.Chamado);
            modelBuilder.Entity<SubCategoria>()
               .HasOne(c => c.Categoria);


        }
        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            foreach(var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
            {
                if ( entry.State == EntityState.Added)
                {
                    entry.Property("DataCadastro").CurrentValue = DateTime.Now;
                }
                else if(entry.State == EntityState.Modified)
                {
                    //entry.Property("DataCadastro").CurrentValue = entry.Property("DataCadastro").CurrentValue;
                }
            }
            return await base.SaveChangesAsync();
        }
    }
}