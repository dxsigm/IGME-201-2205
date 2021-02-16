/// delegate steps
/// 1. define the delegate method data type based on the method signature
///         delegate double MathFunction(double n1, double n2);
/// 2. declare the delegate method variable
///         MathFunction processDivMult;
/// 3. point the variable to the method that it should call
///         processDivMult = new MathFunction(Multiply);
/// 4. call the delegate method
///         nAnswer = processDivMult(n1, n2);


using System;

// give access to the Timers namespace
using System.Timers;


namespace MemoryGame
{
    // Class: Program
    // Author: David Schuh
    // Purpose: Memory game based on timer control to demonstrate delegate methods and Windows events
    // Restrictions: None
    static class Program
    {
        // declare "global" class-scoped variables
        // which need to be accessed by all members of the class

        // bTimeOut boolean
        static bool bTimeOut = false;

        // timeOutTimer Timer
        static Timer timeOutTimer;

        // Method: Main
        // Purpose: main program loop to output random code sequence and prompt user to repeat the code
        //          if timer expires, then game ends
        // Restrictions: None
        static void Main(string[] args)
        {
        // declare the local variables for the game

        start:

            // a displayString which holds the code sequence
            string displayString = "";

            // initialize timeout flag
            bTimeOut = false;

            // a counter integer which loops through the code sequence
            int counter = 0;

            // the rand Random number generator object
            Random rand;

            // create the random number generator
            rand = new Random();

            // clear the screen
            Console.Clear();

            // while the user has not timed out
            while (!bTimeOut)
            {
                // append a random letter to displayString
                // we need to cast as char since rand.Next() returns int, so 'A' + int = int
                displayString += (char)('A' + rand.Next(0, 26));

                // use counter to loop through displayString
                for (counter = 0; counter < displayString.Length; ++counter)
                {
                    // 1. write displayString[counter] to the console
                    Console.Write(displayString[counter]);

                    // delay for 500 milliseconds
                    System.Threading.Thread.Sleep(500);
                }

                // clear the Console (hide the answer)
                Console.Clear();

                // create timeOutTimer with an elapsed time of displayString.Length * 500ms + 1sec
                // (Add 0.5 seconds per character in the code + 1 second "buffer")
                timeOutTimer = new Timer(displayString.Length * 500 + 1000);

                // Timer calls the Timer.Elapsed event handler when the time elapses
                // The Timer.Elapsed event handler uses a delegate function with the following signature:
                //        public delegate void ElapsedEventHandler(object sender, ElapsedEventArgs e);
                // This delegate method type is already defined for us by .NET

                // 2. declare a variable of the delegate type
                ElapsedEventHandler elapsedEventHandler;


                // 3. "point" the variable to our TimesUp method
                elapsedEventHandler = new ElapsedEventHandler(TimesUp);


                // 4. ADD the TimesUp() delegate function to the timeOutTimer.Elapsed event handler 
                // using the += operator
                timeOutTimer.Elapsed += elapsedEventHandler;


                // 5. start the timeOutTimer
                timeOutTimer.Start();

                // 6. read the user's attempt into sAnswer
                string sAnswer = null;
                sAnswer = Console.ReadLine();


                // 7. stop the timeOutTimer
                timeOutTimer.Stop();


                // if they entered the correct code sequence and they didn't timeout
                if (sAnswer.ToUpper() == displayString && !bTimeOut)
                {
                    // 8. congratulate and write their current score (displayString.Length)
                    Console.WriteLine("Well Done!  Your current score is: {0}", displayString.Length);

                }
                else
                {
                    // 9. otherwise display the correct code sequence and their final score (displayString.Length - 1)
                    Console.WriteLine("Bad luck. :(  The correct code was {0}.  Your final score is: {1}", displayString, displayString.Length - 1);

                    // 10. set bTimeOut to true to exit the game loop
                    bTimeOut = true;

                }
            }

            Console.Write("Press Enter to Play Again");
            Console.ReadLine();

            goto start;
        }

        // Method: TimesUp
        // Purpose: Delegate method to be called when the timer expires
        // Restrictions: None
        static void TimesUp(object source, ElapsedEventArgs e)
        {
            Console.WriteLine();
            Console.WriteLine("Your time is up!");

            // 11. set the bTimeOut flag to quit the game
            bTimeOut = true;

            // 12. stop the timeOutTimer
            timeOutTimer.Stop();
        }
    }
}