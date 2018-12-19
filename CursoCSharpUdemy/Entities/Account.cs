using System;
using System.Collections.Generic;
using System.Text;
using CursoCSharpUdemy.Entities.Exceptions;

namespace CursoCSharpUdemy.Entities
{
    class Account
    {
        public int Number { get; private set; }
        public string Holder { get; set; }
        public double Balance { get; private set; }
        public double WithdrawLimit { get; private set; }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount > WithdrawLimit) throw new DomainException("Not enough withdrawal limit!");
            if (Balance < amount) throw new DomainException("Not enough balance for withdrawal!");
            Balance -= amount;
        }
    }
}
