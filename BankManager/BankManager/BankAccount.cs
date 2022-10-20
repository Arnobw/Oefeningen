using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManager
{
    public class BankAccount
    {
        public string name;
        public double funds;
        public string number;

        public BankAccount(string name, double funds, string number)
        {
            this.name = name;
            this.funds = funds;
            this.number = number;

        }

        public double WithDrawFunds(double amount)
        {

            if (funds < amount)
            {

                Console.WriteLine("NOT ENOUGH FUNDS TO WITHDRAW SPECIFIED AMOUNT", Console.ForegroundColor = ConsoleColor.Red);

                double leftover = amount - funds;
                amount = - leftover;
                funds = -amount;
                return leftover;

            } else

            funds = funds - amount;
            return amount;
        }

            public double AddFunds(double amount)
        {

            funds += amount;
            return amount;
        }

        public double GetBalance() {
            return this.funds;
        }



        public void PrintInfo()
        {
            Console.WriteLine($"{name}, {funds}, {number}");
        }
    }



}
