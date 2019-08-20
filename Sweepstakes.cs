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


        //constructor injection
        public Sweepstakes()
        {
            Contestant<object> contestant = new Contestant<object>();

        }
        //Sweepstakes(string name);



        //member methods
        public void RegisterContestant(Contestant contestant)
        {
            //method actions
        }

        public void PrintContestantInfo(Contestant contestant)
        {
            //method actions
        }

        public string PickWinner()
        {
            //random number generator for picking winner

        }
    }
}
