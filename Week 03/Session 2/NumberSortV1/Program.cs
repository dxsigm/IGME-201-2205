using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberSortV1
{
    class Program
    {
        // define the delegate method data type based on the common method signature of the possible methods to call
        delegate int LowHighFunction(int[] a);

        static void Main(string[] args)
        {
            // declare the unsorted and sorted arrays
            int[] aUnsorted;
            int[] aSorted;

        // a label to allow us to easily loop back to the start if there are input issues
        start:
            Console.WriteLine("Enter a list of space-separated numbers");

            // read the space-separated string of numbers
            string sNumberString = Console.ReadLine();

            // split the string into the an array of strings which are the individual numbers
            string[] sNumbers = sNumberString.Split(' ');

            // initialize the size of the unsorted array to 0
            int nUnsortedLength = 0;

            // a int used for parsing the current array element
            int nThisNumber;

            // iterate through the array of number strings
            foreach (string sThisNumber in sNumbers)
            {
                // if the length of this string is 0 (ie. they typed 2 spaces in a row)
                if (sThisNumber.Length == 0)
                {
                    // skip it
                    continue;
                }

                try
                {
                    // try to parse the current string into a double
                    nThisNumber = int.Parse(sThisNumber);

                    // if it's successful, increment the number of unsorted numbers
                    ++nUnsortedLength;
                }
                catch
                {
                    // if an exception occurs
                    // indicate which number is invalid
                    Console.WriteLine($"Number #{nUnsortedLength + 1} is not a valid number.");

                    // loop back to the start
                    goto start;
                }
            }

            // now we know how many unsorted numbers there are
            // allocate the size of the unsorted array
            aUnsorted = new int[nUnsortedLength];

            // reset nUnsortedLength back to 0 to use as the index to store the numbers in the unsorted array
            nUnsortedLength = 0;
            foreach (string sThisNumber in sNumbers)
            {
                // still skip the blank strings
                if (sThisNumber.Length == 0)
                {
                    continue;
                }

                // parse it into a int (we know they are all valid now)
                nThisNumber = int.Parse(sThisNumber);

                // store the value into the array
                aUnsorted[nUnsortedLength] = nThisNumber;

                // increment the array index
                nUnsortedLength++;
            }

            // declare the delegate method variable
            LowHighFunction lowHighFunction;

            string sAscDesc = null;

            Console.Write("Sort in (a)scending or (d)escending order: ");
            sAscDesc = Console.ReadLine();

            if( sAscDesc.ToLower().StartsWith("a"))
            {
                // if sorting in ascending order, find the lowest values
                // associate the delegate variable to FindLowestValue()
                lowHighFunction = new LowHighFunction(FindLowestValue);
            }
            else
            {
                // if sorting in ascending order, find the highest values
                // associate the delegate variable to FindHighestValue()
                lowHighFunction = new LowHighFunction(FindHighestValue);
            }

            // allocate the size of the sorted array
            aSorted = new int[nUnsortedLength];

            // start the sorted length at 0 to use as sorted index element
            int nSortedLength = 0;

            // while there are unsorted values to sort
            while (aUnsorted.Length > 0)
            {
                // store the lowest or highest unsorted value as the next sorted value
                aSorted[nSortedLength] = lowHighFunction(aUnsorted);

                // remove the current sorted value
                RemoveUnsortedValue(aSorted[nSortedLength], ref aUnsorted);

                // increment the number of values in the sorted array
                ++nSortedLength;
            }


            // write the sorted array of numbers
            Console.WriteLine("The sorted list is: ");
            foreach (double thisNum in aSorted)
            {
                Console.Write($"{thisNum} ");
            }

            Console.WriteLine();
        }

        // find the lowest value in the array of ints
        static int FindLowestValue(int[] array)
        {
            // define return value
            int returnVal;

            // initialize to the first element in the array
            // (we must initialize to an array element)
            returnVal = array[0];

            // loop through the array
            foreach (int thisNum in array)
            {
                // if the current value is less than the saved lowest value
                if (thisNum < returnVal)
                {
                    // save this as the lowest value
                    returnVal = thisNum;
                }
            }

            // return the lowest value
            return (returnVal);
        }

        // find the highest value in the array of ints
        static int FindHighestValue(int[] array)
        {
            // define return value
            int returnVal;

            // initialize to the first element in the array
            // (we must initialize to an array element)
            returnVal = array[0];

            // loop through the array
            foreach (int thisNum in array)
            {
                // if the current value is greater than the saved lowest value
                if (thisNum > returnVal)
                {
                    // save this as the highest value
                    returnVal = thisNum;
                }
            }

            // return the highest value
            return (returnVal);
        }

        // remove the first instance of a value from an array
        static void RemoveUnsortedValue(int removeValue, ref int[] array)
        {
            // allocate a new array to hold 1 less value than the source array
            int[] newArray = new int[array.Length - 1];

            // we need a separate counter to index into the new array, 
            // since we are skipping a value in the source array
            int dest = 0;

            // the same value may occur multiple times in the array, so skip subsequent occurrences
            bool bAlreadyRemoved = false;

            // iterate through the source array
            foreach (int srcNumber in array)
            {
                // if this is the number to be removed and we didn't remove it yet
                if (srcNumber == removeValue && !bAlreadyRemoved)
                {
                    // set the flag that it was removed
                    bAlreadyRemoved = true;

                    // and skip it (ie. do not add it to the new array)
                    continue;
                }

                // insert the source number into the new array
                newArray[dest] = srcNumber;

                // increment the new array index to insert the next number
                ++dest;
            }

            // set the ref array equal to the new array, which has the target number removed
            // this changes the variable in the calling function (aUnsorted in this case)
            array = newArray;
        }
    }
}
