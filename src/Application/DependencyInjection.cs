using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Application.Services;
using Application.Services.Interfaces;
using MediatR;

namespace Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddTransient<IAuthorizationService, AuthorizationService>();
            services.AddTransient<ISetupBinding, SetupBinding>();
            services.AddTransient<IXmlResponseConverter, XmlResponseConverter>();
         
            services.AddMediatR(Assembly.GetExecutingAssembly());
          
            return services;
        }
    }
}
