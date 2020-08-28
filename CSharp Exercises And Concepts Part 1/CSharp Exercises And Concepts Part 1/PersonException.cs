using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Exercises_And_Concepts_Part_1
{
    public class PersonException : Exception
    {
        public PersonException() : base() { }
        public PersonException(string message) : base(message) { }

        public PersonException(string message, Exception innerException) : base(message, innerException) { }
    }
}
