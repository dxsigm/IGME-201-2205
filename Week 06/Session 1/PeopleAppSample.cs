using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PeopleLib;

namespace PeopleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            People peopleList = new People();

            Student student = new Student();

            student.email = "d@gmail.com";

            peopleList[student.email] = student;

            List<int> intList = new List<int>();

            foreach(int i in intList )
            {
                Console.WriteLine(i);
            }

            foreach( KeyValuePair<string,Person> keyValuePair in peopleList )
            {
                // keyValuePair.Key is the email string
                // keyValuePair.Value is the Person object
                Person thisPerson;
                thisPerson = keyValuePair.Value;

                if( thisPerson.GetType() == typeof(Student))
                {
                    Student thisStudent;
                    thisStudent = (Student)thisPerson;
                    thisStudent.gpa = 4.0;
                    thisStudent.Party();

                    ((Student)thisPerson).gpa = 4.0;
                }
            }

        }
    }
}
