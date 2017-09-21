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
            // Program Class
            // Must instantiate one client object
            // Must instantiate one checking account object
            // Must instantiate one savings account object
            
            Client client1 = new Client("Bob", "Smith", 555000);
            Checking client1Checking = new Checking(555001, 250.75m);
            Savings client1Savings = new Savings(555002, 1234.56m, 500.00m);

            // All menu options listed above must have functionality behind them
            // Program should run until user selects 'Exit'

        }
        //METHODS
        //When a user launches the program the following menu should be displayed to the screen.
        //1. View Client Information
        //2. View Account Balance
        //3. Deposit Funds
        //4. Withdraw Funds
        //5. Exit

        public void MainMenu()
        {
            Console.WriteLine("Welcome to the bank.");
            Console.WriteLine("MAIN MENU");
            Console.WriteLine("1.View Client Information");
            Console.WriteLine("2. View Account Balance");
            Console.WriteLine("3. Deposit Funds");
            Console.WriteLine("4. Withdraw Funds");
            Console.WriteLine("5. Exit");
        }
    }
}
