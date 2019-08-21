using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public class UserInterface
    {
        //grab contestant information, send to Sweepstakes.RegisterContestant
        public string firstName;
        public string lastName;
        public string emailAddress;
        public string registrationNumber;
        

        public UserInterface()
        {
            
        }

        public string GetContestantFirstName()
        {
            Console.WriteLine("Please enter your first name: ");
            string firstName = Console.ReadLine();
            return firstName;
        }

        public string GetContestantLastName()
        {
            Console.WriteLine("Please enter your last name: ");
            string lastName = Console.ReadLine();
            return lastName;

        }
        
        public string GetContestantEmailAddress()
        {
            Console.WriteLine("Please enter your email address: ");
            string emailAddress = Console.ReadLine();
            return emailAddress;
        }

        public string GetContestantRegistrationNumber()
        {
            Console.WriteLine("Please enter your registration number: ");
            string registrationNumber = Console.ReadLine();
            return registrationNumber;
        }
    }
}
