using FluentValidation;

namespace Pizzeria.Application.Commands.Validators
{
    public class CreatePizzaValidator : AbstractValidator<CreatePizza>
    {
        public CreatePizzaValidator()
        {
            RuleFor(v => v.PizzaModel.Name)
                .NotEmpty()
                .WithMessage("Pizza name should not be empty");

            RuleFor(v => v.PizzaModel.Description)
                .MinimumLength(10)
                .WithMessage("Description should be longer than 10 characters");

            RuleFor(v => v.PizzaModel.Ingredients.Count())
                .GreaterThan(0)
                .WithMessage("Pizza should contain at least one ingredient");

            RuleFor(v => v.PizzaModel.Price)
                .GreaterThan(0)
                .WithMessage("Price should be greater than 0 PLN")
                .LessThanOrEqualTo(100)
                .WithMessage("Price should be lower than 100 PLN or equal");
        }
    }
}
