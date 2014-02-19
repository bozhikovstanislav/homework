using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Human
{
    public class Human
    {
        private string firstName;
        private string lastName;

        public Human()
        {

        }

        public Human(string firstname,string  lastname)
        {
            this.firstName = firstname;
            this.lastName = lastname;
        }
    
          public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
    }
}
