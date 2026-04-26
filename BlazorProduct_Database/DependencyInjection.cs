using BlazorProduct_Database.Repos;
using BlazorProduct_Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorProduct_Database
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDatabasse(this IServiceCollection service,IConfigurationManager config)
        {
            service.AddDbContext<ProductDbContext>(opt =>
            {
                opt.UseSqlServer(config.GetConnectionString("ProductDb"));
            });

            service.AddScoped<IProductRepositry,ProductRepositry>();

            return service;
        }
    }
}
