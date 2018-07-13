using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public class Sweepstakes 
    {

        //Member(HAS A)
        public string name;
        public string sweepstakesWinner;
        
        //Constructor
        public Sweepstakes(string name)
        {
            this.name = name;
            DetermineSweepstakesAction();
        }
        //Methods(Can do)
        IDictionary<int, Contestant> registeredContestants = new Dictionary<int, Contestant>();
        public void DetermineSweepstakesAction()
        {

            while (true)
            {
                UserInterface.DisplayMessage("What action would you like to take for your Sweepstakes?\n 1 = Create Contestant\n 2 = Pick a Winner \n 3 = Display Contestants \n 4 = Return");
                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        RegisterContestant(CreateContestant());
                        break;
                    case "2":
                        PickWinner();
                        break;
                    case "3":
                        DisplayContestants();
                        break;
                    case "4":
                        return;
                    default:
                        return;
                }
            }
        }
        public void RegisterContestant(Contestant contestant)
        {
            registeredContestants.Add(contestant.registrationNumber, contestant);
        }
        public Contestant CreateContestant()
        {
            Contestant newContestant = new Contestant();
            return newContestant;
        }
        
        public string PickWinner()
        {
            Random random = new Random();
            int randomContestant = random.Next(1, registeredContestants.Count);
            sweepstakesWinner = registeredContestants[randomContestant].firstName + " " + registeredContestants[randomContestant].lastName;
            return sweepstakesWinner;
        }
        public void PrintWinner()
        {
            Console.WriteLine($"Sweepstakes Winner is: {sweepstakesWinner}");
        }
        public void DisplayContestants()
        {
            Console.WriteLine("Contestants: ");
            foreach (KeyValuePair<int, Contestant> pair in registeredContestants)
            {
                Console.WriteLine($"Contestant Name: {pair.Value.firstName + " " + pair.Value.lastName}");
            }
        }
    }
}

