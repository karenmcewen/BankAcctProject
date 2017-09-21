using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAcctProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // Program Class: +one client object, +one checking account object +one savings account object
            
            Client client1 = new Client("Bob", "Smith", 555000);
            Checking client1Checking = new Checking(555001, 250.75m);
            Savings client1Savings = new Savings(555002, 1234.56m, 500.00m);

            // All menu options listed above must have functionality behind them
            // Program should run until user selects 'Exit'

                      
            bool keepBanking = true;

            do
            {
                MainMenu();
                int menuChoice = int.Parse(Console.ReadLine());

                switch (menuChoice)
                {
                    case 1:
                        ViewClientInfo();
                        break;
                    case 2:
                        ViewAccountInfo();
                        break;
                    case 3:
                        DepositFunds();
                        break;
                    case 4:
                        WithdrawFunds();
                        break;
                    case 5:
                        keepBanking = false;
                        Exit();
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please choose again.");
                        Console.WriteLine();

                        break;
                }
            }
            while (keepBanking == true);
            
        }
        //METHODS
       
        public static void MainMenu()
        {
            Console.WriteLine("Welcome to the bank.");
            Console.WriteLine("MAIN MENU");
            Console.WriteLine("1.View Client Information");
            Console.WriteLine("2. View Account Balance");
            Console.WriteLine("3. Deposit Funds");
            Console.WriteLine("4. Withdraw Funds");
            Console.WriteLine("5. Exit");
        }

        public static void ViewClientInfo()
        {
            Console.WriteLine("viewClientInfo()");
        }

        public static void ViewAccountInfo()
        {
            Console.WriteLine("viewAccountInfo()");
        }

        public static void DepositFunds()
        {
            Console.WriteLine("DepositFunds()");
        }

        public static void WithdrawFunds()
        {
            Console.WriteLine("WithdrawFunds()");
        }
        public static void Exit()
        {
            Console.WriteLine("Thank you for using the Bank.");
            
        }
    }
}
