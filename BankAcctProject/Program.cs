﻿using System;
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
            
            bool keepBanking = true;
            int withdrawAccount = 0;
            int depositAccount = 0;


            do
            {
                // +Program should run until user selects 'Exit'
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
                        if (withdrawAccount==1)//checking
                        {

                        }
                        else if (withdrawAccount == 2) //savings
                        {
                            Savings.CheckMinimumBalance();

                        }
                        else
                        {
                            Console.WriteLine("Invalid entry. Please try again.");
                        }

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

        // All menu options listed above must have functionality behind them
        public static void ViewClientInfo()
        {
            Console.WriteLine("viewClientInfo()");

        }

        public static void ViewAccountInfo()
        {
            Console.WriteLine("viewAccountInfo()");
        }

        public static int DepositFunds()
        {
            Console.WriteLine("DepositFunds()");
            Console.WriteLine("Would you like to withdraw Funds from 1) Checking or 2) Savings");
            int depositAccount = int.Parse(Console.ReadLine());
            switch (depositAccount)
            {
                case 1:
                    Console.WriteLine("You chose checking");
                    break;
                case 2:
                    Console.WriteLine("You chose savings");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please choose again.");
                    Console.WriteLine("Would you like to withdraw Funds from 1) Checking or 2) Savings");
                    depositAccount = int.Parse(Console.ReadLine());
                    break;
            }
            return depositAccount;
        }

        public static int WithdrawFunds()
        {
            Console.WriteLine("Would you like to withdraw Funds from 1) Checking or 2) Savings");
            int withdrawAccount = int.Parse(Console.ReadLine());
            switch (withdrawAccount)
            {
                case 1:
                    Console.WriteLine("You chose checking");
                    break;
                case 2:
                    Console.WriteLine("You chose savings");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please choose again.");
                    Console.WriteLine("Would you like to withdraw Funds from 1) Checking or 2) Savings");
                    withdrawAccount = int.Parse(Console.ReadLine());
                    break;
            }
            return withdrawAccount;
        }
        public static void Exit()
        {
            Console.WriteLine("Thank you for using the Bank.");
            
        }
    }
}
