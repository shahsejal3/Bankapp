using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    class Program
    {
        static void Main(string[] args)
        {

            ///instantiating an object or instance or constructing an object
            var account = Bank.CreateAccount("test@test.com",
                      InitialBalance: 101.10M);
            
            Console.WriteLine($"AccountNumber{account.AccountNumber}," +
                $"TypeofAccount{account.TypeofAccount}," +
                $"Balance{account.Balance:C}," +
                $"EmailAddress{account.EmailAddress}");

            var account2 = Bank.CreateAccount("test2@test.com",
                      InitialBalance:200M);

            account2.Deposit(500.10M);
            Console.WriteLine($"AccountNumber{account2.AccountNumber}," +
                $"TypeofAccount{account2.TypeofAccount}," +
                $"Balance{account2.Balance:C}," +
                $"EmailAddress{account2.EmailAddress}");
        }

    }
}
