using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceVariableExamples
{
    class Cell
    {

    }

    class Program
    {
        static void Main(string[] args)
        {
            Cell cell1 = new Cell();
            Cell cell2 = new Cell();
            Cell cell3 = new Cell();
            Cell cell4 = new Cell();
            Cell cell5;

            // there are 4 Cell objects at this point, cell5 is not pointing to an object

            cell5 = cell4;

            // there are still only 4 Cell objects at this point, cell5 is pointing to cell4's object

            cell2 = cell1;

            // now there are only 3 Cell objects!  we lost the Cell object formerly pointed to by cell2
            // cell1 and cell2 are pointing to the object created by cell1

            // an example with arrays
            int[] array1 = new int[5];
            int[] array2 = new int[10];

            // we have 2 array objects

            array2 = array1;

            // now we only have the int[5] array object
            // we can no longer access the int[10] array object

            // .NET has a garbage collector which cleans up variables that are no longer being used
            // other programming languages have a delete command to delete variables from memory
            // .NET handles that for us automatically
        }
    }
}
