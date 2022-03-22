using Microsoft.EntityFrameworkCore;
using Pizzeria.Domain.Entities;
using Pizzeria.Domain.Repositories;

namespace Pizzeria.Infrastructure.DAL.Repositories
{
    internal class PizzaRepository : IPizzaRepository
    {
        private readonly PizzeriaDbContext _context;

        public PizzaRepository(PizzeriaDbContext context)
        {
            _context = context;
        }
        public async Task AddAsync(Pizza pizza)
        {
            await _context.Pizzas.AddAsync(pizza);
            await _context.SaveChangesAsync();
        }

        public async Task<IReadOnlyList<Pizza>> GetAllAsync()
            => await _context.Pizzas
            .Include(x => x.Ingredients)
            .AsNoTracking()
            .ToListAsync();
    }
}
