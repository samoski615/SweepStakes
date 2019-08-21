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
       

        //constructor injection
        public Sweepstakes()
        {
            contestantList = new Dictionary<string, Contestant>();
           

        }



        //member methods
        public void RegisterContestant(Contestant contestant)
        {
            //register contestant obj in sweepstakes 

            string registrationNumber = null;
            contestantList.Add(registrationNumber, contestant);
            
            
            
        }
        public void PrintContestantInfo(Contestant contestant)
        {
            //print a contestant to the console using dictionary lookup
           //could be used to print winners/participants to a list
            
        }

        //public string PickWinner()
        //{
        //    //random number generator for picking winner                                    
        //    //convert int toString
            
        //}

        public void GetSweepstakes()
        {
            //method for calling sweepstakes and sending to ISweepstakesManager, which pushes out to either Queue Manager or Stack Manager
        }

       
    }
}
