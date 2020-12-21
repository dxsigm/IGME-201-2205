using System;

namespace Ch06Ex04
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
         Console.WriteLine("{0} command line arguments were specified:",
            args.Length);
         foreach (string arg in args)
            Console.WriteLine(arg);
     

		}
	}
}
