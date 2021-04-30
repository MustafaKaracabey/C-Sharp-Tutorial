using System;

namespace Variables
{

    struct RgbColor
    {
        public int Red;
        public int Green;
        public int Blue;
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Overflowing Check
            //checked
            //{
            //    byte number = 255;
            //    number += 1;
            //}

            const float PI = 3.14f;
            int number2 = 25;
            float number3 = 20.5f;
            double number4 = 23.32;
            bool IsAlive = true;
            char character = 'M';
            string name = "MustafKaracabey";
            decimal number5 = 42.8m;
            long number6 = 654713;
            short number7 = 5122;


            Console.WriteLine($"Number2 : {number2}\n Number3 : {number3}\n Number4 = {number4},\n IsAlive = {IsAlive},\n Character = {character},\n Name = {name}, \nNumber5: {number5},\n number6: {number6}, \n number7: {number7} \n PI: {PI}");

            Console.WriteLine("---------------------------------------------------------");

            Person mustafa = new Person()
            {
                Name = "Mustafa",
                Surname = "Karacabey"
            };

            mustafa.IntroducePerson();

            RgbColor rgbColor = new RgbColor()
            {
                Blue = 255,
                Green = 254,
                Red = 0
            };

            Console.WriteLine($"Your Struct Value is :{ rgbColor.Blue}");

             int [] numbers = new int[3]{ 1,2,3};
            foreach (var item in numbers)
            {
                Console.WriteLine($"Your  value is {item} ");
            }

            string SoftwareEngineerName = "MustafaKaracabey";
            Console.WriteLine(SoftwareEngineerName);
            
        }
    }
}

/*
 Some Variables  :
   Primitive
        Byte,
        short,
        int,
        long,
        float,
        double,
        decimal,
        char,
        bool
    NonPrimitive
        Class,
        Struct,
        Array,
 */

