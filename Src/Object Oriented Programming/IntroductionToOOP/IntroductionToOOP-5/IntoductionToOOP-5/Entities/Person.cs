using System.Collections.Generic;

namespace IntoductionToOOP_5.Entities
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Wallet { get; set; }
        public List<Ticket> Tickets { get; set; }
        public List<GainTicket> GainTickets { get; set; }
        

        public Person()
        {
            Tickets = new List<Ticket>();
            GainTickets = new List<GainTicket>();
        }
    }
}