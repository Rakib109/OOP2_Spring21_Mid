using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Account
    {
        private string accName;
        private string acid;
        private int balance;
        public String AccName
        {
            get
            {
                return accName;
            }
            set
            {
                accName = value;
            }
        }
        public String AcId
        {
            get
            {
                return acid;
            }
            set
            {
                acid = value;
            }
        }
        public int Balance
        {
            get
            {
                return balance;
            }
            set
            {
                balance = value;
            }
        }

        public void Deposit(int x)
        {
            Console.WriteLine("Amount Deposited: " + x);
        }
        public void Withdraw(int y)
        {
            Console.WriteLine("Amount Withdrawn: " + y);
        }
    }
}
