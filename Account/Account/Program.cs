using System;

namespace Account
{
    class Program
    {
        static void Main(string[] args)
        {
            Accounts acc1 = new Savings();
            Accounts acc2 = new Savings("Rakib", 10001, 80000);
            Accounts acc3 = new Special_Savings("Rahat", 20001, 50000, 25);

            Accounts acc4 = new Fixed("Hasan", 30001, 6000);

            Accounts acc5 = new Overdraft(2000);
            Special_Savings s1 = new Special_Savings(30);

            Overdraft od = new Overdraft("Rakib", 10001, 80000, 5000);
        }
    }
}