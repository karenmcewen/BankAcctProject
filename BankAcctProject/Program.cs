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
            //Instantiate +one client object, +one checking account object +one savings account object
            //decimal is the best choice for money because it has enough accuracy and causes fewer rounding errors

            Client client1 = new Client("Maggie", "Moo", 555000);
            Checking client1Checking = new Checking(555001, 250.75m);
            Savings client1Savings = new Savings(555002, 1234.56m, 500.00m);
            
            bool keepBanking = true;

            do // +Program should run until user selects 'Exit'
            {
                MainMenu();
                int mainMenuChoice = int.Parse(Console.ReadLine());

                switch (mainMenuChoice)
                {
                    case 1:
                        client1.ShowClientInfo();
                        break;

                    case 2:
                        client1Checking.ShowAccountInfo();
                        client1Savings.ShowAccountInfo();                        
                        break;

                    case 3:
                        //in this case, only two options will be returned (1=checking, 2=savings)
                        //using an integer rather than a bool allows for options to be added (e.g.3=interest checking!)
                        int depositAccount = DepositFundsMenu();

                        if(depositAccount ==1)//checking
                        {
                            //call Deposit method from Checking class
                            client1Checking.Deposit();
                        }
                        else //(deposit Account == 2)//savings
                        {
                            //call Deposit method from Savings class
                            client1Savings.Deposit();
                        }
                        break;

                    case 4:
                        int withdrawAccount = WithdrawFundsMenu();
                        //in this case, only two options will be returned (1=checking, 2=savings)
                        //using an integer rather than a bool allows for options to be added (interest checking!)

                        if (withdrawAccount == 1)//checking
                        {
                            //call Withdraw method from Checking class
                            client1Checking.Withdraw();
                        }
                        else //(withdrawAccount == 2) //savings
                        {
                            //call Withdraw method from Savings class
                            client1Savings.Withdraw();

                        }
                        break;

                    case 5:
                        keepBanking = false;
                        Exit();
                        break;

                    default:
                        //goes through do-while loop and returns to main menu
                        Console.WriteLine("Invalid option. Please choose again."); 
                        Console.WriteLine();
                        break;
                }
            }
            while (keepBanking == true);
            
        }//END of MAIN

        //----------------------------------------------------------------------------------------
        //METHODS
       
        public static void MainMenu()
        {
            Console.WriteLine("Welcome to GITIBANK.");
            Console.WriteLine();
            Console.WriteLine("MAIN MENU");
            Console.WriteLine("1. View Client Information");
            Console.WriteLine("2. View Account Balances");
            Console.WriteLine("3. Deposit Funds");
            Console.WriteLine("4. Withdraw Funds");
            Console.WriteLine("5. Exit");
            Console.WriteLine();
        }             

        public static int DepositFundsMenu() 
            //returns an integer indicating which account to deposit to
        {
            Console.WriteLine("DepositFunds()");
            Console.WriteLine("Would you like to deposit funds to 1) Checking or 2) Savings?");
            int depositAccountChoice = int.Parse(Console.ReadLine());
            switch (depositAccountChoice)
            {
                case 1:
                    Console.WriteLine("You chose to DEPOSIT to CHECKING.");
                    //future function could add ability to say yes/no to whether choice was correct"
                    break;
                case 2:
                    Console.WriteLine("You chose to DEPOSIT to SAVINGS");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please choose again.");
                    Console.WriteLine("Would you like to withdraw Funds from 1) Checking or 2) Savings");
                    depositAccountChoice = int.Parse(Console.ReadLine());
                    //if this answer is invalid, that number will carry back to the method, which is currently
                    //set to default to the savings account - would need to create another if or case option 
                    //to correct for this error
                    break;
            }
            return depositAccountChoice;
        }

        public static int WithdrawFundsMenu() 
            //returns an integer indicating which account to withdraw from
        {
            Console.WriteLine("Would you like to withdraw Funds from 1) Checking or 2) Savings?");
            int withdrawAccountChoice = int.Parse(Console.ReadLine());
            switch (withdrawAccountChoice)
            {
                case 1:
                    Console.WriteLine("You chose to WITHDRAW from CHECKING.\n");
                    break;
                case 2:
                    Console.WriteLine("You chose WITHDRAW from SAVINGS.\n");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please choose again.");
                    Console.WriteLine("Would you like to withdraw Funds from 1) Checking or 2) Savings?");
                    withdrawAccountChoice = int.Parse(Console.ReadLine());
                    //if this answer is invalid, that number will carry back to the method, which is currently
                    //set to default to the savings account - would need to create another if or case option 
                    //to correct for this error
                    break;
            }
            return withdrawAccountChoice;
        }
        public static void Exit()
        {
            Console.WriteLine("_______________________________________________________________________");
            Console.WriteLine();
            Console.WriteLine("Thank you for using GITIBANK. Have a nice day.");
            Console.WriteLine("_______________________________________________________________________");
            Console.WriteLine();
        }
    }
}
