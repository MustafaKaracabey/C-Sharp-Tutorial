using System;
using System.Collections.Generic;
using IntoductionToOOP_6.Entities;

namespace IntoductionToOOP_6
{
    public interface IBank
    {

         Guid Id { get; set; }
         string Name { get; set; }
         int TotalMoney { get; set; }
         List<Account> Accounts { get; set; }
         
        void Register();
        void CancelRegistration();
        bool Login(User user);
        void AddMoney(User user);
        void WithdrawMoney();
        void SendMoney();
        void ShowMoney(User user);
    }
}