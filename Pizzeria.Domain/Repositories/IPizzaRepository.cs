using Pizzeria.Domain.Entities;

namespace Pizzeria.Domain.Repositories
{
    public interface IPizzaRepository 
    {
        Task<IReadOnlyList<Pizza>> GetAllAsync();
        Task AddAsync(Pizza pizza);
    }
}
