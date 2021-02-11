using System;

/// delegate steps
/// 1. define the delegate method data type based on the method signature
///         delegate double MathFunction(double n1, double n2);
/// 2. declare the delegate method variable
///         MathFunction processDivMult;
/// 3. point the variable to the method that it should call
///         processDivMult = new MathFunction(Multiply);
/// 4. call the delegate method
///         nAnswer = processDivMult(n1, n2);

namespace MathDelegate
{
    static class Program
    {
        // the definition of the delegate function data type
        delegate double MathFunction(double n1, double n2);

        // Method: Main
        // Purpose: Prompt the user for 2 numbers and the operation to apply
        //          Use a delegate function to call the correct function to multiply or divide
        // Restrictions: None
        static void Main(string[] args)
        {
            string sNumber = null;
            string sOperation = null;

            double nNum1 = 0;
            double nNum2 = 0;
            double nAnswer = 0;

            // prompt and convert first number
            do
            {
                Console.Write("Enter a number: ");
                sNumber = Console.ReadLine();
            } while (!double.TryParse(sNumber, out nNum1));

            // prompt and convert second number
            do
            {
                Console.Write("Enter another number: ");
                sNumber = Console.ReadLine();
            } while (!double.TryParse(sNumber, out nNum2));

            // prompt for operation
            do
            {
                Console.Write("Multiply or Divide: ");
                sOperation = Console.ReadLine();
            } while (!sOperation.ToLower().StartsWith("m") &&
                     !sOperation.ToLower().StartsWith("d"));

            // declare the delegate variable which will point to the function to be called
            MathFunction processDivMult;

            // based on the operation
            if (sOperation.ToLower().StartsWith("m"))
            {
                // set the delegate function variable to the Multiply() function
                processDivMult = new MathFunction(Multiply);
            }
            else
            {
                // set the delegate function variable to the Divide() function
                processDivMult = new MathFunction(Divide);
            }

            // call the delegate function to compute the answer
            nAnswer = processDivMult(nNum1, nNum2);

            // output the answer using the ternary operator to display the math operation
            Console.WriteLine(nNum1 + (sOperation.ToLower().StartsWith("m") ? " * " : " / ") + nNum2 + " = " + nAnswer);
        }

        static double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }

        static double Divide(double num1, double num2)
        {
            return num1 / num2;
        }
    }
}
