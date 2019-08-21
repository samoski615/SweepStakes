using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class SweepstakesStackManager : ISweepstakesManager
    {
        //use Stack data structure as an underlying structure
        //implement methods from the ISweepstakesManager interface using Stack and methods
        Stack<Sweepstakes> stackManager = new Stack<Sweepstakes>();
        public SweepstakesStackManager()
        {

        }

        public Sweepstakes GetSweepstakes()
        {
            stackManager.Pop();
        }

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            stackManager.Push(sweepstakes);
        }
    }
}
