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
            string sweepstakesManagerType = UserInterface.DetermineSweepStakesManagerType();
            SweepstakesManagerFactory sweepstakesManagerFactory = new SweepstakesManagerFactory();
            MarketingFirm marketingFirm = new MarketingFirm(sweepstakesManagerFactory.DetermineSweepstakesManager(sweepstakesManagerType));
            marketingFirm.DetermineMarketingFirmAction();
            Console.ReadLine();
        }
    }
}
