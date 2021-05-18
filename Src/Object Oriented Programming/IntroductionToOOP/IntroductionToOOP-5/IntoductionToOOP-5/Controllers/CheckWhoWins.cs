using System.Collections.Generic;
using IntoductionToOOP_5.Entities;

namespace IntoductionToOOP_5.Controllers
{
    public class CheckWhoWins
    {
        public List<int> Lottery { get; set; }
        public CheckWhoWins(List<int>lottery)
        {
            Lottery = lottery;
        }
        public void WhoWins(List<Person> persons)
        {
            foreach (var person in persons)
            {
                var i = 0;
                var counter = 0;
                var ticket = new Ticket();

                foreach (var VARIABLE in person.Tickets)
                {
                    ticket = person.Tickets[i];
                    for (int j = 0; j < ticket.Amount; j++)
                    {
                        
                        if (ticket.TicketNumbers[j] == Lottery[j])
                        {
                            counter++;
                        }
                          
                    }

                    i++;

                    var money =MoneyMeasure.Measure(ticket.Type, counter);

                    if (counter != 0)
                    {
                        var gainTicket = new GainTicket();
                        gainTicket.Money = money;
                        gainTicket.Type = ticket.Type;
                        gainTicket.TicketId = ticket.TicketId;
                        
                        person.GainTickets.Add(gainTicket);
                    }
                  
                    
                }
                
   
            }
        }
    }
}