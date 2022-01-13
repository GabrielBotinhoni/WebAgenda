using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using WebAgenda.Data.Interfaces;
using WebAgenda.Data.Repositories;

namespace WebAgenda.Data.Extensions
{
    public static class ConfigureRepositoryExtension
    {
        public static void ConfigureRepositories(this IServiceCollection services)
        {
            services.AddTransient<IContactRepository, ContactRepository>();
            services.AddTransient<IErrorLogRepository, ErrorLogRepository>();
        }
    }
}
