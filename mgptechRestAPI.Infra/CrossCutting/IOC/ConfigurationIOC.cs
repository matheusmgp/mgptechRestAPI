using Autofac;
using mgptechRestAPI.Domain.Core.Interfaces.Repositories;
using mgptechRestAPI.Domain.Core.Interfaces.Repositories.Auth;
using mgptechRestAPI.Domain.Core.Interfaces.Repositories.Register;
using mgptechRestAPI.Domain.Core.Interfaces.Services;
using mgptechRestAPI.Domain.Core.Interfaces.Services.Register;
using mgptechRestAPI.Domain.Service.Services;
using mgptechRestAPI.Domain.Service.Services.Register;
using mgptechRestAPI.Infra.Data.Repositories;
using mgptechRestAPI.Infra.Data.Repositories.Auth;
using mgptechRestAPI.Infra.Data.Repositories.Register;

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
            builder.RegisterType<CanalComunicacaoRepository>().As<ICanalComunicacaoRepository>();
            builder.RegisterType<UserRegisterRepository>().As<IUserRegisterRepository>();
            builder.RegisterType<CategoriaRepository>().As<ICategoriaRepository>();
            builder.RegisterType<SubCategoriaRepository>().As<ISubCategoriaRepository>();
            builder.RegisterType<SetorRepository>().As<ISetorRepository>();
            builder.RegisterType<ProcedimentoRepository>().As<IProcedimentoRepository>();

            // services
            builder.RegisterType<AmbienteService>().As<IAmbienteService>();
            builder.RegisterType<RoleService>().As<IRoleService>();
            builder.RegisterType<UserService>().As<IUserService>();
            builder.RegisterType<AgendaService>().As<IAgendaService>();
            builder.RegisterType<UserAuthService>().As<IUserAuthService>();
            builder.RegisterType<CanalComunicacaoService>().As<ICanalComunicacaoService>();
            builder.RegisterType<UserRegisterService>().As<IUserRegisterService>();
            builder.RegisterType<CategoriaService>().As<ICategoriaService>();
            builder.RegisterType<SubCategoriaService>().As<ISubCategoriaService>();
            builder.RegisterType<SetorService>().As<ISetorService>();
            builder.RegisterType<ProcedimentoService>().As<IProcedimentoService>();
        }
    }
}