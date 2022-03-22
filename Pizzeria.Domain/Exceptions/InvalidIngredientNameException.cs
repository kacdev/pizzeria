using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria.Domain.Exceptions
{
    public class InvalidIngredientNameException : Exception
    {
        public InvalidIngredientNameException() : base("Ingredient name should not be empty")
        {
        }
    }
}
