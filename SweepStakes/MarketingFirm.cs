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
        public void InsertISweepstakesManager()
        {
            sweepstakesManager.InsertSweepstakes(UserInterface.CreateSweepstakes());
        }
        public void DetermineMarketingFirmAction()
        {
            while (true)
            {
                UserInterface.DisplayMessage("What action would you like to take?\n 1 = Get Sweepstakes\n 2 = Create Sweepstakes\n 3 = Return");
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        GetISweepstakesManager();
                        break;
                    case "2":
                        InsertISweepstakesManager();
                        break;
                    case "3":
                        return;
                }
            }
        }
    }
}

    
