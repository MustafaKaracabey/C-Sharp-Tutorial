using System;

namespace Out_Modifier
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 5;
            int number2 = 10;
            Console.WriteLine("Before Changing NUMBER1 İS :" + number + " Before Changing NUMBER2 İS :" + number2);

            Number.ChangeNumberByOut(out number,out number2);
            Console.WriteLine("After Changing NUMBER1 İS :" + number + " After Changing NUMBER2 İS :"+ number2);
        }
    }
}
