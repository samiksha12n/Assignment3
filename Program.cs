using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter the number");
            num=int.Parse(Console.ReadLine());
            if(num==0)
            {
                Console.WriteLine("The number is zero");
            }
            else if(num%2==0 && num >= 0) 
            {
                Console.WriteLine("The number is Positive ");
                Console.WriteLine("The number is even");
            }
            else if (num%2==0 && num <= 0) 
            {
                Console.WriteLine("The number is even");
                Console.WriteLine("The number is negative");

            }
            else if (num % 2 != 0 && num <= 0)
            {
                Console.WriteLine("The number is odd");
                Console.WriteLine("The number is negative");

            }
            else
            {
                Console.WriteLine("The number is odd");
                Console.WriteLine("The number is positive");

            }
            Console.ReadKey();

        }
    }
}
