using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria.Domain.Exceptions
{
    public class InvalidPizzaPriceException : Exception
    {
        public InvalidPizzaPriceException() : base("Price should be in range of 0-100 PLN")
        {
        }
    }
}
