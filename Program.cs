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

        // Cart to hold selected items
        static string[] cartItems = new string[100];
        static decimal[] cartQuantities = new decimal[100];

        static void Main(string[] args)
        {
            while (true)
            {
                int option = DisplayMenu();

                switch (option)
                {
                    case 1:
                        // Add Item
                        AddItemToCart();
                        break;
                    case 2:
                        // Remove Item
                        RemoveItemFromCart();
                        break;

                    case 3:
                        ViewCart();
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

            Console.WriteLine("-------------------------------");

        }


        static void AddItemToCart()
        {
            DisplayItems();
            Console.WriteLine("Choose Item:");
            int choice;

            if (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > items.Length)
            {
                Console.WriteLine("Invalid choice. Please try again.");
                return;
            }

            Console.WriteLine("Quantity:");
            int quantity;

            if (!int.TryParse(Console.ReadLine(), out quantity) || quantity <= 0)
            {
                Console.WriteLine("Invalid quantity. Please try again.");
                return;
            }

            for (int i = 0; i < items.Length; i++)
            {
                if (i == choice - 1)
                {
                    cartItems[i] = items[i];
                    cartQuantities[i] = quantity;
                    break;
                }
            }

            Console.WriteLine($"Added {items[choice - 1]} to the cart.");
        }


        static void ViewCart()
        {
            Console.Clear();
            Console.WriteLine("-------------------------------");
            Console.WriteLine("            CART");
            Console.WriteLine("-------------------------------");

            decimal total = 0;

            for (int i = 0; i < cartItems.Length; i++)
            {
                if (!string.IsNullOrEmpty(cartItems[i]))
                {
                    decimal itemTotal = prices[i] * cartQuantities[i];
                    total += itemTotal;
                    Console.WriteLine($" {cartItems[i],-15} x{cartQuantities[i],-5} - P{itemTotal}");
                }
            }

            Console.WriteLine("-------------------------------");
            Console.WriteLine($" Total: P{total}");
            Console.ReadKey();

        }

        static void RemoveItemFromCart()
        {
            Console.Clear();
            Console.WriteLine("-------------------------------");
            Console.WriteLine("         REMOVE ITEM");
            Console.WriteLine("-------------------------------");

            for (int i = 0; i < cartItems.Length; i++)
            {
                if (!string.IsNullOrEmpty(cartItems[i]))
                    Console.WriteLine($" [{i + 1}] {cartItems[i],-15} x{cartQuantities[i],-5}");
            }

            Console.WriteLine("-------------------------------");

            Console.Write("Choose item to remove: ");
            int choice;

            if (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > cartItems.Length || string.IsNullOrEmpty(cartItems[choice - 1]))
            {
                Console.WriteLine("Invalid choice. Please try again.");
                return;
            }

            cartItems[choice - 1] = null;
            cartQuantities[choice - 1] = 0;
            Console.WriteLine("Item removed from the cart.");
        }


    }
}