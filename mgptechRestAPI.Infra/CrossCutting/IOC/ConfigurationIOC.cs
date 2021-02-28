using Autofac;
using mgptechRestAPI.Domain.Core.Interfaces.Repositories;
using mgptechRestAPI.Domain.Core.Interfaces.Repositories.Auth;
using mgptechRestAPI.Domain.Core.Interfaces.Services;
using mgptechRestAPI.Domain.Service.Services;
using mgptechRestAPI.Infra.Data.Repositories;
using mgptechRestAPI.Infra.Data.Repositories.Auth;

namespace mgptechRestAPI.Infra.CrossCutting.IOC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            // repositories
            builder.RegisterType<AmbienteRepository>().As<IAmbienteRepository>();
            builder.RegisterType<RoleRepository>().As<IRoleRepository>();
            builder.RegisterType<UserRepository>().As<IUserRepository>();
            builder.RegisterType<AgendaRepository>().As<IAgendaRepository>();
            builder.RegisterType<UserAuthRepository>().As<IUserAuthRepository>();

            // services
            builder.RegisterType<AmbienteService>().As<IAmbienteService>();
            builder.RegisterType<RoleService>().As<IRoleService>();
            builder.RegisterType<UserService>().As<IUserService>();
            builder.RegisterType<AgendaService>().As<IAgendaService>();
            builder.RegisterType<UserAuthService>().As<IUserAuthService>();
        }
    }
}