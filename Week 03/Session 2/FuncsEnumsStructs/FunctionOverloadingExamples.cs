using System.IO;
using System;

class Program
{
    // these are overloaded functions
    // they have the same names (Add and Change) but different return types and parameter types
    // the compiler will choose which function to call based on the context of the call

    static int Add(int val1, int val2)
    {
        int returnVal;


        returnVal = val1 + val2;
        val1 = 45;

        return (returnVal);
    }

    static int Add(string val1, string val2)
    {
        int returnVal;

        returnVal = Convert.ToInt32(val1) + Convert.ToInt32(val2);

        return (returnVal);
    }

    static string Add(double val1, double val2)
    {
        string returnVal;

        returnVal = val1.ToString() + val2.ToString();

        return (returnVal);
    }

    static void Change(int val)
    {
        // this function passes val by value and only creates a copy of the variable within the function
        // the passed variable contents are not changed
        val = 123;
    }

    static void Change(ref int val)
    {
        // this function passes val by reference
        // any changes to val are also made to the passed variable in the calling program (ie. changeMe in this case)
        val = 123;
    }

    static void Main()
    {
        // this will call Add(int int)
        Console.WriteLine("5 + 5 = " + Add(5, 5));

        // this will call Add(double, double)
        Console.WriteLine("5.0 + 5.0 = " + Add(5.0, 5.0));

        // this will call Add(string, string)
        Console.WriteLine("\"5\" + \"5\" = " + Add("5", "5"));

        // Add(int, double) will work because Add(double, double) will implicitly convert the int parameter to a double
        Console.WriteLine("5 + 5.0 = " + Add(5, 5.0));

        // this line will give a compile error because no function signature matches Add(int, string)
        //Console.WriteLine("5 + \"5\" = " + Add(5, "5"));

        Console.WriteLine();

        // test calling a function and passing a parameter by value
        int changeMe = 456;
        Console.WriteLine("Value before Change(int val): " + changeMe);
        Change(changeMe);
        Console.WriteLine("Value after Change(int val): " + changeMe);

        Console.WriteLine();

        // test calling a function and passing a parameter by reference
        changeMe = 456;
        Console.WriteLine("Value before Change(ref int val): " + changeMe);
        Change(ref changeMe);
        Console.WriteLine("Value after Change(ref int val): " + changeMe);
    }
}