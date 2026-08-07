using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_POS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DisplayMenu();

            Console.ReadKey();
        }

        private static void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine("-------------------------------");
            Console.WriteLine("    Welcome to the POS System  ");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("[1] Add Item");
            Console.WriteLine("[2] Remove Item");
            Console.WriteLine("[3] View Cart");
            Console.WriteLine("[4] Checkout");
            Console.WriteLine("[5] Exit");
            Console.WriteLine("==============================");
            Console.Write("Please select an option: ");
        }
    }
}