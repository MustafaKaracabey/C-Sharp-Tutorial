using System;

namespace IntoductionToOOP_6.Entities
{
    public class Account
    {
        public Guid AccountId { get; set; }
        public string Name { get; set; }
        public int Money { get; set; }
        public string Iban { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public Account(string name, int money, string iban, string username, string password)
        {
            AccountId = Guid.NewGuid();
            Name = name;
            Money = money;
            Iban = iban;
            Username = username;
            Password = password;
        }
        
    }
}