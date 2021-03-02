using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using PeopleLib;

namespace PeopleApp
{
    class PeopleApp
    {
        static void Main(string[] args)
        {
            // create our People SortedList!
            People people = new People();

            // declare and initialize our person reference variable
            // we cannot create a Person object because Person is an abstract class
            Person person = null;

            string sAction = null;
            while (sAction != "quit")
            {
                Console.WriteLine();

                Console.Write("Add, Edit, Delete, List, Live, Quit => ");
                sAction = Console.ReadLine().ToLower();

                string email = null;

                switch (sAction)
                {
                    case "add":
                        person = null;

                        Console.Write("Person type (student/teacher) => ");
                        string sType = Console.ReadLine();

                        // create the person object depending on the type they selected
                        // note that an object of the Person class can point to either a Student or Teacher
                        if (sType.ToLower().StartsWith("s"))
                        {
                            person = new Student();
                        }
                        else
                        {
                            person = new Teacher();
                        }

                        // edit the new person
                        // we should explicitly pass the object as a reference to indicate 
                        // the object is being modified by the method
                        EditPerson(ref person);

                        // add the new person to the SortedList array using the email as index
                        // note that this uses the index property in the class which does additional exception handling
                        // to catch the case of a duplicated email index
                        people[person.email] = person;

                        // we could have done
                        //       people.sortedList.Add(email, person);
                        // but then we would need to add the exception handling here
                        // (exception handling is encapsulated in our People class)

                        break;

                    case "edit":
                        Console.Write("Email of person to edit => ");
                        email = Console.ReadLine();

                        person = people[email];

                        // if this email was not found in the list, the get property operator returns null
                        // note that because we overloaded the == operator, 
                        // we need to cast null as (object) to ensure that the signature does not match the existing overload
                        // otherwise it tries to treat null as a Person and raises an exception trying to access null.age
                        // test it yourself without the (object) cast!
                        if (person == (object)null)
                        {
                            Console.WriteLine("That email does not exist.");
                        }
                        else
                        {
                            // because there cannot be duplicates in the Sorted List
                            // remove the existing entry from the list
                            people.Remove(email);

                            // edit the selected person
                            EditPerson(ref person);

                            // re-add the updated person to the list
                            people[person.email] = person;
                        }
                        break;

                    case "delete":
                        Console.Write("Email of person to delete => ");
                        email = Console.ReadLine();

                        people.Remove(email);

                        break;

                    case "list":
                        int i = 0;

                        // list each person in the collection
                        // iterating through a Sorted List uses a special type called KeyValuePair
                        // each list entry has a Key and a Value
                        foreach (KeyValuePair<string, Person> thisEntry in people.sortedList)
                        {
                            // thisEntry.Key contains the email index
                            // and thisEntry.Value contains the Person object
                            // declare a Person reference variable to access all of the common fields of the derived classes
                            Person thisPerson = (Person)thisEntry.Value;

                            Console.Write($"{i + 1}: {thisPerson.email} | {thisPerson.name} | {thisPerson.age} | {thisPerson.LicenseId} | ");

                            if (thisPerson.GetType() == typeof(Student))
                            {
                                // gpa only belongs to Student, so we need a Student reference variable to output that
                                Student student = (Student)thisPerson;
                                Console.WriteLine($"{student.gpa}");
                            }

                            if (thisPerson.GetType() == typeof(Teacher))
                            {
                                // specialty only belongs to Teacher, so we need a Teacher reference variable to output that
                                Teacher teacher = (Teacher)thisPerson;
                                Console.WriteLine($"{teacher.specialty}");
                            }
                            ++i;
                        }

                        break;

                    case "live":
                        Console.Write("Email of person to live for a day => ");
                        email = Console.ReadLine();

                        person = people[email];

                        if (person != (object)null)
                        {
                            LiveADay(person);
                        }
                        break;
                }
            }
        }

        public static void EditPerson(ref Person thisPerson)
        {
            // for each field, display the current value, if any
            // only replace the value if a new value was entered

            Console.Write($"Email ({thisPerson.email}) => ");
            string sEmail = Console.ReadLine();
            if (sEmail.Length > 0)
            {
                thisPerson.email = sEmail;
            }

            Console.Write($"Name ({thisPerson.name}) => ");
            string sName = Console.ReadLine();
            if (sName.Length > 0)
            {
                thisPerson.name = sName;
            }

            do
            {
                Console.Write($"Age ({thisPerson.age})=> ");
                string sAge = Console.ReadLine();
                if (sAge.Length > 0)
                {
                    if (int.TryParse(sAge, out thisPerson.age))
                    {
                        break;
                    }
                }
                else
                {
                    break;
                }
            } while (true);

            do
            {
                Console.Write($"Drivers License ID ({thisPerson.LicenseId}) => ");
                string sLicenseID = Console.ReadLine();
                if (sLicenseID.Length > 0)
                {
                    int nLicenseId;
                    if (int.TryParse(sLicenseID, out nLicenseId))
                    {
                        // note that we cannot pass an operator field to int.TryParse()
                        // we need to use a temporary int variable to parse into
                        // the LicenseId property applies additional rules to setting the licenseId field
                        thisPerson.LicenseId = nLicenseId;
                        break;
                    }
                }
                else
                {
                    break;
                }
            } while (true);

            if (thisPerson.GetType() == typeof(Student))
            {
                Student thisStudent = (Student)thisPerson;

                do
                {
                    Console.Write($"GPA ({thisStudent.gpa})=> ");
                    string sGPA = Console.ReadLine();
                    if (sGPA.Length > 0)
                    {
                        if (double.TryParse(sGPA, out thisStudent.gpa))
                        {
                            break;
                        }
                    }
                    else
                    {
                        break;
                    }
                } while (true);
            }

            if (thisPerson.GetType() == typeof(Teacher))
            {
                Teacher thisTeacher = (Teacher)thisPerson;

                Console.Write($"Specialty ({thisTeacher.specialty})=> ");
                string sSpecialty = Console.ReadLine();
                if (sSpecialty.Length > 0)
                {
                    thisTeacher.specialty = sSpecialty;
                }
            }
        }

        public static void LiveADay(object obj)
        {
            // declare Person class reference variable
            Person person = (Person)obj;

            // declare IPerson interface reference variable
            IPerson iPerson = (IPerson)obj;

            // declare IStudent interface reference variable
            // initialize to null because we do not know if obj is Student or Teacher
            IStudent iStudent = null;

            // notice how we can use the IPerson interface to call Eat() for both Student and Teacher
            // because that method is defined in the shared interface
            iPerson.Eat();

            // notice how we can use a Person reference to call Work()
            // because the virtual method is defined in the shared Person class
            // even though the method implementation is different between the 2 classes
            person.Work();

            // but because Party() is only a member of Student
            // as a result of inheriting IStudent
            // we need to ensure obj is a Student
            if (obj.GetType() == typeof(Student))
            {
                // we use an IStudent reference to call Party()
                iStudent = (IStudent)person;
                iStudent.Party();
            }
        }
    }

}