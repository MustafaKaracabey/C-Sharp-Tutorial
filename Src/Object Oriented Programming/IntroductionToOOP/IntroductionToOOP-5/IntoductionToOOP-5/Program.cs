using System;
using System.Collections.Generic;
using IntoductionToOOP_5.Controllers;
using IntoductionToOOP_5.Entities;
using IntoductionToOOP_5.Helper;

namespace IntoductionToOOP_5
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var mustafa = new Person()
            {
                Name = "mustafa",
                Age = 21,
                Wallet = 10000
            };
            var kadir = new Person()
            {
                Name = "Kadir",
                Age = 15,
                Wallet = 10000
            };
            var zeynep = new Person()
            {
                Name = "Zeynep",
                Age = 16,
                Wallet = 10000
            };

            var gotTickets = new TicketStore();
            gotTickets.InStore(mustafa);
            gotTickets.InStore(kadir);
            gotTickets.InStore(zeynep);

            List<Person> persons = new List<Person>();
            persons.Add(mustafa);
            persons.Add(kadir);
            persons.Add(zeynep);

            var lottery = LoterryGenerator.GetLotteryNumbers();
            
            var arena = new CheckWhoWins(lottery);
            arena.WhoWins(persons);

            ShowResult.ShowEverything(persons,lottery);



            // ReSharper disable once FunctionNeverReturns
        }
    }
    
     
}