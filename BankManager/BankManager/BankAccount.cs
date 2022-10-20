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
            if (amount > funds)
            {
                double leftover = amount - funds;
                double OgFunds = funds;
                funds += - (amount - leftover);


                Console.WriteLine($"NOT ENOUGH FUNDS TO WITHDRAW SPECIFIED AMOUNT {Environment.NewLine} WITHDRAWING {OgFunds} INSTEAD of {amount}! LEAVING OUT {leftover}, FUNDS ARE NOW {funds}EUR", Console.ForegroundColor = ConsoleColor.Red);
                return amount;
            }
            else

                funds = funds - amount;
            return amount;
        }

        public double AddFunds(double amount)
        {
            funds += amount;
            return amount;
        }

        public double GetBalance()
        {
            return this.funds;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"{name}, {funds}, {number}");
        }
    }
}