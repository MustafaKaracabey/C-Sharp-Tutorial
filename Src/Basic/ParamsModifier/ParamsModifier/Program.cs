using System;

namespace ParamsModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = Calculator.CalculateSum(new int[] { 1, 2, 3, 4, 5, 6, 78, 9, 12 });
            Console.WriteLine("Your Sum is : "+sum);
        }
    }
}
