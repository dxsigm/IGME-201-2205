using System;

namespace Ch06Ex03
{
	/// <summary>
	/// Summary description for Class1.
	/// </summary>
	class Class1
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
      static int sumVals(params int[] vals)
      {
         int sum = 0;
         foreach (int val in vals)
         {
            sum += val;
         }
         return sum;
      }

      static void Main(string[] args)
      {
         int sum = sumVals(1, 5, 2, 9, 8);
         Console.WriteLine("Summed Values = {0}", sum);
      }

	}
}
