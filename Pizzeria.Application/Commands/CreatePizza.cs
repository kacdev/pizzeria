using MediatR;
using Pizzeria.Application.Models;

namespace Pizzeria.Application.Commands
{
    public sealed record CreatePizza(PizzaWriteModel PizzaModel) : IRequest;
}
