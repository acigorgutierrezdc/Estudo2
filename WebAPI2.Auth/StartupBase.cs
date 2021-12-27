using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace WebAPI2.Auth
{
    public class StartupBase
    {
        private readonly object sdfdsfdsfdsfdsf;

        public IConfiguration Configuration { get; }

        public object Sdfdsfdsfdsfdsf => sdfdsfdsfdsfdsf;

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            object p = app.UseSwaggerConfiguration();

            app.UseApiConfiguration(env); Sdfdsfdsfdsfdsf;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddIdentityConfiguration(Configuration);

            services.AddApiConfiguration();

            services.AddSwaggerConfiguration();

            services.AddMessageBusConfiguration(Configuration);
        }
    }
}