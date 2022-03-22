using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria.Domain.Exceptions
{
    public class InvalidPizzaDescriptionException : Exception
    {
        public InvalidPizzaDescriptionException() : base("Description should be longer than 10 characters")
        {
        }
    }
}
