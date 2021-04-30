using System;

namespace PrimitiveTypedAndReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //CASE 1:

            var number1 = 10;
            var number2 = number1;
            number2++;

            Console.WriteLine($"number1 is : {number1} and number2 is: {number2}"); //Primitive Type
            var array1 = new int[3] { 1, 2, 3 };
            var array2 = array1;

            Console.WriteLine("---------------------------------------------------------------------------");

            array2[1] = 5;
            Console.WriteLine($"second element of array2 is {array2[1]}");
            Console.WriteLine($"second element of array1 is {array1[1]}");

            Console.WriteLine("---------------------------------------------------------------------------");


            //Case 2:

            var number3 = 25;
            Helper.Inrecement(number3);
            Console.WriteLine($"number3 is : {number3}");

            Console.WriteLine("---------------------------------------------------------------------------");

            var person1 = new Person() { Age = 20 };
            Helper.MakeOld(person1);
            Console.WriteLine($"Person1 age is : {person1.Age}");

           


        }

     

    }
}
