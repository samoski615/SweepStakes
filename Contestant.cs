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
        public Contestant()
        {

        }


        //member methods

        public void ContestantInfo()
        {
            UserInterface user = new UserInterface();
            firstName = user.GetContestantFirstName();
            lastName = user.GetContestantLastName();
            emailAddress = user.GetContestantEmailAddress();
            registrationNumber = user.GetContestantRegistrationNumber();
            
        }
    }
}
