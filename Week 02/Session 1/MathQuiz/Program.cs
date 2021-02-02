using System.IO;
using System;

namespace MathQuiz
{
    // Class: Program
    // Author: David Schuh
    // Purpose: Math Quiz Application
    // Restrictions: None
    class Program
    {
        // Method: Main
        // Purpose: All of the math quiz logic in one method
        // Restrictions: None
        static void Main()
        {
            // store user name
            string myName = null;

            // string and int of # of questions
            string sQuestions = null;
            int nQuestions = 0;

            // string and base value related to difficulty
            string sDifficulty = null;
            int nMaxRange = 0;

            // constant for setting difficulty with 1 variable
            const int MAX_BASE = 10;

            // question and # correct counters
            int nCntr = 0;
            int nCorrect = 0;

            // operator picker
            int nOp = 0;

            // operands and solution
            int val1 = 0;
            int val2 = 0;
            int nAnswer = 0;

            string sQuestion = null;

            // string and int for the response
            string sResponse = null;
            Int32 nResponse = 0;

            // play again?
            string sAgain = null;

            bool bValid = false;

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

            // seed the random number generator
            Random rand = new Random();

            Console.WriteLine("Math Quiz!");
            Console.WriteLine();

            // fetch the user's name into myName
            while ( true )
            {
                // only break out of the loop if they entered something 
                // (ie. if myName.Length > 0)
                myName = Console.ReadLine();

                if( myName.Length > 0)
                {
                    break;
                }
            }

        // label to return to if they want to play again
        start:

            // initialize correct responses for each time around
            nCorrect = 0;

            Console.WriteLine();

            // ask how many questions until they enter a valid number
            do
            {
                Console.Write("How many questions: ");
                bValid = int.TryParse(Console.ReadLine(), out nQuestions);
            } while (!bValid);

            Console.WriteLine();

            // ask difficulty level until they enter a valid response
            do
            {
                Console.Write("Enter difficulty level (easy, medium, hard): ");
                sDifficulty = Console.ReadLine();

                sDifficulty = sDifficulty.ToLower();

                bValid = (sDifficulty == "easy" || sDifficulty == "medium" || sDifficulty == "hard"); 
            } while (!bValid );

            Console.WriteLine();

            // if they choose easy, then set nMaxRange = MAX_BASE, unless myName == "David", then set difficulty to hard
            // if they choose medium, set nMaxRange = MAX_BASE * 2
            // if they choose hard, set nMaxRange = MAX_BASE * 3
            switch (sDifficulty )
            {
                case "easy":
                    nMaxRange = MAX_BASE;

                    if( myName.ToLower() == "david")
                    {
                        //nMaxRange = MAX_BASE * 3;
                        goto case "hard";
                    }
                    break;

                case "medium":
                    nMaxRange = MAX_BASE * 2;
                    break;

                case "hard":
                    nMaxRange = MAX_BASE * 3;
                    break;
            }

            // ask each question
            for (nCntr = 0; nCntr < nQuestions; nCntr++)
            {
                // generate a random number between 0 inclusive and 3 exclusive to get the operation
                nOp = rand.Next(0, 3);

                do
                {
                    // choose 2 random operands and ensure that both are non-zero
                    // note that using rand.Next(1,nMaxRange - 1) would give the same result
                    val1 = rand.Next(0, nMaxRange) + nMaxRange;
                    val2 = rand.Next(0, nMaxRange);
                } while (val1 == 0 || val2 == 0);

                // another way to repeat the iteration if either operand is 0
                //if( val1 == 0 || val2 == 0)
                //{
                //    // because nCntr is incremented when the for() loop iterates, 
                //    // decrement it to repeat this iteration
                //    --nCntr;
                //    // go back to the top of the for() loop
                //    continue;
                //}

            
                // if nOp == 0, then addition
                // else if nOp == 1, then subtraction
                // else multiplication
                if( nOp == 0)
                {
                    nAnswer = 
                }

                // display the question and prompt for the answer until they enter a valid number
                do
                {
                } while ( );

                // if nResponse == nAnswer, output flashy reward and increment nCorrect
                // else output stark answer

                // restore the screen colors
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine();
            }

            // output how many they got correct (nCorrect) and their score (nCorrect/nCntr)

            do
            {
                // prompt if they want to play again
                // if they type y or yes then play again (note there is a goto label at line ~71)
                // else if they type n or no then leave this loop
                // string has a StartsWith() method that could be helpful!

            } while (true);
        }
    }
}