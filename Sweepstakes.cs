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

        //constructor injection
        public Sweepstakes()
        {
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
            Console.WriteLine(contestant);  
        }

        //public string PickWinner()
        //{
        //    //random number generator for picking winner                                    
        //    //convert int toString
            
        //}

        //public Sweepstakes GetSweepstakes()
        //{
        //    //method for calling sweepstakes and sending to ISweepstakesManager, which pushes out to either Queue Manager or Stack Manager
        //}

       
    }
}
