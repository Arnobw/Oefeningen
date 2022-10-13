using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaTime
{
    internal class Pizza
    {
        public string toppings { get; set; }    
        public int diameter { get; set; }   
        public double price { get; set; }

        public void PrintInfo()
        {
            Console.WriteLine($"{toppings}, {diameter} inch, {price} dollars");
        }
    }
}
