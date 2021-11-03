using System;

namespace MyBankLib
{
    public class CheckingAccount : IAccount
    {
        private double m_balance;
        private string name;
        private double amount;

        public CheckingAccount(string name, double amount)
        {
            this.name = name;
            this.amount = amount;
        }

        public double Balance { get; set; }

        public void Withdraw(double amount)
        {
            if (m_balance >= amount)
            {
                m_balance -= amount;
            }
            else
            {
                throw new ArgumentException("Withdrawal exceeds balance!", nameof(amount));
            }
        }
    }
}
