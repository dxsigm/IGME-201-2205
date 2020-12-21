using System;

namespace Ch07Ex02
{
   /// <summary>
   /// Summary description for Class1.
   /// </summary>
   class Class1
   {
      static string[] eTypes = {"none", "simple", "index", "nested index"};

      static void Main(string[] args)
      {
         foreach (string eType in eTypes)
         {
            try
            {
               Console.WriteLine("Main() try block reached.");        // Line 18
               Console.WriteLine("ThrowException(\"{0}\") called.", eType);
               // Line 19
               ThrowException(eType);
               Console.WriteLine("Main() try block continues.");      // Line 21
            }
            catch (System.IndexOutOfRangeException e)                 // Line 23
            {
               Console.WriteLine("Main() System.IndexOutOfRangeException catch"
                  + " block reached. Message:\n\"{0}\"",
                  e.Message);
            }
            catch                                                     // Line 29
            {
               Console.WriteLine("Main() general catch block reached.");
            }
            finally
            {
               Console.WriteLine("Main() finally block reached.");
            }
            Console.WriteLine();
         }
      }

      static void ThrowException(string exceptionType)
      {
         // Line 43
         Console.WriteLine("ThrowException(\"{0}\") reached.", exceptionType);
         switch (exceptionType)
         {
            case "none" :
               Console.WriteLine("Not throwing an exception.");
               break;                                                 // Line 48
            case "simple" :
               Console.WriteLine("Throwing System.Exception.");
               throw (new System.Exception());                        // Line 51
               break;
            case "index" :
               Console.WriteLine("Throwing System.IndexOutOfRangeException.");
               eTypes[4] = "error";                                   // Line 55
               break;
            case "nested index" :
               try                                                    // Line 58
               {
                  Console.WriteLine("ThrowException(\"nested index\") " +
                     "try block reached.");
                  Console.WriteLine("ThrowException(\"index\") called.");
                  ThrowException("index");                            // Line 63
               }
               catch                                                  // Line 65
               {
                  Console.WriteLine("ThrowException(\"nested index\") general"
                     + " catch block reached.");
                                            
               }         
               finally
               {
                  Console.WriteLine("ThrowException(\"nested index\") finally"
                     + " block reached.");
               }
               break;
         }
      

      }
   }
}