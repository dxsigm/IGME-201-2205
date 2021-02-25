using System;

namespace OOPExample
{
    // Example code from Week 5
    // For which we created schUML
    // the schUML code is included as comments before each definition prefixed by ////
    class Program
    {
        // an interface defines the methods and properties which must be 
        // implemented by the classes which inherit it
        //// [+I:IDrawObject||DrawMe()]
        public interface IDrawObject
        {
            void DrawMe();
        }

        //// [+Shape|+PI:double;=x:double;=y:double|+Area():double:v;+DrawMe():v|();(x:double,y:double)]
        //// [+I:IDrawObject]^[+Shape]
        public class Shape : IDrawObject
        {
            // declare a const set to Math.PI
            public const double PI = Math.PI;

            // protected variables are accessible in derived classes
            // but not outside of the classes
            protected double x, y;

            public Shape()
            {
            }

            public Shape(double x, double y)
            {
                this.x = x;
                this.y = y;
            }

            // declare a virtual method to calculate the area using a default formula
            // this can be overridden by any derived classes
            public virtual double Area()
            {
                return this.x * this.y;
            }

            // the DrawMe() method is required due to inheriting the IDrawObject interface
            public virtual void DrawMe()
            {

            }
        }


        // derive a Circle class from the Shape class
        //// [+Circle||+Area():double|(r:double):base(r,0)]
        //// [+Shape]<-[+Circle]
        public class Circle : Shape
        {
            // have the constructor call the base constructor 
            // (ie. public Shape(double x, double y) on line #23)
            // base() is the keyword to call the parent constructor
            public Circle(double r) : base(r, 0)
            {
            }

            // override the Area() method with the equation for a Circle
            public override double Area()
            {
                return PI * x * x;
            }
        }

        // derive a Sphere class from Shape
        // note that no accessibility keyword is provided, therefore it defaults to private
        //// [-Sphere||+Area():double|(r:double):base(r,0)]
        //// [+Shape]<-[-Sphere]
        class Sphere : Shape
        {
            // have the constructor call the base constructor 
            // (ie. public Shape(double x, double y) on line #23)
            // base() is the keyword to call the parent constructor
            public Sphere(double r) : base(r, 0)
            {
            }

            // override the Area() method with the equation for a Sphere
            public override double Area()
            {
                return 4 * PI * x * x;
            }
        }

        // derive a Cylinder class from Shape
        // note that no accessibility keyword is provided, therefore it defaults to private
        //// [-Cylinder||+Area():double|(r:double,h:double):base(r,h)]
        //// [+Shape]<-[-Cylinder]
        class Cylinder : Shape
        {
            // have the constructor call the base constructor 
            // (ie. public Shape(double x, double y) on line #23)
            // base() is the keyword to call the parent constructor
            public Cylinder(double r, double h) : base(r, h)
            {
            }

            // override the Area() method with the equation for a Cylinder
            public override double Area()
            {
                return 2 * PI * x * x + 2 * PI * x * y;
            }
        }

        // derive a Rectangle class from Shape
        // note that no accessibility keyword is provided, therefore it defaults to private
        //// [-Rectangle|||(w:double,h:double):base(w,h)]
        //// [+Shape]<-[-Rectangle]
        class Rectangle : Shape
        {
            // have the constructor call the base constructor 
            // (ie. public Shape(double x, double y) on line #23)
            // base() is the keyword to call the parent constructor
            public Rectangle(double w, double h) : base(w, h)
            {
            }

            // note that we do not need to override the Area() method,
            // since the default method of the parent is the equation for the area of a rectangle
        }


        // define a completely unrelated class called Blood, which can also be drawn
        // (but not in the same way as a shape!)
        //// [+Blood||DrawMe():v]
        //// [+I:IDrawObject]^[+Blood]
        public class Blood : IDrawObject
        {
            public virtual void DrawMe()
            {

            }
        }


        static void Main()
        {
            double r = 3.0, h = 5.0;

            Circle circle = new Circle(r);
            Sphere sphere = new Sphere(r);
            Cylinder cylinder = new Cylinder(r, h);
            Rectangle rectangle = new Rectangle(r, h);

            Blood blood = new Blood();

            ///////////////////////////////////
            ///  Polymorphism examples
            // we can declare a variable of type IDrawObject
            IDrawObject drawObject;

            // reference it to a Sphere object
            drawObject = sphere;

            // then call the Sphere's DrawMe() method
            drawObject.DrawMe();

            // then set it to a Blood object
            drawObject = blood;

            // and call the Blood's DrawMe() method
            drawObject.DrawMe();

            // or we can have one function which accepts
            // the IDrawObject type and calls the DrawMe() method for the object passed in
            // Draw the Sphere object
            DrawObject(sphere);

            // Draw some blood!
            DrawObject(blood);

            // Call the overridden Area() method for each Shape object
            Console.WriteLine("Area of Circle   = {0:F2}", circle.Area());
            Console.WriteLine("Area of Sphere   = {0:F2}", sphere.Area());
            Console.WriteLine("Area of Cylinder = {0:F2}", cylinder.Area());
            Console.WriteLine("Area of Rectangle = {0:F2}", rectangle.Area());
        }

        // accept any object which inherits the IDrawObject interface
        static void DrawObject(IDrawObject obj)
        {           
            // and call its DrawMe() method
            obj.DrawMe();
        }
    }
}
