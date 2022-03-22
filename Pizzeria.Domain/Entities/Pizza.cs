using Pizzeria.Domain.Exceptions;

namespace Pizzeria.Domain.Entities
{
    public class Pizza
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public List<Ingredient> Ingredients { get; private set; } = new();
        public decimal Price { get; private set; }

        private Pizza(string name, string description, decimal price)
        {
            Id = Guid.NewGuid();
            Name = name;
            Description = description;
            Price = price;
        }

        public static Pizza Create(string name, string description, decimal price) 
        {
            //Use instead fluent validation
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new InvalidPizzaNameException();
            }
            if (description.Length < 10)
            {
                throw new InvalidPizzaDescriptionException();
            }
            if (price < 0 && price > 100)
            {
                throw new InvalidPizzaPriceException();
            }

            return new Pizza(name,description,price);
        }

        public void AddIngredients(IEnumerable<Ingredient> ingredients)
        {
            Ingredients.AddRange(ingredients);
        }

    }
}
