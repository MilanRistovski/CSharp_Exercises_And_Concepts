using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;


namespace XMLSerialization
{
    public class Person
    {
        public Person() { }
        public Person(decimal initialSalary)
        {
            initialSalary = Salary;
        }
        [XmlAttribute("dob")]
        public DateTime DateOfBirth { get; set; }

        [XmlAttribute("fname")]
        public string FirstName { get; set; }

        protected decimal Salary { get; set; }
        public HashSet<Person> Children { get; set; }

        [XmlAttribute("lname")]
        public string LastName { get; set; }
    }
}
