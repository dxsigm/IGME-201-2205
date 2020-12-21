using System;
using System.Timers;

namespace Ch12Ex01
{
   class Class1
   {
      static int counter = 0;

      static string displayString =
         "This string will appear one letter at a time. ";

      static void Main(string[] args)
      {
         Timer myTimer = new Timer(100);
         myTimer.Elapsed += new ElapsedEventHandler(WriteChar);
         myTimer.Start();
         Console.ReadLine();
      }

      static void WriteChar(object source, ElapsedEventArgs e)
      {
         Console.Write(displayString[counter++ % displayString.Length]);
      }
   }
}
