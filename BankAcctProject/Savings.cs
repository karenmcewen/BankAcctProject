using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAcctProject
{
    class Savings:Account
    {
        // Accounts (ALL Accounts should include the following)
        // An account number
        // Balance
        // An account type (savings or checking)
        // A way to view the current balance
        // User must be able to deposit money into either account
        // User must be able to withdraw money from either account
        // Make sure to include the following Classes
        // Savings Account Class (derived)
        //      Note: Savings Account must include a minimum balance. 
        //      User cannot withdraw money if balance will drop below minimum.
        //      1 property
        //      1 constructor

        //FIELDS
        //protected fields - can be accessed by parent and derived classes
        //accountNumber, accountBalance, accountType are inherited from Account class
        protected decimal minimumBalance;
        protected bool okToWithdraw;


        //private fields - can only be accessed by this class
        //none at this time

        //PROPERTIES (1)
        //AccountNumber, AccountBalance, AccountType are inherited from Account class
        public decimal MinimumBalance
        {
            get { return this.minimumBalance; }
            set { this.minimumBalance = value; }
        }
        public bool OkToWithdraw
        {
            get { return this.okToWithdraw; }
            set { this.okToWithdraw = value; }
        }

        //CONSTRUCTORS (1)

        public Savings(int accountNumber, decimal accountBalance, decimal minimumBalance)
        {
            this.accountNumber = accountNumber;
            this.accountBalance = accountBalance;
            this.minimumBalance = minimumBalance;

        }

        //METHODS -derived classes can override methods from the parent class using "virtual" keyword
        public static bool CheckMinimumBalance()
        {
            bool okToWithdraw = false;
            if (accountBalance > minimumBalance)
            {
                okToWithdraw = true;
            }
            else
            {
                okToWithdraw = false;
            }
            return okToWithdraw;
        }

    }
}
