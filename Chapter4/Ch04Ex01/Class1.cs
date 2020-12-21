using System;

namespace Ch04Ex01
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
         Console.WriteLine("Enter an integer:");
         int myInt = Convert.ToInt32 (Console.ReadLine());
         Console.WriteLine("Integer less than 10? {0}", myInt < 10);
         Console.WriteLine("Integer between 0 and 5? {0}",
            (0 <= myInt) && (myInt <= 5));
         Console.WriteLine("Bitwise AND of Integer and 10 = {0}", myInt & 10);

		}
	}
}
