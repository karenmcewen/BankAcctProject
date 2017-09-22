using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAcctProject
{
    abstract class Account //this abstract base class has two inheritor classes - Checking & Savings
    {
        // Accounts (ALL Accounts should include the following)
        // An account number
        // Balance
        // An account type (savings or checking)
        // A way to view the current balance
        // User must be able to deposit money into either account
        // User must be able to withdraw money from either account
        // Make sure to include the following Classes

        //FIELDS
        //protected fields - can be accessed by parent and derived classes
        protected int accountNumber;
        protected decimal accountBalance;
        protected string accountType;
         

        //private fields - can only be accessed by this class
        //none at this time

        //PROPERTIES
        public int AccountNumber
        {
            get { return this.accountNumber; }
            //set { this.accountNumber = value; } - do not set this because do not want it to be changed
        }

        public decimal AccountBalance
        {
            get { return this.accountBalance; }
            set { this.accountBalance = value; } //allows other portions of the program to change the variable
        }

        public string AccountType
        {
            get { return this.accountType; }
            //set { this.accountType = value; }- do not set this because do not want it to be changed
        }

        //CONSTRUCTORS

        public Account() //must have a null constructor for the base class
        {

        }

        public Account(int accountNumber, decimal accountBalance)
        {
            this.accountNumber = accountNumber;
            this.accountBalance = accountBalance;

        }

        //METHODS +derived classes can override methods from the parent class using "virtual" keyword
        //this method will be overriden the in the Saving & Checking classes
        public virtual void ShowAccountInfo()
        {
            
        }

        public virtual void Deposit()
        {
            
        }

        public virtual void Withdraw()
        {

        }
    }
}
