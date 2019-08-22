using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class Factory
    {
        //use switch case for queue/stack pick (managed by marketing firm)
        public string input;
        SweepstakesStackManager stackManager;
        SweepstakesQueueManager queueManager;
        Sweepstakes sweepstakes;
        MarketingFirm firm;

        public Factory()
        {
            stackManager = new SweepstakesStackManager();
            queueManager = new SweepstakesQueueManager();
            sweepstakes = new Sweepstakes();
            firm = new MarketingFirm();
        }
        public void PickQueueOrStack()
        {
            input = firm.ChooseQueueOrStack();

            switch (input)
            {
                case "queue":
                    queueManager.InsertSweepstakes(sweepstakes);
                    break;
                case "stack":
                    stackManager.InsertSweepstakes(sweepstakes);
                    break;
                default:
                    PickQueueOrStack();
                    break;
            }
        }
    }
}
