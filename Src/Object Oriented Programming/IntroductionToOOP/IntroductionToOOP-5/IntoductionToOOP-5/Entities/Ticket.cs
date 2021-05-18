using System;
using System.Collections.Generic;

namespace IntoductionToOOP_5.Entities
{
    public class Ticket
    {
        public Guid TicketId { get; set; }
        public string Type { get; set; }
        public int Price { get; set; }
        public List<int> TicketNumbers { get; set; }
        public  int Amount  { get; }
        public int Prize { get; set; }

        public Ticket()
        {
            Amount = 8; // Can not More
            TicketId = Guid.NewGuid();
            TicketNumbers = new List<int>();
        }
        
    }
}