using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MediatR;
using PlanoTestApp.Services;
using PlanoTestApp.Api.Context;
using Microsoft.EntityFrameworkCore;
using PlanoTestApp.Api.Repository;

namespace ChatBot.Services.WebHook
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {                     
            services.AddScoped<IConvertService, ConvertService>();
            services.AddScoped<ICurrencyRepository, CurrencyRepository>();

            services.AddControllers()
                    .AddNewtonsoftJson();

           services.AddMediatR(typeof(Startup));

            services.AddSwaggerGen();

            //Entity Framework
            var ConnectionString = Configuration.GetConnectionString("CurrencyDbCon");
            services.AddDbContext<CurrencyContext>(options => options.UseSqlServer(ConnectionString));
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseCors();


            app.UseEndpoints(endpoints =>
            {              
                endpoints.MapControllers();
            });

            app.UseSwagger();
            app.UseSwaggerUI(c => {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Currency Converter");
            });
        }
    }
}
