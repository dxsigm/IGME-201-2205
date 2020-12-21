using System;

namespace Ch03Ex01
{
	/// <summary>
	/// Summary description for Class1.
	/// </summary>
	class Class1
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{
			//
			// TODO: Add code to start application here
			//
         int myInteger;
         string myString;
         myInteger = 18;
         myString = "\"myInteger\" is";
			Console.WriteLine("{0} {1}.", myString, myInteger);

		}
	}
}
