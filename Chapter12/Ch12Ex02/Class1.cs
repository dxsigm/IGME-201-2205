using System;

namespace Ch12Ex02
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
         Connection myConnection = new Connection();
         Display myDisplay = new Display();
         myConnection.MessageArrived +=
            new MessageHandler (myDisplay.DisplayMessage);
         myConnection.Connect();
         Console.ReadLine();

		}
	}
}
