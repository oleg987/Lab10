using System;
using System.Collections.Generic;

namespace Lab10
{
    internal class Program
    {
        static void Main(string[] args)
        {           

            try
            {
                int x = 0;
                int y = 0;

                while (true)
                {
                    try
                    {
                        x = int.Parse(Console.ReadLine());
                        y = int.Parse(Console.ReadLine());
                        break;
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine(e.Message);
                        Console.WriteLine("Try once  more");
                    }
                }

                int z = x / y;
                Console.WriteLine(z);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                Fraction fraction = new Fraction(5, 0);
            }
            catch (InvalidFractionException e)
            {

                Console.WriteLine(e.Message);
            }

            

            List<int> list = new List<int> { 1, 2, 3, 4, 5 };

            try
            {
                Console.WriteLine(list[6]);
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }

            Console.WriteLine("end of program");
        }
    }
}
