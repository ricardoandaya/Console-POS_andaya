using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_POS
{
    internal class Program
    {
        static string[] items =
        {
            "Phoenix Burger",
            "Cosmic Fries",
            "Mystic Elixir",
            "Moon Salad",
            "Inferno Pizza",
            "Aurora Cream",
            "Shadow Coffee",
            "Blossom Tea",
            "Crystal Water",
            "Solar Nectar"
        };

        static decimal[] prices =
        {
            149,
            89,
            55,
            120,
            199,
            110,
            95,
            85,
            30,
            70
        };

        static void Main(string[] args)
        {
            while (true)
            {
                int option = DisplayMenu();

                switch (option)
                {
                    case 1:
                        DisplayItems();
                        Console.ReadKey();
                        break;
                    case 2:
                        // Remove Item
                        break;

                    case 3:
                        // View Cart
                        break;

                    case 4:
                        // Checkout
                        break;
                    case 5:
                        // Exit
                        Console.WriteLine("Exiting the program. Goodbye!");
                        return;


                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }

        private static int DisplayMenu()
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
            int option;
            int.TryParse(Console.ReadLine(), out option);
            return option;
        }
        static void DisplayItems()
        {
            Console.Clear();
            Console.WriteLine("-------------------------------");
            Console.WriteLine("            MENU");
            Console.WriteLine("-------------------------------");

            for (int i = 0; i < items.Length; i++)
                Console.WriteLine($" [{i + 1}] {items[i],-15} P{prices[i]}");
        }
    }
}