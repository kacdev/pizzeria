namespace Pizzeria.Application.Models
{
    public abstract class PizzaModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<string> Ingredients { get; set; }
        public decimal Price { get; set; }
    }
}
