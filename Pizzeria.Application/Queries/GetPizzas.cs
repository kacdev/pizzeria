using MediatR;
using Pizzeria.Application.Models;

namespace Pizzeria.Application.Queries
{
    public sealed record GetPizzas() : IRequest<IReadOnlyList<PizzaReadModel>>;
}
