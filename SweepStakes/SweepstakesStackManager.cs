using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public class SweepstakesStackManager : ISweepstakesManager
    {
        //members
        Stack<Sweepstakes> sweepstakesStack = new Stack<Sweepstakes>();
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            sweepstakesStack.Push(sweepstakes);
        }
        public Sweepstakes GetSweepstakes()
        {
            Sweepstakes topOfSweepstakesStack;
            topOfSweepstakesStack = sweepstakesStack.Pop();
            return topOfSweepstakesStack;
        }

        public void DisplaySweepstakesInStack()
        {
            Console.WriteLine("Sweepstakes: ");
            foreach (Sweepstakes sweepstakes in sweepstakesStack)
            {
                Console.WriteLine($"This is the {sweepstakes.name} Sweepstakes!");
            }
        }
    }
}
