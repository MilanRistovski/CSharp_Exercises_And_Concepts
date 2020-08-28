using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates
{
    public class GenericThing<T> where T : IComparable
    {
        public T Data = default(T);
        public string Process(T input)
        {
            if (Data.CompareTo(input) == 0)
            {
                return "Data and input are the same";
            }
            else
            {
                return "Data and input are NOT the same.";
            }
        }

        public string Processing(T input1)
        {
            if (Data.GetType() == input1.GetType())
            {
                return "Data and INPUT1 are the same type";
            }
            else
            {
                return "Data and INPUT1 aren't the same type";
            }
        }
    }
}
