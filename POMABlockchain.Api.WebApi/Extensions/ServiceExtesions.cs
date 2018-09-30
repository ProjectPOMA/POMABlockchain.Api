using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.PlatformAbstractions;
using POMABlockchain.Api.Model;
using POMABlockchain.Api.Repository;
using POMABlockchain.Api.Service;
using POMABlockchain.Modules.JsonRpc.Client;
using Swashbuckle.AspNetCore.Swagger;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace POMABlockchain.Api.WebApi.Extensions
{
    public static class ServiceExtesions 
    {

        
        public static void ConfigureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IClient>(a => ClientFactory.GetClient(configuration));
            services.AddScoped(typeof(IBlockService), typeof(BlockService));
        }
        public static void ConfigureRepositories(this IServiceCollection services)
        {
            services.AddScoped(typeof(IBlockRepository), typeof(BlockRepository));
        }
        public static void ConfigureSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info
                {
                    Version = "v1",
                    Title = "POMA Payment Gateway",
                    Description = "POMA Payment Gateway system",
                    TermsOfService = "None",
                    Contact = new Contact { Name = "Marcos Lobo", Email = "marcos.lobo.nit@gmail.com", Url = "https://twitter.com/lobonit" }
                });

                string caminhoAplicacao =
                   PlatformServices.Default.Application.ApplicationBasePath;
                string nomeAplicacao =
                    PlatformServices.Default.Application.ApplicationName;
                string caminhoXmlDoc =
                    Path.Combine(caminhoAplicacao, $"{nomeAplicacao}.xml");

                c.IncludeXmlComments(caminhoXmlDoc);
            });
        }
    }
}
