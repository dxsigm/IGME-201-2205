using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    static class Program
    {
        static void Main(string[] args)
        {
            string sNumber = null;
            int nNumber = 0;
            int nAnswer = 0;

            do
            {
                Console.Write("Enter a positive integer: ");
                sNumber = Console.ReadLine();
            } while (!int.TryParse(sNumber, out nNumber) && nNumber <= 0);

            //nAnswer = 1;
            //
            //while( nNumber > 0)
            //{
            //    nAnswer *= nNumber;
            //    --nNumber;
            //}

            //  N * (N-1) * (N-2) * (N-3)...
            // 

            nAnswer = Factorial(nNumber);

            // in class example: Factorial(4) = David(4) * Allie(3) * Archer(2) * Dennis(1) * Twanda(0)
            // each of us needed to wait for the nextVal to calculate and return our returnVal
        }

        static int Factorial(int v)
        {
            int returnVal = 0;
            int nextVal = 0;

            // base case to stop recursively calling itself
            // Factorial(0) is indeed 1.  https://www.thoughtco.com/why-does-zero-factorial-equal-one-3126598
            if (v == 0)
            {
                returnVal = 1;
            }
            else if( v < 0)
            {
                returnVal = -1;
            }
            else
            {
                // factorial of next sequence
                nextVal = Factorial(v - 1);

                returnVal = v * nextVal;
            }

            return returnVal;
        }
    }
}
