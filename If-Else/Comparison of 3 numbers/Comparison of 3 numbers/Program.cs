using System;

namespace Comparison_of_3_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;

            Console.WriteLine("Enter number a :");
            a = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter number b :");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter number c :");
            c = Convert.ToInt32(Console.ReadLine());

            if( a >= b && a >= c )
            {
                Console.WriteLine("a is the biggest");
            }
            else if( b >= a && b >= c )
            {
                Console.WriteLine("b is the biggest");
            }
            else if( c >= a && c >= b )
            {
                Console.WriteLine("c is the biggest");
            }
            else
            {
                Console.WriteLine("All numbers are equal");
            }


        }
    }
}
