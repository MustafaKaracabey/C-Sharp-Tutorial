using System;
using System.Collections.Generic;

namespace IntoductionToOOP_6.Entities
{
    public class User : Person
    {
        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public List<Account> Accounts { get; set; }

        public User(string userName, string password)
        {
            UserId = Guid.NewGuid();
            UserName = userName;
            Password = password;
            Accounts = new List<Account>();
        }
    }
}