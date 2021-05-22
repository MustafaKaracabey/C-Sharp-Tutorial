using System;
using System.Collections.Generic;
using IntoductionToOOP_6.Entities;
using IntoductionToOOP_6.Screens;

namespace IntoductionToOOP_6
{
    public class Bank : IBank
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int TotalMoney { get; set; }
        public List<Account> Accounts { get; set; }

        #region constructor
        
        public Bank(string name, int totalMoney)
        {
            Id = Guid.NewGuid();
            Name = name;
            TotalMoney = totalMoney;
            Accounts = new List<Account>();
        }
        

        #endregion
      
        
        public void Register()
        {
            throw new System.NotImplementedException();
        }

        public void CancelRegistration()
        {
            throw new System.NotImplementedException();
        }

        public bool Login(User user)
        {
            Console.WriteLine("Please Enter Username");
            var username = Console.ReadLine();

            foreach (var account in Accounts)
            {
                if (username == account.Username)
                {
                    Console.WriteLine("Successful Username !!   Please Enter Password");
                    var password = Console.ReadLine();

                    if (password == account.Password)
                    {
                        LoginScreen.WelcomeScreen(this,user);
                        return true;
                    }
                    else
                    {
                        Console.WriteLine($"Wrong Password You can not Enter { this.Name}");
                        return false;
                    }
                }
            }

            Console.WriteLine($"Wrong Username you entered you can not enter { this.Name} ");
            return false;
        }

        public void AddMoney(User user)
        {
            
            Console.WriteLine("Enter Money to Add Your Account");
            var money = Convert.ToInt32(Console.ReadLine());

            user.Accounts[0].Money += money;

            Console.WriteLine("Money Successfully Added ");
            ShowMoney(user);
            
        }

        public void WithdrawMoney()
        {
            throw new System.NotImplementedException();
        }

        public void SendMoney()
        {
            throw new System.NotImplementedException();
        }

        public void ShowMoney(User user)
        {
            Console.WriteLine("Your Money is : " + user.Accounts[0].Money);
        }
    }
}