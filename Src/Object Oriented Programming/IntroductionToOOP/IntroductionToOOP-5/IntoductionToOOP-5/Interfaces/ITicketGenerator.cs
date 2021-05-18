using System;
using IntoductionToOOP_5.Entities;
using IntoductionToOOP_5.Helper;


namespace IntoductionToOOP_5.Interfaces
{
    public interface ITicketGenerator
    {
        Ticket CreateTicket(NumberGenerator numberGenerator, string type);
    }
}