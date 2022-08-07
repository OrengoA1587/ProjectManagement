using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatamanLibrary;
using System.Timers;
using System.Diagnostics;
using System.Threading;
namespace Dataman.Wipeout
{
    public class TimeTrack
    {
         
        public static void PlayerOneLost(ref bool playerOneLoop, ref bool playerTwoLoop, ref bool timeLoop, ref DateTime date, ref DateTime minutes, ref int trackTime )
        {

             date = DateTime.Now;
             minutes = new DateTime(date.Minute);
            if (date.Minute == trackTime)
            {
                Console.WriteLine("Time Ran out! Player One you lost! \n\nPress Enter.....");
                Console.ReadLine();
                playerOneLoop = true;
                playerTwoLoop = true;
                timeLoop = true;
            }
        }
        public static void PlayerTwoLost(ref bool playerOneLoop, ref bool playerTwoLoop, ref bool timeLoop, ref DateTime date, ref DateTime minutes, ref int trackTime)
        {

            date = DateTime.Now;
            minutes = new DateTime(date.Minute);
            if (date.Minute == trackTime)
            {
                Console.WriteLine("Time ran out! Player Two you lost! \n\nPress Enter!");
                Console.ReadLine();
                playerOneLoop = true;
                playerTwoLoop = true;
                timeLoop = true;
            }
        }
    }
}
