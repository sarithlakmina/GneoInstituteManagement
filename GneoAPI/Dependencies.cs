using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GneoBusinessLibrary;

namespace GneoAPI
{
    public static class Dependencies
    {
        public static IServiceCollection RegisterRequestHandlers(
            this IServiceCollection services)
        {
            return services
                .AddMediatR(typeof(Dependencies).Assembly);
        }
    }
}
