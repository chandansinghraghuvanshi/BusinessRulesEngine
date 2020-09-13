using System;
using BusinessRulesEngine.Interfaces;
using BusinessRulesEngine.Models;
using BusinessRulesEngine.Implementations;

namespace BusinessRulesEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            string optionSelected = "";
            IPayment payment = null;

            do
            {
                Console.WriteLine("Select your option");
                Console.WriteLine("1:Make payment for a physical product");
                Console.WriteLine("2:Make payment for a book");
                Console.WriteLine("3:Make payment for a new membership");
                Console.WriteLine("4:Make payment for a membership upgrade");
                Console.WriteLine("5:Make payment for a video");
                Console.WriteLine("0:Exit");
                optionSelected = Console.ReadLine();

                switch (optionSelected)
                {
                    case "0":
                        {
                            Console.WriteLine("Exiting...");
                            break;
                        }

                    case "1":
                        {
                            Console.WriteLine("Payment made for a physical product");
                            payment = new PhysicalProduct(new GenerateCommission());
                            break;
                        }
                    case "2":
                        {
                            Console.WriteLine("Payment made for a book");
                            payment = new Book(new GenerateCommission());
                            break;
                        }
                    case "3":
                        {
                            Console.WriteLine("Payment made for a new membership");
                            payment = new Membership(new NewMember());
                            break;
                        }
                    case "4":
                        {
                            Console.WriteLine("Payment made for a membership upgrade");
                            payment = new Membership(new UpgradeMember());
                            break;
                        }
                    case "5":
                        {
                            Console.WriteLine("Payment made for a video");
                            payment = new Video();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine(optionSelected);
                            break;
                        }
                }

                payment.ExecuteBusinessRules();
            } while (optionSelected != "0");
        }
    }
}
