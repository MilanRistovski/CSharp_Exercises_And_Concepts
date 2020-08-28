using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace CSharp_Exercises_And_Concepts_Part_1
{
    public static class StringExtensions
    {
        public static bool IsValidEmail(this string input)
        {
            return Regex.IsMatch(input, @"[a-zA-Z0-9\.-_] + @[a-zA-Z0-9\.-_] +");
        }
    }
}
