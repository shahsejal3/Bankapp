﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    enum AccountType
    {
        checking,
        Savings,
        Loan,
        CD
    }

    /// <summary>
    /// This representsa bank account
    /// </summary>

    class Account
    {
        private static int lastAccountNumber = 0;
        #region Properties
        /// <summary>
        /// Unique number for the account
        /// </summary>
        public int AccountNumber { get; private set; }

        public string AccountName { get; set; }

        public DateTime CreatedDate { get; private set; }

        public decimal Balance { get; private set; }

        public AccountType TypeofAccount { get; set; }

        public string EmailAddress { get; set; }
        #endregion

        #region Constructors
        public Account()
        {
            AccountNumber=++lastAccountNumber;
            CreatedDate = DateTime.Now;
        }

        #endregion
        #region Methods

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public decimal Withdraw(decimal amount)
        {
            Balance -= amount;
            return Balance;

        }
        #endregion
    }
}
