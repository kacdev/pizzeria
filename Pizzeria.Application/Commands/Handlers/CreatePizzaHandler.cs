using MediatR;
using Pizzeria.Domain.Entities;
using Pizzeria.Domain.Repositories;

namespace Pizzeria.Application.Commands.Handlers
{
    internal class CreatePizzaHandler : IRequestHandler<CreatePizza>
    {
        private readonly IPizzaRepository _pizzaRepository;

        public CreatePizzaHandler(IPizzaRepository pizzaRepository)
        {
            _pizzaRepository = pizzaRepository;
        }
        public async Task<Unit> Handle(CreatePizza request, CancellationToken cancellationToken)
        {
            var model = request.PizzaModel;
            
            //Could be moved to pizza factory
            var pizza = Pizza.Create(model.Name, model.Description, model.Price);

            var ingredients = Ingredient.CreateMany(model.Ingredients).ToList();

            pizza.AddIngredients(ingredients);

            await _pizzaRepository.AddAsync(pizza);

            return Unit.Value;
        }
    }
}
