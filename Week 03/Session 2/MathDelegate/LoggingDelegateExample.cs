using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExample
{
    // delegate practical example
    // you may have a large application where you want to write debug information
    // to the console or to a file.  While developing the program, writing to the
    // console may be more efficient, then when the app is released it logs to a file
    class Program
    {
        // the logging function has a signature of: void MyLogger(string s)
        // where MyLogger either writes to the console using Console.WriteLine()
        // or writes to a file using LogToFile()

        // declare the delegate function variable type
        delegate void MyLogger(string s);

            
        static void Main(string[] args)
        {
            // declare the delegate variable
            MyLogger myLogger;

            // bool to indicate whether to log to console or file
            bool bWriteToConsole = true;


            if( bWriteToConsole)
            {
                // if logging to console, instantiate delegate variable to reference Console.WriteLine
                myLogger = new MyLogger(Console.WriteLine); 
            }
            else
            {
                // otherwise instantiate delegate variable to reference LogToFile
                myLogger = new MyLogger(LogToFile);
            }

            // write to debug log
            myLogger("debugging string");
        }

        // function to write log data to a file
        static void LogToFile( string s)
        {

        }
    }
}
