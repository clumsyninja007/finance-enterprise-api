using FinanceEnterpriseApi.Data.Interfaces.Finance.dbo;
using FinanceEnterpriseApi.Data.Interfaces.Finance.humco;
using FinanceEnterpriseApi.Data.Services.Finance.dbo;
using FinanceEnterpriseApi.Data.Services.Finance.humco;
using FinanceEnterpriseApi.GraphQL.Queries;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System;
using System.IO;
using System.Reflection;
using FinanceEnterprise.Entities.Finance;

namespace FinanceEnterpriseApi.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureCors(this IServiceCollection services, string prodPolicyName, string devPolicyName)
        {
            services.AddCors(options =>
            {
                options.AddPolicy(devPolicyName,
                    builder => builder
                    .WithOrigins("http://cty-it-web-priv", "http://localhost:8080")
                    .AllowAnyHeader()
                    .AllowCredentials()
                    .AllowAnyMethod());

                options.AddPolicy(prodPolicyName,
                    builder => builder
                    .WithOrigins("http://cty-it-web-priv")
                    .AllowAnyHeader()
                    .AllowCredentials()
                    .AllowAnyMethod());
            });
        }

        public static void ConfigureSwagger(this IServiceCollection services, string apiTitle, string version)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = apiTitle, Version = version });

                // Set the comments path for the Swagger JSON and UI.
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                c.IncludeXmlComments(xmlPath);
            });
        }

        public static void ConfigurePooledSqlServerContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddPooledDbContextFactory<FinanceContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("FinanceDb")));
        }

        public static void ConfigureGraphQl(this IServiceCollection services)
        {
            services
                .AddGraphQLServer("glSchema")
                .AddAuthorization()
                .AddQueryType<GLQuery>();

            services
                .AddGraphQLServer("hrSchema")
                .AddAuthorization()
                .AddQueryType<HRQuery>();
        }

        public static void ConfigureGlServices(this IServiceCollection services)
        {
            services.AddTransient<IGlTrnsDetailsService, GlTrnsDetailsService>();
            services.AddTransient<IGlTransactionGrantNotesService, GlTransactionGrantNotesService>();

            services.AddTransient<IHrEmpmstrService, HrEmpmstrService>();
            services.AddTransient<IHrHrcodeService, HrHrcodeService>();
        }

        public static void ConfigureHrServices(this IServiceCollection services)
        {
            services.AddTransient<IHrEmpmstrService, HrEmpmstrService>();
            services.AddTransient<IHrHrcodeService, HrHrcodeService>();
        }

        public static void ConfigureNuServices(this IServiceCollection services)
        {
            services.AddTransient<INuJobMstrService, NuJobMstrService>();
        }
    }
}
