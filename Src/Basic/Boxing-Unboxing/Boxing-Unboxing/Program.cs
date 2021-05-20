using System;

namespace Boxing_Unboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            //Boxing mean You can convert Primitive type to Reference type

            int number = 5;
            Object obj = number; //This is boxing -- Other direction is Unboxing 
            Console.WriteLine(obj.GetType());

            
                
    

        }
    }
}