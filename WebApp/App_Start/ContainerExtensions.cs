﻿using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BD;
using WBL;



namespace WebApp
{
    public static class ContainerExtensions
    {

        public static IServiceCollection AddDIContainer(this IServiceCollection services)
        {

            services.AddSingleton<IDataAccess, DataAccess>();
            services.AddTransient<ICompraService, CompraService>();
            //services.AddTransient<IProductoService, ProductoService>();
            //services.AddTransient<IClienteService, ClienteService>();
            return services;
        }
    }
}
