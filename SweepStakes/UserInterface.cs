using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class UserInterface
    {
        //Member(HAS A)

        //Constructor
        public UserInterface()
        {

        }
        //Methods(Can do)
        public void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }
        public void GetContestantInfo(Contestant contestant)
        {
            DetermineContestantfirstName(contestant);
            DetermineContestantLastName(contestant);
            DetermineContestantEmailAddress(contestant);
            DetermineContestantRegristrationNumber(contestant);
        }
        public void DetermineContestantfirstName(Contestant contestant)
        {
            DisplayMessage("Enter Contestant's first name.");
            contestant.firstName = Console.ReadLine();
        }
        public void DetermineContestantLastName(Contestant contestant)
        {
            DisplayMessage("Enter Contestant's last name");
            contestant.lastName = Console.ReadLine();
        }
        public void DetermineContestantEmailAddress(Contestant contestant)
        {
            DisplayMessage("Enter Contestant's email Address");
            contestant.emailAddress = Console.ReadLine();
        }
        public void DetermineContestantRegristrationNumber(Contestant contestant)
        {
            DisplayMessage("Enter Contestant's Registration Number");
            contestant.registrationNumber = int.Parse(Console.ReadLine());
        }
        public void DetermineSweepStakesName(Sweepstakes sweepstakes)
        {
            DisplayMessage("Enter name of sweepStakes");
            sweepstakes.name = Console.ReadLine();
        }
    }
}
