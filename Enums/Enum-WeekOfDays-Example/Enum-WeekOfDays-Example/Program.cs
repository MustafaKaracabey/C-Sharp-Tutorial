using System;

namespace Enum_WeekOfDays_Example
{

    enum DayOfWeek
    {
        Monday = 1 ,
        Tuesday = 2,
        Wednesday = 3,
        Thursday = 4,
        Friday = 5,
        Saturday = 6,
        Sunday = 7
    }


    class Program
    {
        static void Main(string[] args)
        {
            int dayofWeek;

            while(true)
            {
                Console.WriteLine("Please Enter What day of the week as a int :");

                dayofWeek = Convert.ToInt32(Console.ReadLine());

                if (dayofWeek > 7 || dayofWeek < 0)
                    Console.WriteLine("Please Enter Correct Number");
                else
                    break;
            }

            switch (dayofWeek)
            {
                case 1:
                    Console.WriteLine($"Your Day is { DayOfWeek.Monday } "); //(int)DayOfWeek.Monday we can Convert value as a int like this.
                    break;
                case 2:
                    Console.WriteLine($"Your Day is { DayOfWeek.Tuesday } ");
                    break;
                case 3:
                    Console.WriteLine($"Your Day is { DayOfWeek.Wednesday } ");
                    break;
                case 4:
                    Console.WriteLine($"Your Day is { DayOfWeek.Thursday } ");
                    break;
                case 5:
                    Console.WriteLine($"Your Day is { DayOfWeek.Friday } ");
                    break;
                case 6:
                    Console.WriteLine($"Your Day is { DayOfWeek.Saturday } ");
                    break;
                case 7:
                    Console.WriteLine($"Your Day is { DayOfWeek.Sunday } ");
                    break;
              //No Need Default Value Cause of Day Validation
            }


        }
    }
}
