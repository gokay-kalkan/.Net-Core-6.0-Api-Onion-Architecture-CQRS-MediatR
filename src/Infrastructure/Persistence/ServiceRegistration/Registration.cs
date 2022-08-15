using Application.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.ServiceRegistration
{
    public static class Registration
    {
        
            public static void PersistenceRegistrationService(this IServiceCollection services)
            {
                var assm = Assembly.GetExecutingAssembly();
                services.AddTransient<ICategoryRepository, CategoryRepository>();

            }
        
    }
}
