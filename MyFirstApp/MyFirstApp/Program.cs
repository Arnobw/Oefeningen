using System;

namespace Demo1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("hallo welkom bij de bank, \n hoeveel euro wilt u omruilen");
            double euro = Double.Parse(Console.ReadLine());
            double dollar = euro * 1.05;
            Console.WriteLine($"uw bedrag in dollar \t is {dollar}");

        }
    }
}