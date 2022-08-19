using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    public class Fraction
    {
        public int Nominator { get; set; }
        public int Denominator { get; set; }

        public Fraction(int nominator, int denominator)
        {
            Nominator = nominator;

            if (denominator != 0)
            {
                Denominator = denominator;
            }
            else
            {
                throw new InvalidFractionException();
            }

            
        }
    }
}
