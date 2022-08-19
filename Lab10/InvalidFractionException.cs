using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    public class InvalidFractionException : Exception
    {
        public InvalidFractionException() : base("Can`t create fraction with denominator 0.")
        {
        }
    }
}
