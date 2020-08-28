using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Delegates d1 = new Delegates();
            int answer = d1.MethodIWantToCall("Frog");

            d1.ReturnAgeMethod(23);

            var d = new DelegateWithMatchingSignature(d1.MethodIWantToCall);
            var intmethod = new DelegateForReturnAgeMethod(d1.ReturnAgeMethod);
            int answer3 = intmethod(15);

            Console.WriteLine(answer3);
            int answer2 = d("Frog");

            Console.WriteLine(answer2);
            d1.Shout = Delegate_Shout;
            d1.Poke();
            d1.Poke();
            d1.Poke();
            d1.Poke();

            var gt1 = new GenericThing<int>();
            gt1.Data = 22;
            Console.WriteLine($"GenericThing with an integer: {gt1.Process(22)}");

            var gt2 = new GenericThing<string>();
            gt2.Data = "apple";
            Console.WriteLine($"GenericThing with a string: {gt2.Process("apple")}");

            var gt3 = new GenericThing<int>();
            gt3.Data = 33;
            Console.WriteLine($"Processing Method: {gt3.Processing(44)}");

            //int number1 = 4;
            //Console.WriteLine($"{0} squared is {1}", arg0:number1, arg1:Squarer.Squarish<int>(number1));

            var dv1 = new DisplacementVector(3, 5);
            var dv2 = new DisplacementVector(8, 11);

            var dv3 = dv1 + dv2;
            Console.WriteLine($"({dv1.X}, {dv1.Y}) + ({dv2.X}, {dv2.Y}) = ({dv3.X}, {dv3.Y})");
        }
        delegate int DelegateWithMatchingSignature(string s);
        delegate int DelegateForReturnAgeMethod(int i);
        private static void Delegate_Shout(object sender, EventArgs e)
        {
            Delegates d1 = (Delegates)sender;
            Console.WriteLine($"{d1.Age} is this angry: {d1.AngerLevel}.");
        }
    }
}
