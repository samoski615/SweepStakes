using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes 
{
    class Sweepstakes 
    {
        //member variables
        //use Dictionary data structure as underlying structure
        
        Dictionary<string, Contestant> contestantList;
        UserInterface userInfo;
        Contestant contestant;
        int winner;

        //constructor injection
        public Sweepstakes()
        {
            contestant = new Contestant();
            contestantList = new Dictionary<string, Contestant>();
            userInfo = new UserInterface();

        }



        //member methods
        public void RegisterContestant(Contestant contestant)
        {
            contestant.ContestantInfo();
            contestantList.Add(contestant.registrationNumber, contestant);
            
            
            
        }
        public void PrintContestantInfo(Contestant contestant)
        {
            //print a contestant to the console using dictionary lookup
            //could be used to print winners/participants to a list
            //RegisterContestant(contestant);

            foreach (KeyValuePair<string, Contestant> pair in contestantList)
            {
                Console.WriteLine(contestant.firstName + " " + contestant.lastName + "," + " " + contestant.emailAddress);
            }
        }

        public void PickWinner()
        {
            winner = Convert.ToInt32(contestant.registrationNumber);
            
            if (winner == RandomNumberGenerator())
            {
                //alert the winner of the sweepstakes
                Console.WriteLine("Registration Number: " + winner + "," + " " + "\n");
                PrintContestantInfo(contestant);
            }
            else
            {
                return;
            }

        }

        //public Sweepstakes GetSweepstakes()
        //{
        //    //method for sending sweepstakes from ISweepstakesManager, which pushes out to either Queue Manager or Stack Manager
        //}


        public int RandomNumberGenerator()
        {    //random number generator for picking winner                                    
            Random rng = new Random();
            winner = rng.Next(1, 5);
            return winner;
        }
    }
}
