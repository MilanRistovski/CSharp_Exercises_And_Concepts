using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Exercises_And_Concepts_Part_1
{
    public class Employee : Person
    {
        public string EmployeeCode { get; set; }
        public DateTime HireDate { get; set; }

        public void WriteToConSole()
        {
            Console.WriteLine($"{Name} was born on {DateOfBirth} and hired on {HireDate}");
        }
    }
}
