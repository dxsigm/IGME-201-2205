using System;
using System.Collections.Generic;

namespace Ch09Ex03
{
    class MyContent
    {
        public string myString;

        public System.Object GetCopy()
        {
            // this will create a new MyContent object and copy myString
            // from this into the new object
            // and return the new object as System.Object
            return MemberwiseClone();
        }
    }

    // inherit from the ICloneable interface to support deep copy
    class MyClass : ICloneable
    {
        // myContainingClass is a reference data type
        public MyContent myContainingClass = new MyContent();

        // val is a value data type
        public int val;

        // intArray is a reference data type
        public List<int> intArray = new List<int>();

        // the Clone() method is required by the interface
        // and should implement the deep copy of this class
        public System.Object Clone()
        {
            // first do a MemberwiseClone() of the top level of the class
            // this is a shallow copy which creates a new object and only copies the val field
            // myContainingClass and intArray will be copied by reference
            MyClass copy = (MyClass)this.MemberwiseClone();

            // call the MemberwiseClone() of the child class
            // by calling its GetCopy() method
            // note that MemberwiseClone is "protected" therefore it can only
            // be called within its own class
            // ie. we cannot do:
            // copy.myContainingClass = (MyContent)this.myContainingClass.MemberwiseClone();
            // MemberwiseClone() and Clone() return System.Object, therefore we need
            // to explicitly cast the object to the correct type
            copy.myContainingClass = (MyContent)this.myContainingClass.GetCopy();

            // GetRange() creates a new shoebox copy of a List<>
            copy.intArray = this.intArray.GetRange(0, this.intArray.Count);

            // return copy which is a MyClass object as System.Object
            // note that object = copy is valid (any class type can be referenced as an object)
            // but copy = object is invalid (any object cannot be any class type)
            // for example, a Ming vase can be easily turned into an object (if you drop it for example)
            //       object = Ming vase  (valid)
            // but any object cannot be a Ming vase!
            //       Ming vase = object (invalid)
            return copy;
        }
    }

    struct myStruct
    {
        public int val;
    }

    class ClassCopy
    {
        static void Main(string[] args)
        {
            MyClass objectA = new MyClass();
            objectA.val = 10;
            objectA.myContainingClass.myString = "david";

            // if we want to copy objectA into objectB
            MyClass objectB;

            // this is NOT the way to do it!
            // classes are reference data types
            // both variables are pointing to the same object
            // there is only 1 shoebox which was created by objectA
            objectB = objectA;

            // one way is to create the new object
            objectB = new MyClass();

            // and explicitly copy every class member
            objectB.val = objectA.val;

            // and copy each member of the containing class
            objectB.myContainingClass.myString = objectA.myContainingClass.myString;

            // deep copy uses the ICloneable interface
            // and depends on our creating a Clone() method in the class
            // that does the field-by-field member copy
            // create an interface variable
            ICloneable cloneable;

            // set the interface variable equal to the object to copy
            cloneable = objectA;

            // call the Clone() method and return the correct class type
            objectB = (MyClass)cloneable.Clone();

            // we could also just call Clone() via objectA
            objectB = (MyClass)objectA.Clone();

            // remember that structs are value data types!
            myStruct structA = new myStruct();
            myStruct structB = structA;

            // structA and structB are separate shoeboxes
            structA.val = 30;
            structB.val = 40;

            Console.WriteLine("objectA.val = {0}", objectA.val);
            Console.WriteLine("objectA.myContainingClass.myString = {0}", objectA.myContainingClass.myString);
            Console.WriteLine("objectB.val = {0}", objectB.val);
            Console.WriteLine("objectB.myContainingClass.myString = {0}", objectB.myContainingClass.myString);
            Console.WriteLine("structA.val = {0}", structA.val);
            Console.WriteLine("structB.val = {0}", structB.val);
        }
    }

}
