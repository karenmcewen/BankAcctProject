using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAcctProject
{
    abstract class Account
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
            set { this.accountNumber = value; }
        }

        public decimal AccountBalance
        {
            get { return this.accountBalance; }
            set { this.accountBalance = value; }
        }

        public string AccountType
        {
            get { return this.accountType; }
            set { this.accountType = value; }
        }

        //CONSTRUCTORS

        public Account() //must have a null constructor for the base class
        {

        }

        public Account(int accountNumber, decimal accountBalance)
        {
            this.accountNumber =    accountNumber;
            this.accountBalance = accountBalance;

        }

        //METHODS -derived classes can override methods from the parent class using "virtual" keyword
        
    }
}
