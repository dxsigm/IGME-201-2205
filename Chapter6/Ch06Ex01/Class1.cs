using System;

namespace Ch06Ex01
{
	/// <summary>
	/// Summary description for Class1.
	/// </summary>
	class Class1
	{
	
      static string myString;

      static void Write()
      {
         string myString = "String defined in Write()";
         Console.WriteLine("Now in Write()");
         Console.WriteLine("Local myString = {0}", myString);
         Console.WriteLine("Global myString = {0}", Class1.myString);
      }

      static void Main(string[] args)
      {
         string myString = "String defined in Main()";
         Class1.myString = "Global string";
         Write();
         Console.WriteLine("\nNow in Main()");
         Console.WriteLine("Local myString = {0}", myString);
         Console.WriteLine("Global myString = {0}", Class1.myString);
      }


	}
}
