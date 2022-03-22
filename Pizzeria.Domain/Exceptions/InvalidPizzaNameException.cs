using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria.Domain.Exceptions
{
    public class InvalidPizzaNameException : Exception
    {
        public InvalidPizzaNameException() : base("Pizza name should not be empty")
        {
        }
    }
}
