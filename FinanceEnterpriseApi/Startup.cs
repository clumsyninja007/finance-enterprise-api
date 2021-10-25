using FinanceEnterpriseApi.Auth;
using FinanceEnterpriseApi.Auth.Interfaces;
using FinanceEnterpriseApi.Data.Mappings;
using FinanceEnterpriseApi.Extensions;
using FinanceEnterpriseApi.Middleware;
using FinanceEnterpriseApi.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Server.IISIntegration;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace FinanceEnterpriseApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        private const string ProdCors = "prodCorsPolicy";
        private const string DevCors = "devCorsPolicy";

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.ConfigureCors(ProdCors, DevCors);

            services.AddControllers();
            services.ConfigureSwagger("Finance Enterprise API", "v1");

            services.ConfigurePooledSqlServerContext(Configuration);
            services.ConfigureGraphQl();

            services.AddAutoMapper(typeof(MappingProfile));

            services.ConfigureGlServices();
            services.ConfigureHrServices();
            services.ConfigureNuServices();

            services.AddSingleton<SqlConnectionHelpers>();
            services.AddSingleton<ConversionFileHelpers>();

            services.AddAuthentication(IISDefaults.AuthenticationScheme);

            services.AddTransient<IAuthenticationService, AuthenticationService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseRouting();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();

                app.UseCors(DevCors);
            }
            else
            {
                app.UseCors(ProdCors);
            }

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseMiddleware<SwaggerAuthorizationMiddleware>();
            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("v1/swagger.json", "Finance Enterprise API v1"));

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();

                endpoints.MapGraphQL("/gl/graphql", "glSchema");
                endpoints.MapGraphQL("/hr/graphql", "hrSchema");
            });

            Dapper.DefaultTypeMap.MatchNamesWithUnderscores = true;
        }
    }
}
