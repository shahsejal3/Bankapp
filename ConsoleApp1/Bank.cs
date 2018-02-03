using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    static class Bank
    {
        public static Account CreateAccount(string emailaddress,
            AccountType typeOfAccount = AccountType.checking, decimal InitialBalance = 0.0M)

        {
            var account = new Account
            {
                EmailAddress = emailaddress,
                TypeofAccount = typeOfAccount
            };
            if (InitialBalance>0)
            account.Deposit(InitialBalance);
            return account;
        }
    }


}
