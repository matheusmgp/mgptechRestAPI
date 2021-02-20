﻿using Autofac;
using mgptechRestAPI.Domain.Core.Interfaces.Repositories;
using mgptechRestAPI.Domain.Core.Interfaces.Services;
using mgptechRestAPI.Domain.Services.Services;
using mgptechRestAPI.Infra.Data.Repositories;

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

            // services
            builder.RegisterType<AmbienteService>().As<IAmbienteService>();
            builder.RegisterType<RoleService>().As<IRoleService>();
            builder.RegisterType<UserService>().As<IUserService>();
        }
    }
}