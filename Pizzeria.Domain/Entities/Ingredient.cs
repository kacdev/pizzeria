using Pizzeria.Domain.Exceptions;

namespace Pizzeria.Domain.Entities
{
    public class Ingredient
    {
        public int Id { get; set; }
        public string? Value { get; set; }

        private Ingredient(string value)
        {
            Value = value;
        }

        public static Ingredient Create(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new InvalidIngredientNameException();
            }
            return new Ingredient(value);
        }

        public static IEnumerable<Ingredient> CreateMany(IEnumerable<string> items) 
        {
            foreach (var item in items)
            {
                yield return Create(item);
            }
        }
    }
}
