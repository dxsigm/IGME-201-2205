using System;

namespace Ch05Ex05
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
         string myString = "This is a test.";
         char[] separator = {' '};
         string[] myWords;
         myWords = myString.Split(separator);
         foreach (string word in myWords)
         {
            Console.WriteLine("{0}", word);
         }

		}
	}
}
