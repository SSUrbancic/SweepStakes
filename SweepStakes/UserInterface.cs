using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public static class UserInterface
    {
        //Member(HAS A)

        //Constructor

        //Methods(Can do)
        public static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }

        public static string DetermineContestantfirstName()
        {
            DisplayMessage("Enter Contestant's first name.");
            string userInput = Console.ReadLine();
            return userInput;
        }
        public static string DetermineContestantLastName()
        {
            DisplayMessage("Enter Contestant's last name");
            string userInput = Console.ReadLine();
            return userInput;
        }
        public static string DetermineContestantEmailAddress()
        {
            DisplayMessage("Enter Contestant's email Address");
            string userInput = Console.ReadLine();
            return userInput;
        }
        public static int DetermineContestantRegristrationNumber()
        {
            DisplayMessage("Enter Contestant's Registration Number");
            int userInput = int.Parse(Console.ReadLine());
            return userInput;
        }
        public static string DetermineSweepStakesName()
        {
            DisplayMessage("Enter name of sweepStakes");
            string userInput = Console.ReadLine();
            return userInput;
        }
        public static string DetermineSweepStakesManagerType()
        {
            DisplayMessage("What Sweepstake Manager would you like to use?\nEnter 1: Stack Manager \nEnter 2: Queue Manager");
            string userInput = Console.ReadLine();
            return userInput;
        }

    }
}
