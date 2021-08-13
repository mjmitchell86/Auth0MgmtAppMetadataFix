using System;
using System.Timers;

namespace Auth0MgmtAPIApp
{
    class Program
    {
        private static Timer aTimer;

        public static void Main()
        {
            SetTimer();

            Console.WriteLine("\nPress the Enter key to exit the application...\n");
            Console.WriteLine("The application started at {0:HH:mm:ss.fff}", DateTime.Now);
            Console.ReadLine();
            aTimer.Stop();
            aTimer.Dispose();

            Console.WriteLine("Terminating the application...");
        }

        private static void SetTimer()
        {
            // Create a timer with a two second interval.
            aTimer = new System.Timers.Timer(2000);
            // Hook up the Elapsed event for the timer. 
            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }

        private static void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            Console.WriteLine("The Elapsed event was raised at {0:HH:mm:ss.fff}",
                              e.SignalTime);

            //  --  Grab 5 users from the array
            //var tempList = mainList.Take(5);

            //  --  Remove those 5 users from the array
            // mainList.RemoveAll(tempList.Contains);
            
            //  -- For each record
            // mainList.ForEach(delegate(Auth0User user)
            //  {
            //      - Get User Profile by Auth0UserId
            //      - Store existing app metadata as variable
            //      - Set App Metadata to empty object {}
            //      - Run Update User with empty app metadata
            //      - Rebuild App Metadata without the duplicate o365_enabled entries
            //      - Set User App Metadata to newly built App Metadta
            //      - Run Update User with newly built App Metadata 
            //  });

        }
    }
}


//  -- ORDER OF OPERATIONS --
// 1.  Export All Rocket Pro Users as CSV (Make sure to grab all of app metadata for backup sake (just in case))
// 2.  Read in All Users into memory (hooray ...not)
// 3.  Build list of all users with duplicated o365 entries (potentially deal with JSON duplicates)
// 4.  Every 2 seconds Update 5 records to remove app metadata/
//     -- For each record
//      - Get User Profile by Auth0UserId
//      - Store existing app metadata as variable
//      - Set App Metadata to empty object {}
//      - Run Update User with empty app metadata
//      - Rebuild App Metadata without the duplicate o365_enabled entries
//      - Set User App Metadata to newly built App Metadta
//      - Run Update User with newly built App Metadata 
