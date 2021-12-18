﻿using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BD;

namespace WebApiRest
{
    public static class ContainerExtensions
    {

        public static IServiceCollection AddDIContainer(this IServiceCollection services)
        {

            services.AddSingleton<IDataAccess, DataAccess>();
            //services.AddTransient<IClienteService, ClienteService>();
            //services.AddTransient<ICompraService, CompraService>();
            //services.AddTransient<IProductoService, ProductoService>();

            return services;
        }
    }
}
