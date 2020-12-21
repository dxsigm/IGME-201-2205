using System;

namespace Ch11Ex02
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
         Animals animalCollection = new Animals();
         animalCollection.Add(new Cow("Jack"));
         animalCollection.Add(new Chicken("Vera"));
         foreach (Animal myAnimal in animalCollection)
         {
            myAnimal.Feed();
         }

		}
	}
}
