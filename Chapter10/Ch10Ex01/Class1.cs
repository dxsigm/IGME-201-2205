using System;

namespace Ch10Ex01
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
         Console.WriteLine("Creating object myObj...");
         MyClass myObj = new MyClass("My Object");
         Console.WriteLine("myObj created.");
         for (int i = -1; i <= 0; i++)
         {
            try
            {
               Console.WriteLine("\nAttempting to assign {0} to myObj.Val...",
                  i);
               myObj.Val = i;
               Console.WriteLine("Value {0} assigned to myObj.Val.", myObj.Val);
            }
            catch (Exception e)
            {
               Console.WriteLine("Exception {0} thrown.", e.GetType().FullName);
               Console.WriteLine("Message:\n\"{0}\"", e.Message);
            }
         }
         Console.WriteLine("\nOutputting myObj.ToString()...");
         Console.WriteLine(myObj.ToString());
         Console.WriteLine("myObj.ToString() Output.");
      }

	}
}
