using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using RestWithASPNETU5demy.Models.Context;
using RestWithASPNETU5demy.Business;
using RestWithASPNETU5demy.Business.Implementation;

namespace RestWithASPNETU5demy
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

            services.AddControllers();

            var connection = Configuration["OracleConnection:OracleConnectionString"];
            services.AddDbContext<OracleContext>(options => options.UseOracle(connection, b => b.UseOracleSQLCompatibility("11")));

            //Versionamento API
            services.AddApiVersioning();

            //Injeção de dependência
            services.AddScoped<IPersonBusiness, PersonBusinessImplementation>();
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

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
