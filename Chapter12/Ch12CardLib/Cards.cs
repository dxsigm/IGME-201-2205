using System;
using System.Collections;

namespace Ch12CardLib
{
   
   public class Cards : CollectionBase, ICloneable
   {
      public object Clone()
      {
         Cards newCards = new Cards();
         foreach (Card sourceCard in List)
         {
            newCards.Add((Card)sourceCard.Clone() as Card);
         }
         return newCards;
      }

   
   
      
      
      public void Add(Card newCard)
      {
         List.Add(newCard);
      }

      public void Remove(Card oldCard)
      {
         List.Remove(oldCard);
      }

      public Cards()
      {
      }

      public Card this[int cardIndex]
      {
         get
         {
            return (Card)List[cardIndex];
         }
         set
         {
            List[cardIndex] = value;
         }
      }


      // Utility method for copying card instances into another Cards
      // instance - used in Deck.Shuffle(). This implementation assumes that
      // source and target collections are the same size.
      public void CopyTo(Cards targetCards)
      {
         for (int index = 0; index < this.Count; index++)
         {
            targetCards[index] = this[index];
         }
      }

      // Check to see if the Cards collection contains a particular card.
      // This calls the Contains method of the ArrayList for the collection,
      // which we access through the InnerList property.
      public bool Contains(Card card)
      {
         return InnerList.Contains(card);
      }
   }
}

