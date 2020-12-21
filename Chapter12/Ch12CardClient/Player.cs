using System;
using Ch12CardLib;

namespace Ch12CardClient
{
   public class Player
   {
      private Cards hand;
      private string name;

      public string Name
      {
         get
         {
            return name;
         }
      }

      public Cards PlayHand
      {
         get
         {
            return hand;
         }
      }

      private Player()
      {
      }

      public Player(string newName)
      {
         name = newName;
         hand = new Cards();
      }

      public bool HasWon()
      {
         bool won = true;
         Suit match = hand[0].suit;
         for (int i = 1; i < hand.Count; i++)
         {
            won &= hand[i].suit == match;
         }
         return won;
      }
   }
}

