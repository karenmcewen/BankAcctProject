using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAcctProject
{
    class Client
    {
        // Client Class
        // +++3 properties
        // 1 constructor
        // 1 method
        // Client information should be filled in here

        //FIELDS
        protected string firstName;
        protected string lastName;
        protected int clientNumber;

        //PROPERTIES (3)
        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }

        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }

        public int ClientNumber
        {
            get { return this.clientNumber; }
            set { this.clientNumber = value; }
        }

        //CONSTRUCTOR (1)

        public Client() //empty constructor in case we want to create a subclass later
        {

        }

        public Client(string firstName, string lastName, int clientNumber) 
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.clientNumber = clientNumber;
        }

        //METHODS (1)


    }
}
