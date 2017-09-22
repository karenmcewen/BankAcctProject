using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAcctProject
{
    class Checking:Account
    {
        // Accounts (ALL Accounts should include the following)
        // An account number
        // Balance
        // An account type (savings or checking)
        // A way to view the current balance
        // User must be able to deposit money into either account
        // User must be able to withdraw money from either account
        // Make sure to include the following Classes
        // Checking Account Class (derived)
        // 1 constructor

        //FIELDS
        //protected fields - can be accessed by parent and derived classes
        //only needed if different from parent classes - not needed for Checking
        //accountNumber, accountBalance, accountType are inherited from Account class

        //private fields - can only be accessed by this class
        //none at this time

        //PROPERTIES
        //only needed if different from parent classes - not needed for Checking
        //AccountNumber, AccountBalance, AccountType are inherited from Account class

        //CONSTRUCTORS

        public Checking(int accountNumber, decimal accountBalance)
        {
            this.accountNumber = accountNumber;
            this.accountBalance = accountBalance;

        }

        //METHODS -derived classes can override methods from the parent class using "virtual" keyword
        public override void ShowAccountInfo()
        {
            Console.WriteLine();
            Console.WriteLine("_______________________________________________________________________");
            Console.WriteLine();
            Console.WriteLine("ACCOUNT INFORMATION for CHECKING");
            Console.WriteLine("The account number is: , {0}", accountNumber);
            Console.WriteLine("The current balance for this account is: ${0}", accountBalance);
            Console.WriteLine();
            Console.WriteLine("_______________________________________________________________________");
            Console.WriteLine();
        }
    }
}
