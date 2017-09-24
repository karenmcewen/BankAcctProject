using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAcctProject
{
    abstract class Account //this abstract base class has two inheritor classes - Checking & Savings
    {
        //FIELDS
        //protected fields - can be accessed by parent and derived classes
        protected int accountNumber;
        protected decimal accountBalance;
        protected string accountType;
         
        //PROPERTIES - these are in common for all derived classes
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
        //virtual methods CAN be overriden by child classes, but it is not required
        //virtual methods have a {body}
        public virtual void ShowAccountInfo()
        {
            Console.WriteLine("_______________________________________________________________________");
            Console.WriteLine("ACCOUNT INFORMATION");
            Console.WriteLine("The account number is: {0}", accountNumber);
            Console.WriteLine("The current balance for this account is: ${0}", accountBalance);
            Console.WriteLine("_______________________________________________________________________");
            Console.WriteLine();
        }

        //abstract methods MUST be overridden in each child class
        //abstract methods DO NOT have a {body}
        public abstract void Deposit(); 

        public abstract void Withdraw();

    }
}
