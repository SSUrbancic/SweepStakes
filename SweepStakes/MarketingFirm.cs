using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class MarketingFirm
    {
        //Member

        ISweepstakesManager sweepstakesManager;

        //Constructor
        public MarketingFirm(ISweepstakesManager sweepstakesManager)
        {
            this.sweepstakesManager = sweepstakesManager;
        }
        //Methods(Can do)
        public void GetISweepstakesManager()
        {
            sweepstakesManager.GetSweepstakes();
        }

        
    }
}
