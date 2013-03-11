using System;
using System.Diagnostics;
using System.Linq;

namespace DelegatesTimer
{
    //Define the delegate
    public delegate void Timer(string printMsg, int timeInSeconds, int totalRunTime);
    
    public class DelegateTimer
    {
        //Create the test method 
        static void PrintMethod(string printMsg, int timePerTick, int totalRunTime)
        {
            //First check if the time per tick is more than the total run time, if so promt a msg
            if (timePerTick > totalRunTime)
                Console.WriteLine("Enter tick time less than total time");
            
            //Create and start a new stopwatch
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            //A while loop to check if we've reached the max time and the other condition is to check if we need to go in the loop at all
            while (((int)stopWatch.Elapsed.TotalSeconds <= totalRunTime) && (timePerTick <= totalRunTime))
            {
                //If 1 tick we've defined is passed we print the message with the param given to us
                if (stopWatch.Elapsed.TotalSeconds % timePerTick == 0)
                {
                    Console.WriteLine("Shqlqlq and the message is: {0}", printMsg);
                }
            }
        }

        static void Main(string[] args)
        {
            //Test by creating a new timer with the method
            Timer timer = new Timer(PrintMethod);
            //Some vars to pass 
            int timePerTick = 1;
            int totalTime = 10;
            string message = "Pesho";
            
            timer(message, timePerTick, totalTime);
        }
    }
}