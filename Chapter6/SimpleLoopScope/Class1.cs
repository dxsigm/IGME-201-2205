using System;

namespace SimpleLoopScope
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
         int i;
         string text = "";
         for (i = 0; i < 10; i++)
         {
            text = "Line " + Convert.ToString(i);
            Console.WriteLine("{0}", text);
         }
         Console.WriteLine("Last text output in loop: {0}", text);

		}
	}
}
