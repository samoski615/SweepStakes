using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
   public class Contestant
    {
        //member variables
        public string firstName;
        public string lastName;
        public string emailAddress;
        public string registrationNumber;


        //constructor
        public Contestant(string firstName, string lastName, string emailAddress, string registrationNumber)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.emailAddress = emailAddress;
            this.registrationNumber = registrationNumber;
        }

        
        //member methods


    }
}
