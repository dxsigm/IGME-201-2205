using System;
using Ch09ClassLib;

namespace Ch09Ex02
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
         MyExternalClass myObj = new MyExternalClass();
         Console.WriteLine(myObj.ToString());

		}
	}
}
