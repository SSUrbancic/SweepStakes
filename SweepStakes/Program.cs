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
            string sweepsStakeManagerType = UserInterface.DetermineSweepStakesManagerType();


            SweepstakesManagerFactory sweepstakesManagerFactory = new SweepstakesManagerFactory();
            MarketingFirm marketingFirm = new MarketingFirm(sweepstakesManagerFactory.DetermineSweepstakesManager(sweepsStakeManagerType));






            Console.ReadLine();
        }
    }
}
