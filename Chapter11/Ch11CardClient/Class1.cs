using System;
using Ch11CardLib;

namespace Ch11CardClient
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
         Deck deck1 = new Deck();
         try
         {
            Card myCard = deck1.GetCard(60);
         }
         catch (CardOutOfRangeException e)
         {
            Console.WriteLine(e.Message);
            Console.WriteLine(e.DeckContents[0]);
         }


		}
	}
}
