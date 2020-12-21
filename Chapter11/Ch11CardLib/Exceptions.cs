using System;


namespace Ch11CardLib
{
	/// <summary>
	/// Summary description for Exceptions.
	/// </summary>
   public class CardOutOfRangeException : Exception
   {
      private Cards deckContents;

      public Cards DeckContents
      {
         get
         {
            return deckContents;
         }
      }

      public CardOutOfRangeException(Cards sourceDeckContents) :
         base("There are only 52 cards in the deck.")
      {
         deckContents = sourceDeckContents;
      }
   }

}
