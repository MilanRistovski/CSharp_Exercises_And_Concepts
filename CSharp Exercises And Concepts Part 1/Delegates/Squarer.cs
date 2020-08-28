using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;


namespace Delegates
{
    public static class Squarer
    {
        public static double Square<T>(T input) where T : IConvertible
        {
            double d = input.ToDouble(Thread.CurrentThread.CurrentCulture);
            return d * d;
        }

        //public static int Squarish<R>(Thread input1) where R : IConvertible 
        //    {
        //    int x = input1.(Thread.CurrentThread.CurrentCulture);
        //    return x * x;
        //    }
    }
}
