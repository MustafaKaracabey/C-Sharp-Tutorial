using System;
using System.Diagnostics;
using IntoductionToOOP_5.Entities;
using IntoductionToOOP_5.Enums;
using IntoductionToOOP_5.Helper;
using IntoductionToOOP_5.Interfaces;

namespace IntoductionToOOP_5.Controllers
{
    public class TicketGenerator : ITicketGenerator
    {
        public Ticket CreateTicket(NumberGenerator numberGenerator, string type)
        {

            var ticket = new Ticket();
            
            switch (type)
            {
                case  nameof(TicketType.Big):
                    ticket.Type = type;
                    ticket.Price = 200;
                    ticket.Prize = 100000;
                    break;
                case nameof(TicketType.Medium):
                    ticket.Type = type;
                    ticket.Price = 100;
                    ticket.Prize = 25000;
                    break;
                    
                case nameof(TicketType.Small):
                    ticket.Type = type;
                    ticket.Price = 50;
                    ticket.Prize = 5000;
                    break;
                default:
                    Console.WriteLine("Wrong Value");
                    break;
            }

            
            for (var i = 0; i < ticket.Amount; i++)
                ticket.TicketNumbers.Add(numberGenerator.CreateNumber());

         
            return ticket;
        }
    }
}