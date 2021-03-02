using Autofac;
using mgptechRestAPI.Application.Mapper.Profiles;
using mgptechRestAPI.Domain.Service;
using mgptechRestAPI.Infra.CrossCutting.IOC;
using mgptechRestAPI.Infra.Data;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System;
using System.IO;
using System.Reflection;
using System.Text;

namespace mgptechRestAPI.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<SqlServerContext>(
                   context => context.UseSqlServer(Configuration.GetConnectionString("SqlServer")));

            //services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            services.AddAutoMapper(
                            typeof(AmbienteProfile),
                            typeof(RoleProfile),
                            typeof(UserProfile),
                            typeof(UserAuthProfile),
                            typeof(CategoriaProfile),
                            typeof(SetorProfile),
                            typeof(ProcedimentoProfile),
                            typeof(ClienteProfile),
                            typeof(FilialProfile),
                            typeof(PendenciaProfile),
                            typeof(ChamadoProfile),
                            typeof(SubCategoriaProfile),
                            typeof(AgendaProfile));

            services.AddControllers().AddNewtonsoftJson(x => 
            x.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc(
                    "mgptechapi",
                    new Microsoft.OpenApi.Models.OpenApiInfo()
                    {
                        Version = "v1",
                        Title = "MgpTech API",
                        Description = "API criada para o sistema de chamados da MgpTech",
                        //TermsOfService = new Uri("https://example.com/terms"),
                        Contact = new OpenApiContact
                        {
                            Name = "Matheus Gustavo",
                            Email = "matheus_mgp@hotmail.com",
                            Url = new Uri("https://github.com/matheusmgp"),
                        },
                        License = new OpenApiLicense
                        {
                            Name = "Use under LICX",
                            Url = new Uri("https://github.com/matheusmgp"),
                        }
                    }
                );

                var xmlCommentsFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlCommentsFullPath = Path.Combine(AppContext.BaseDirectory, xmlCommentsFile);

                options.IncludeXmlComments(xmlCommentsFullPath);
            });

            services.AddCors(options => options.AddDefaultPolicy(
                    builder => builder.AllowAnyOrigin()
                                      .AllowAnyMethod()
                                      .AllowAnyHeader()));

            services.AddAuthorization(options =>
            {
            options.AddPolicy("Financeiro", policy => policy.RequireClaim("Roles", "admin"));
            options.AddPolicy("Suporte", policy => policy.RequireClaim("Roles", "suporte"));
            options.AddPolicy("Administrador", policy => policy.RequireClaim("Roles", "admin"));
            options.AddPolicy("All",policy => policy.RequireClaim("Roles", "admin", "suporte","financeiro"));

        });
            var key = Encoding.ASCII.GetBytes(SettingsSecret.Secret);
            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(x =>
            {
                x.RequireHttpsMetadata = false;
                x.SaveToken = true;
                x.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false
                };
            });

           
        }

        public void ConfigureContainer(ContainerBuilder builder)
        {
            builder.RegisterModule(new ModuleIOC());
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();
            app.UseSwagger()
                .UseSwaggerUI(options =>
                {
                    options.SwaggerEndpoint("/swagger/mgptechapi/swagger.json", "mgptechapi");
                    options.RoutePrefix = "";
                });

            app.UseAuthorization();
            app.UseAuthentication();
            app.UseCors();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}