using System;

namespace Ch11Ex02
{
	/// <summary>
	/// Summary description for Animal.
	/// </summary>
   
      public abstract class Animal
      {
         protected string name;

         public string Name
         {
            get
            {
               return name;
            }
            set
            {
               name = value;
            }
         }

         public Animal()
         {
            name = "The animal with no name";
         }

         public Animal(string newName)
         {
            name = newName;
         }

         public void Feed()
         {
            Console.WriteLine("{0} has been fed.", name);
         }

         public Animal this[int animalIndex]
         {
            get
            {
               return null;
            }
            set
            {
            }
         }
      }
      public class Cow : Animal
      {
         public void Milk()
         {
            Console.WriteLine("{0} has been milked.", name);
         }

         public Cow(string newName) : base(newName)
         {
         }
      }

      public class Chicken : Animal
      {
         public void LayEgg()
         {
            Console.WriteLine("{0} has laid an egg.", name);
         }

         public Chicken(string newName) : base(newName)
         {
         }
      }
   

}
