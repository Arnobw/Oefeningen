// See https://aka.ms/new-console-template for more information
using BankManager;

BankAccount acc = new BankAccount("arno", 5236, "BE02 6587 5654 4115");

acc.PrintInfo();

Console.WriteLine(acc.GetBalance());


Console.WriteLine($"{acc.GetBalance()}EUR + {acc.AddFunds(1000)}EUR =  {acc.GetBalance()}EUR");
Console.WriteLine($"{acc.GetBalance()}EUR + {acc.WithDrawFunds(1000)}EUR =  {acc.GetBalance()}EUR");

acc.WithDrawFunds(7000);

