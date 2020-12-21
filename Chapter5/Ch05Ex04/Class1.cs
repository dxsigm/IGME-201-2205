using System;

namespace Ch05Ex04
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
         string[] friendNames = {"Robert Barwell", "Mike Parry",
                                   "Jeremy Beacock"};
         int i;
         Console.WriteLine("Here are {0} of my friends:",
            friendNames.Length);
         for (i = 0; i < friendNames.Length; i++)
         {
            Console.WriteLine(friendNames[i]);
         }

		}
	}
}
