using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleLib
{
    public enum genderPronoun
    {
        him,
        her,
        them
    }
    public enum collegeYear : byte
    {
        freshman = 23,
        sophomore = 22,
        junior = 21,
        senior = 20
    }

    public interface ICourseList
    {
        List<string> CourseList
        {
            get;
            set;
        }
    }

    public abstract class Person
    {
        public string name;
        public int age;
        public genderPronoun eGender;
        public string email;

        public string photoPath;
        public string homePageURL;
        public DateTime dateOfBirth;

        private int licenseId;

        public int LicenseId
        {
            get
            {
                // get will simply return licenseId but it can do any logic
                return licenseId;
            }

            set
            {
                // we will only set the licenseId if the person is older than 16
                if (age > 16)
                {
                    licenseId = value;
                }
            }
        }

        public static bool operator <(Person p1, Person p2)
        {
            return (p1.age < p2.age);
        }

        public static bool operator >(Person p1, Person p2)
        {
            return (p1.age > p2.age);
        }

        public static bool operator <=(Person p1, Person p2)
        {
            return (p1.age <= p2.age);
        }

        public static bool operator >=(Person p1, Person p2)
        {
            return (p1.age >= p2.age);
        }

        public static bool operator ==(Person p1, Person p2)
        {
            return (p1.age == p2.age);
        }

        public static bool operator !=(Person p1, Person p2)
        {
            return (p1.age != p2.age);
        }

        public virtual void Work()
        {
            Console.WriteLine("work work work");
        }
    }

    public interface IStudent
    {
        void Party();
    }

    public interface IPerson
    {
        void Eat();
    }

    public class Student : Person, IPerson, IStudent, ICourseList
    {
        public double gpa;
        public collegeYear eCollegeYear;
        public List<string> courseCodes = new List<string>();

        public List<String> CourseList
        {
            get
            {
                return this.courseCodes;
            }

            set
            {
                this.courseCodes = value;
            }
        }

        public static bool operator <(Student s1, Student s2)
        {
            return (s1.gpa < s2.gpa);
        }

        public static bool operator <=(Student s1, Student s2)
        {
            return (s1.gpa <= s2.gpa);
        }

        public static bool operator >(Student s1, Student s2)
        {
            return (s1.gpa > s2.gpa);
        }

        public static bool operator >=(Student s1, Student s2)
        {
            return (s1.gpa >= s2.gpa);
        }

        public static bool operator ==(Student s1, Student s2)
        {
            return (s1.gpa == s2.gpa);
        }

        public static bool operator !=(Student s1, Student s2)
        {
            return (s1.gpa != s2.gpa);
        }

        public void Eat()
        {
            Console.WriteLine("Order a pizza!");
        }

        public void Party()
        {
            Console.WriteLine("Party on dude");
        }

    }

    public class Teacher : Person, IPerson, ICourseList
    {
        public string specialty;
        public List<string> courseCodes = new List<string>();

        public List<String> CourseList
        {
            get
            {
                return this.courseCodes;
            }

            set
            {
                this.courseCodes = value;
            }
        }

        public override void Work()
        {
            Console.WriteLine($"I'll tell you all about {specialty}.");
        }

        public void Eat()
        {
            Console.WriteLine("I eat lots of apples.");
        }
    }

    // [+People|sortedList:SortedList<string, Person>|this:email|+Remove(email: string)]
    public class People
    {
        // the generic SortedList class uses a template <> to store indexed data
        // the first type is the data type to index on
        // the second type is the data type to store in the list
        // create a Sorted List indexed on email (string) and storing Person objects
        public SortedList<string, Person> sortedList = new SortedList<string, Person>();

        public void Remove(string email)
        {
            if (email != null)
            {
                sortedList.Remove(email);
            }
        }

        // indexer property allows array access to sortedList via the class object
        // and catching missing keys and duplicate key exceptions 
        // notice the indexer property definition shows how it will be used in the calling code:
        // if we have:
        //     People people;
        // then we can call:
        //     people[email] to access the Person object with that email address
        // and value will be the Person object (person) being added to the list in the case of:
        //     people[email] = person;
        public Person this[string email]
        {
            get
            {
                Person returnVal;
                try
                {
                    returnVal = (Person)sortedList[email];
                }
                catch
                {
                    returnVal = null;
                }

                return (returnVal);
            }

            set
            {
                try
                {
                    // we can add to the list using these 2 methods
                    //      sortedList.Add(email, value);
                    sortedList[email] = value;
                }
                catch
                {
                    // an exception will be raised if an entry with a duplicate key is added
                    // duplicate key handling
                }
            }
        }
    }

}