using System;
using IntoductionToOOP_5.Entities;
using IntoductionToOOP_5.Helper;

namespace IntoductionToOOP_5.Controllers
{
    public  class TicketStore
    {
        public  Ticket GetTicket(string type)
        {
            var numberGenerator = new NumberGenerator();
            var ticketgenerator = new TicketGenerator();
            
            return ticketgenerator.CreateTicket(numberGenerator, type);
        }

        public void InStore(Person person)
        {
            Console.WriteLine("Welcome To The Ticket Store");
            Console.WriteLine("----------------------------");
            Console.WriteLine($"Enter Small Ticket Number {person.Name} ");
            var smallTicketNumber = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine($"Enter Medium Ticket Number {person.Name}");
            var mediumTicketNumber = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine($"Enter Big Ticket Number {person.Name}");
            var bigTicketNumber = Convert.ToInt64(Console.ReadLine());

            for (int i = 0; i < smallTicketNumber; i++)
            {
                var ticket = GetTicket("Small");
                person.Wallet = -ticket.Price;
                person.Tickets.Add(ticket);
            }
            for (int i = 0; i < mediumTicketNumber; i++)
            {
                var ticket = GetTicket("Medium");
                person.Wallet = -ticket.Price;
                person.Tickets.Add(ticket);
            }
            for (int i = 0; i < bigTicketNumber; i++)
            {
                var ticket = GetTicket("Big");
                person.Wallet = -ticket.Price;
                person.Tickets.Add(ticket);
            }
            
        }
        
    }
}