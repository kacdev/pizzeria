using MediatR;
using Pizzeria.Application.Models;
using Pizzeria.Domain.Entities;
using Pizzeria.Domain.Repositories;

namespace Pizzeria.Application.Queries.Handlers
{
    internal record GetPizzasHandler : IRequestHandler<GetPizzas, IReadOnlyList<PizzaReadModel>>
    {
        private readonly IPizzaRepository _pizzaRepository;

        public GetPizzasHandler(IPizzaRepository pizzaRepository)
        {
            _pizzaRepository = pizzaRepository;
        }

        public async Task<IReadOnlyList<PizzaReadModel>> Handle(GetPizzas request, CancellationToken cancellationToken)
        {
            var pizzas = await _pizzaRepository.GetAllAsync();

            return pizzas.Select(MapToDto).ToList();
        }

        private static PizzaReadModel MapToDto(Pizza pizza) => Map<PizzaReadModel>(pizza);
        private static T Map<T>(Pizza pizza) where T : PizzaReadModel, new()
         => new()
         {
             Id = pizza.Id,
             Name = pizza.Name,
             Description = pizza.Description,
             Ingredients = pizza.Ingredients.Select(x => x.Value).ToList(),
             Price = pizza.Price
         };
    }
}
