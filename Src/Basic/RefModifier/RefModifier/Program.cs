using System;

namespace RefModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 10;
            Console.WriteLine("Before Changing NUMBER is : " + number);

            Number.ChangeByRefIncrement(ref number);//We can pass number like reference type even if value type
            
            Console.WriteLine("After Changing new NUMBER İS : " + number);
        }
    }
}
