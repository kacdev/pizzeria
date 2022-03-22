using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Pizzeria.Application.Common.Behaviours;
using System.Reflection;

namespace Pizzeria.Application
{
    public static class Extensions
    {
        public static IServiceCollection AddApplication(this IServiceCollection services) {

            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehaviour<,>));
            return services;
        }
    }
}
