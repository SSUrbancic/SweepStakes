using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class Sweepstakes 
    {

        //Member(HAS A)
        public string name;
        IDictionary<int, Contestant> registeredContestant = new Dictionary<int, Contestant>();
        //Constructor
        public Sweepstakes(string name)
        {
            this.name = name;
        } 
        //Methods(Can do)
        public void RegisterContestant(Contestant contestant)
        {
            registeredContestant.Add(contestant.registrationNumber, contestant);
        }

        public void PrintWinner()
        {

        }
    }
}

