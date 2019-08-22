using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class Program
    {
                
        static void Main(string[] args)
        {
            Sweepstakes sweepstakes = new Sweepstakes();
            Contestant contestant = new Contestant();
            sweepstakes.RegisterContestant(contestant);
            sweepstakes.PrintContestantInfo(contestant);
            sweepstakes.PickWinner();
            //sweepstakes.RandomNumberGenerator();
              
        }
    }
}
