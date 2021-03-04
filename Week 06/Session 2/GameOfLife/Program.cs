using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    // define possible alive states
    public enum EAliveState
    {
        alive,
        dead
    }

    // define possible infected states
    public enum EInfectedState
    {
        infected,
        vaccinated,
        organic
    }

    // all neighbors of a cell
    public enum EDirection
    {
        right,
        down,
        left,
        up
            // topleft
            // topright
            // bottomleft
            // bottomright
    }

    // use a "by value" structure type to store the current and next state of each cell
    public struct StructCellState
    {
        // the infected state
        public EInfectedState eInfectedState;

        // the private alive state in this state structure
        private EAliveState eAliveState;

        // a property to apply logic to the infected state based on changing the alive state
        public EAliveState EAliveState
        {
            get
            {
                // return the current alive state
                return this.eAliveState;
            }

            set
            {
                // update private alive state member
                this.eAliveState = value;

                // if the alive state is now dead
                if ( this.eAliveState == EAliveState.dead)
                {
                    // reset the infected state to organic (its original state)
                    this.eInfectedState = EInfectedState.organic;
                }
            }
        }
    }

    static class Game
    {

        public class Cell
        {
            // the max # of infected and vaccinated cells we want in our organism
            const int MAX_VIRUS = 50;
            const int MAX_VACCINES = 50;

            // dynamically calculate how many neighbors each cell has based on the number of directions in EDirection
            public static int MAX_NEIGHBORS = Enum.GetNames(typeof(EDirection)).Length;

            // the array of neighbor cells for this cell
            public Cell[] neighbor;

            // the next cell to the "right" of this cell.  
            // This allows us to have all our cells in a 1D list which we will use in our recursive method below
            public Cell nextCell;

            // store the current and next cell states using our structures
            // which are "by value" fields and allow using the "=" operator to copy one structure into another
            // note that you need to use Deep or Shallow copying to copy class objects
            // therefore structures can be more efficient storage
            public StructCellState currentCellState;
            public StructCellState nextCellState;

            // the Cell constructor which accepts the total # of cells in the organism 
            // and the probability for a cell to be alive when it is created
            public Cell(int maxCells, int probability = 6)
            {
                // create the neighbor array for this cell
                // this needs to be done in the constructor because MAX_NEIGHBORS is calculated at runtime
                neighbor = new Cell[MAX_NEIGHBORS];
            }


        }

        static void Main(string[] args)
        {
        }

        // loop through the 2D organism array and output characters to indicate the current state of each cell
        public static void PrintOrganism(Cell[,] organism, int maxRows, int maxCols)
        {
            string output = "----------------------------------------------------------------------------------\n";

            for (int row = 0; row < maxRows; ++row)
            {
                output += "|";
                for (int col = 0; col < maxCols; ++col)
                {
                    Cell thisCell = organism[row, col];
                    if (thisCell.currentCellState.EAliveState == EAliveState.alive)
                    {
                        switch ((int)thisCell.currentCellState.eInfectedState)
                        {
                            case (int)EInfectedState.organic:
                                output += "\x25cb";
                                break;

                            case (int)EInfectedState.vaccinated:
                                output += "\x25ca";
                                break;

                            case (int)EInfectedState.infected:
                                output += "\x25cf";
                                break;
                        }
                    }
                    else
                    {
                        output += " ";
                    }
                }

                output += "|\n";
            }

            output += "----------------------------------------------------------------------------------";

            Console.BackgroundColor = ConsoleColor.Black;
            Console.CursorVisible = false;
            Console.SetCursorPosition(0, 0);
            Console.Write(output);
        }
    }
}
