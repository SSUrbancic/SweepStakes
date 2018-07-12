using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class SweepstakesManagerFactory
    {
        
        public ISweepstakesManager DetermineSweepstakesManager(string selectManagerType)
        {
          
            switch (selectManagerType)
            {
                case "1":
                    return new SweepstakesStackManager();
                case "2":
                    return new SweepstakesQueueManager();
                default:
                    return DetermineSweepstakesManager(selectManagerType);
                
            }
            
        }
        
    }
}
