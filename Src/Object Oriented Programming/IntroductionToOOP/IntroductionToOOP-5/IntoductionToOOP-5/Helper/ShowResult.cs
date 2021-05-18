using System;
using System.Collections.Generic;
using IntoductionToOOP_5.Entities;

namespace IntoductionToOOP_5.Helper
{
    public static class ShowResult
    {

        public static void ShowEverything(List<Person> persons,List<int> lottery)
        {
            Console.WriteLine("Lottern Numbers are : ");
            foreach (var number in lottery)
            {
                Console.Write(number);
            }
            Console.WriteLine("\n-------------------------------------------------");
            foreach (var person in persons)
            {
                Console.WriteLine($"{person.Name} Won Theese Tickets");
                foreach (var gainTicket in person.GainTickets)
                {
                    Console.WriteLine($"Ticket Type: {gainTicket.Type} Money: {Convert.ToString(gainTicket.Money)} ");
                }

                Console.WriteLine("-------------------------------------------------");
            }
        }
    }
}