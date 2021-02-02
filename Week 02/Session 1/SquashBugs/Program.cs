using System;

namespace SquashBugs
{
    // Class: Program
    // Author: David Schuh
    // Purpose: Bug squashing exercise #1
    // Restrictions: None
    class Program
    {
        // Method: Main
        // Purpose: Prompt the user for a decimal-valued number
        //          Count down to 0 in 0.5 increments
        // Restrictions: None
        static void Main(string[] args)
        {
            // declare variable to hold user-entered number
            // compile-time error: missing ";"
            // int myNum = 0
            // int myNum = 0;

            // as a result of line #41, we realized that myNum needs to be a double
            // int myNum = 0;
            double myNum = 0;

            // prompt for number entry
            // compile-time error: missing double quotes
            // Console.Write(Enter a number:);
            // Console.Write("Enter a number: ");

            // read user input and convert to double
            // logical error: Console input is being read but not stored in any variable
            // Convert.ToDouble(Console.ReadLine());

            // but that change causes a compile-time error, 
            // since we cannot store a double in an int because a double has higher precision
            // myNum = Convert.ToDouble(Console.ReadLine());
            // we can fix that by casting the double to an int
            // myNum = (int)Convert.ToDouble(Console.ReadLine());

            // but that change will cause a logical error
            // because the header documentation indicates that we are to process numbers with decimals
            // so we need to revisit line #20 and change myNum to a double
            // note that we can set a double to an int, since int is a lower precision than double
            // but leaving the (int) cast, will truncate the decimal value and still break our code
            // myNum = (int)Convert.ToDouble(Console.ReadLine());
            // myNum = Convert.ToDouble(Console.ReadLine());

            // we are still not done with line #47, since if the user does not enter a valid number
            // a run-time error will occur
            // we should add a boolean flag and wrap the statement in a do..while() loop with a try..catch to improve the user experience
            // note that we should move line #29 into the loop as well to clearly prompt the user each time

            bool bValid = false;

            do
            {
                Console.Write("Enter a number: ");

                try
                {
                    myNum = Convert.ToDouble(Console.ReadLine());
                    bValid = true;
                }
                catch
                {
                    bValid = false;
                }
            } while (!bValid);

            // output starting value
            // compile-time error: missing string concatenation
            // Console.Write("starting value = " myNum);
            // Console.Write("starting value = " + myNum);

            // when we run the program we see that line #74 has a logical error since the output from line #97 
            // is added to the output from line #74
            // we need a newline special character which we can add manually:
            //      Console.Write("starting value = " + myNum + "\n");

            // or we can use Console.WriteLine() which adds it for us:
            Console.WriteLine("starting value = " + myNum);

            // alternative fixes:
            //Console.WriteLine($"starting value = {myNum}");
            //Console.WriteLine("starting value = {0}", myNum);

            // while myNum is greater than 0
            // logical error: checking for <0 instead of >0
            // while (myNum < 0)
            while (myNum > 0)
            // compile-time error: using ( instead of {
            // (
            {
                // output explanation of calculation
                // this line is correct!
                Console.Write("{0} - 0.5 = ", myNum);

                // output the result of the calculation
                // this line is correct!
                Console.WriteLine($"{myNum - 0.5}");

                // there is a logical error of omission since myNum is never being decremented
                // therefore we are stuck in an infinite loop
                // we need to add the following line:
                myNum -= 0.5;
                // equivalent statement:
                // myNum = myNum - 0.5;

                // compile-time error: using ) instead of {
                // )
            }
        }
    }
}
