using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formula_arrays
{
    // Class Program
    // Author: David Schuh
    // Purpose: Array examples
    // Restrictions: None
    class Program
    {
        // Method: Main
        // Purpose: Demonstrate C# arrays (hooray!) 
        // Restrictions: None
        static void Main(string[] args)
        {
            byte myByte;
            int myInt;

            //implicit and explicit data type conversion
            //myInt = 300;
            //myByte = (byte)myInt; // NO RUNTIME ERROR IF DATA LOSS
            //myByte = Convert.ToByte(myInt); // RUNTIME ERROR IF DATA LOSS
            //myByte = checked((byte)myInt); // RUNTIME ERROR IF DATA LOSS

            // var data type declarations are not acceptable for this class
            // all variables must be strongly typed
            var h = 34;


            {
                // 2 dimensional equation (x,y)
                // y = 8x^3 - 2x + 4
                // for -100 <= x <= 100 in 0.1 increments

                double x = 0;
                double y = 0;

                double[,] yArray = new double[2010, 2];

                // we need a data point cntr as int since arrays can only be accessed using a 0-based integer
                int dataPointCntr = 0;

                for (x = -100; x <= 100; x += 0.1, ++dataPointCntr)
                {
                    x = Math.Round(x, 1);

                    y = 8 * Math.Pow(x, 3) - 2 * x + 4;
                    y = Math.Round(y, 2);

                    // store x in first bucket of second dimension for current data point
                    yArray[dataPointCntr, 0] = x;

                    // store y in second bucket of second dimension for current data point
                    yArray[dataPointCntr, 1] = y;
                }
            }

            {
                // 3 dimensional equation (x,y,z)
                // z = 2y ^ 3 + 3x ^ 2 - 8
                // for -100 <= x <= 100 in 0.1 increments
                // for 0 <= y < 10 in 0.1 increments

                double x = 0;
                double y = 0;
                double z = 0;

                int dataPointCntr = 0;

                // count how many data points for the x and y ranges
                for (x = -100; x <= 100; x += 0.1)
                {
                    x = Math.Round(x, 1);

                    for (y = 0; y < 10; y += 0.1)
                    {
                        y = Math.Round(y, 1);

                        ++dataPointCntr;
                    }
                }

                // allocate required array size
                double[,] zArray = new double[dataPointCntr, 3];

                // reset counter
                dataPointCntr = 0;

                for (x = -100; x <= 100; x += 0.1)
                {
                    x = Math.Round(x, 1);

                    for (y = 0; y < 10; y += 0.1)
                    {
                        y = Math.Round(y, 1);

                        z = 2 * Math.Pow(y, 3) + 3 * x * x - 8;
                        z = Math.Round(z, 3);

                        zArray[dataPointCntr, 0] = x;
                        zArray[dataPointCntr, 1] = y;
                        zArray[dataPointCntr, 2] = z;

                        ++dataPointCntr;
                    }
                }
            }
        }
    }
}
