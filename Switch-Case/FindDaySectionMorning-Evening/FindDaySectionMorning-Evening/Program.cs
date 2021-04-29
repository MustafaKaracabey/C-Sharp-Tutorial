using System;

namespace FindDaySectionMorning_Evening
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Time:");
            int time = Convert.ToInt32(Console.ReadLine());

            switch (time)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                    Console.WriteLine("Night");
                    break;
                case 7:
                case 8:
                case 9:
                case 10:
                case 11:
                case 12:
                    Console.WriteLine("Morning");
                    break;
                case 13:
                case 14:
                case 15:
                case 16:
                case 17:
                case 18:
                    Console.WriteLine("noon");
                    break;
                case 19:
                case 20:
                case 21:
                case 22:
                case 23:
                case 24:
                    Console.WriteLine("Evening");
                    break;
                default:
                    Console.WriteLine("Wrong Number");
                    break;
            }
        }
    }
}
