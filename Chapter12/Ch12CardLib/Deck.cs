using System;

namespace Ch12CardLib
{
	   public delegate void LastCardDrawnHandler(Deck currentDeck);
   
   /// <summary>
	   /// Summary description for Deck.
	/// </summary>
   public class Deck : ICloneable
   {
      public object Clone()
      {
         Deck newDeck = new Deck((Cards)cards.Clone() as Cards);
         return newDeck;
      }

      private Deck(Cards newCards)
      {
         cards = newCards;
      }

      private Cards cards = new Cards();

      public Deck()
      {
         // line of code removed here.
         for (int suitVal = 0; suitVal < 4; suitVal++)
         {
            for (int rankVal = 1; rankVal < 14; rankVal++)
            {
               cards.Add(new Card((Suit)suitVal, (Rank)rankVal));
            }
         }
      }

      // Non-default constructor. Allows aces to be set high.
      public Deck(bool isAceHigh) : this()
      {
         Card.isAceHigh = isAceHigh;
      }

      // Non-default constructor. Allows a trump suit to be used.
      public Deck(bool useTrumps, Suit trump) : this()
      {
         Card.useTrumps = useTrumps;
         Card.trump = trump;
      }

      // Non-default constructor. Allows aces to be set high and a trump suit
      // to be used.
      public Deck(bool isAceHigh, bool useTrumps, Suit trump) : this()
      {
         Card.isAceHigh = isAceHigh;
         Card.useTrumps = useTrumps;
         Card.trump = trump;
      }

      public event LastCardDrawnHandler LastCardDrawn;

      public Card GetCard(int cardNum)
      {
         if (cardNum >= 0 && cardNum <= 51)
         {
            if ((cardNum == 51) && (LastCardDrawn != null))
               LastCardDrawn(this);
            return cards[cardNum];
         }
         else
            throw new CardOutOfRangeException((Cards)cards.Clone() as Cards);
         //throw (new System.ArgumentOutOfRangeException("cardNum", cardNum,
         //      "Value must be between 0 and 51."));
      }

      public void Shuffle()
      {
         Cards newDeck = new Cards();
         bool[] assigned = new bool[52];
         Random sourceGen = new Random();
         for (int i = 0; i < 52; i++)
         {
            int sourceCard = 0;
            bool foundCard = false;
          
            while (foundCard == false)
            {
               sourceCard = sourceGen.Next(52);
               if (assigned[sourceCard] == false)
                  foundCard = true;
            }
            assigned[sourceCard] = true;
            newDeck.Add(cards[sourceCard]);
         }
        newDeck.CopyTo(cards);
      }
   

		
   }
}
