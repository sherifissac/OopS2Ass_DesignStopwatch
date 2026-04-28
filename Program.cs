using System.Runtime.CompilerServices;

namespace OopS2Ass_DesignStopwatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StopWatch watch = new StopWatch();
            Console.WriteLine("To Start press 0");
            Console.WriteLine("To End press 1");
            Console.WriteLine("To Show Interval press 2");
            Console.WriteLine("To Exit Press 3");
            while (true)
            {
                string choose = Console.ReadLine();
                int x = Convert.ToInt32(choose);
                if (x == 0)
                {
                    watch.StartTheStopWatch();
                }
                else if (x == 1)
                {
                    watch.StopTheStopWatch();
                }
                else if (x == 2)
                {
                    Console.WriteLine(watch.Duration);
                }
                else if (x == 3)
                {
                    return;
                }
            }
        }

        public class StopWatch
        {
            //declare variables
            private DateTime startTime;
            private DateTime endTime;
            // Duration in Private Set. If user tried to display duratuin while stopwatch is running , exception will be thrown
            public TimeSpan Duration 
            {
                get
                {
                    if (isRunning)
                    {
                        throw new InvalidOperationException("Stopwatch is running. Please stop it before checking the duration.");
                    }
                    else
                    {
                        return endTime - startTime;
                    }
                }
               
            }
            //validate if the stopwatch is running
            private bool isRunning = false;
            
            public void StartTheStopWatch()
            {
                if (isRunning)
                {
                    throw new InvalidOperationException("Stopwatch is already running.");
                }
                else
                {
                    startTime = DateTime.Now;
                    isRunning = true;
                    Console.WriteLine("Stopwatch started at: " + startTime);
                }
            }
            public void StopTheStopWatch()
            {
                if (!isRunning)
                {
                    throw new InvalidOperationException("Stopwatch is not running.");
                }
                else
                {
                    endTime = DateTime.Now;
                    isRunning = false;
                    Console.WriteLine("Stopwatch stopped at: " + endTime);
                }
            }
        }
    }
}
