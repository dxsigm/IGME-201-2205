using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PeopleLib;
using CourseLib;

namespace OperatorOverloadExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            student1.age = 23;
            student1.gpa = 3.3;

            student1.city = "Rochester";


            Student student2 = new Student();
            student1.age = 18;
            student1.gpa = 3.5;

            if( student1 < student2)
            {
                Console.WriteLine("student 1 has a lower gpa than student 2");
            }

            Person person1 = student1;
            Person person2 = student2;

            if( person1 < person2 )
            {

            }

            if ((Person)student1 < (Student)student2)
            {
                Console.WriteLine("student 1 has a lower age than student 2");
            }

            Teacher teacher1 = new Teacher();
            teacher1.age = 45;

            if( (Person)teacher1 > (Person)student1 )
            {
                Console.WriteLine("teacher 1 has a higher age than student 1");
            }

        }
    }
}
