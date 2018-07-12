using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class SweepstakesQueueManager : ISweepstakesManager
    {
        //members
        Queue<Sweepstakes> sweepstakesQueue = new Queue<Sweepstakes>();
        //Constuctor
        public SweepstakesQueueManager()
        {

        }
        //Methods
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            sweepstakesQueue.Enqueue(sweepstakes);
        }
        public Sweepstakes GetSweepstakes()
        {
            Sweepstakes topOfSweepstakesQueue;
            topOfSweepstakesQueue = sweepstakesQueue.Dequeue();
            return topOfSweepstakesQueue;
        }

        public void DisplaySweepstakesInQueue()
        {
            Console.WriteLine("Sweepstakes: ");
            foreach (Sweepstakes sweepstakes in sweepstakesQueue)
            {
                Console.WriteLine($"This is the {sweepstakes.name} Sweepstakes!");
            }
        }
    }
}
