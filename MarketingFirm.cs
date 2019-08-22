using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class MarketingFirm 
    {
        //    effective "run applications" class -- majority of code will be run here

        //    member variables



        //    constructor
        public MarketingFirm()
        {
            Sweepstakes sweepstakes = new Sweepstakes();
            Contestant contestant = new Contestant();
            sweepstakes.RegisterContestant(contestant);
            sweepstakes.PrintContestantInfo(contestant);
            sweepstakes.PickWinner();
        }


        //    member methods
        public string ChooseQueueOrStack()
        {
            Console.WriteLine("Do you want to manage the sweepstakes with a queue or a stack? Type 'queue' or 'stack'");
            string input = Console.ReadLine();
            return input;
        }

        
    }
}
