using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Encapsulation
{
    internal class BankAccount
    {
        private double _balance = 0;
        public void Deposit(double amount)
        {
            _balance += amount;
        }
        public void Withdraw(double amount)
        {
            _balance -= amount;
        }
        public void GetBalance()
        {
            Console.WriteLine(_balance);
        }
    }
}
