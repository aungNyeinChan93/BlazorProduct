using BlazorProduct_Application.Services;
using BlazorProduct_Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorProduct_Application
{
    public static class DependencyInjection 
    {
        public static IServiceCollection AddApplication(this IServiceCollection service)
        {
            service.AddScoped<IProductService,ProductService>();

            return service;
        }
    }
}
