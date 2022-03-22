using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Pizzeria.Domain.Repositories;
using Pizzeria.Infrastructure.DAL;
using Pizzeria.Infrastructure.DAL.Repositories;

namespace Pizzeria.Infrastructure
{
    public static class Extensions
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddScoped<IPizzaRepository, PizzaRepository>();

            services.AddDbContext<PizzeriaDbContext>(options =>
                options.UseSqlServer(
                    configuration.GetConnectionString("DefaultConnection"),
                    b => b.MigrationsAssembly(typeof(PizzeriaDbContext).Assembly.FullName)));

            return services;
        }
    }
}
