using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    [Serializable]
    public class Person
    {
        public Person()
        {
            FirstName = "";
            LastName = "";
        }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        [NonSerialized]
        int age;
        public int Age 
        { 
            get { return age; } 
            set { age = value; } 
        }

        public string Birthday { get; set; }
    }
}
