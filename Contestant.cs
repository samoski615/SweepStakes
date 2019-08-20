using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class Contestant<T>
    {
        //member variables
        T firstName;
        T lastName;
        T emailAddress;
        T registrationNumber;
      


        //constructor
        public Contestant(T firstName, T lastName, T emailAddress, T registrationNumber)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.emailAddress = emailAddress;
            this.registrationNumber = registrationNumber;
        }

        //member methods

        
    }
}
