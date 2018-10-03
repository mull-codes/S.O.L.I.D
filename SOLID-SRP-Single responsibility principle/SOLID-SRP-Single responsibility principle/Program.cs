using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_SRP_Single_responsibility_principle
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer(); //Customer with Single Responsibility Principle Problem
            CustomerLogger customerLogger = new CustomerLogger(); //Customer with single Responsibility Principle Solution
            String input = null;
            

            string userChoice = null;

            do
            {
                userChoice = menu();
                switch (userChoice)
                {
                    case "1":
                        Console.Write(Environment.NewLine + "Enter Customer Name: ");
                        input = Console.ReadLine();
                        customer.Add(input);
                        Console.WriteLine("Customer Added!" + Environment.NewLine);
                        break;
                    case "2":
                        Console.Write(Environment.NewLine + "Enter Customer Name: ");
                        input = Console.ReadLine();
                        customerLogger.Add(input);
                        Console.WriteLine("Customer Added!" + Environment.NewLine);
                        break;
                    case "-1":
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
            } while (userChoice != "-1");

            
        }

        public static string menu()
        {
            Console.WriteLine("1. Customer Class Single Responsibility Principle");
            Console.WriteLine("2. Customer Class Single Responsibility Principle Solution");
            Console.WriteLine("-1 to Exit Console!");
            Console.Write("Enter Choice: ");
            string input = Console.ReadLine();
            Console.Write(Environment.NewLine);
            return input;
        }
    }
}
