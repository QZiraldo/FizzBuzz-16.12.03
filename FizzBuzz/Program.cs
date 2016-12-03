using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the FizzBuzz Generator\nPlease enter the end of your selected range:");
            int printLength = Convert.ToInt16(Console.ReadLine());
            for (int i = 1; i < printLength; i++)
            {
                if (i % 2 == 0 && i % 3 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }

                else if (i%2 == 0)
                {
                    Console.WriteLine("Fizz");
                }

                else if (i%3 ==0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }

            }




        }
    }
}
