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
        public string sweepstakesWinner;
        //Constructor
        public Sweepstakes(string name)
        {
            this.name = name;
        }
        //Methods(Can do)
        IDictionary<int, Contestant> registeredContestants = new Dictionary<int, Contestant>();
        public void RegisterContestant(Contestant contestant)
        {
            registeredContestants.Add(contestant.registrationNumber, contestant);
        }
        public string PickWinner()
        {
            Random random = new Random();
            int randomContestant = random.Next(registeredContestants.Count);
            sweepstakesWinner = registeredContestants[randomContestant].firstName + registeredContestants[randomContestant].lastName;
            return sweepstakesWinner;
        }
        public void PrintWinner()
        {
            Console.WriteLine($"Sweepstakes Winner is: {sweepstakesWinner}");
        }
    }
}

