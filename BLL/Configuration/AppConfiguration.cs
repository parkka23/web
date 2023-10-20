using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using BLL.Services;
using BLL.Services.Interfaces;
using Common.Repositories;
using Microsoft.Extensions.DependencyInjection;



namespace BLL.Configuration
{
    public static class AppConfiguration
    {
        public static void AddServices(this IServiceCollection service)
        {
            service.AddTransient<IHomeService, HomeService>();

            service.AddTransient<IStudentRepository, StudentRepository>();

        }
    }
}
