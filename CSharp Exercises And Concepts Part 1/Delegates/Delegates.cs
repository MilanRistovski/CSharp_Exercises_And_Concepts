using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates
{
    class Delegates
    {
        public int MethodIWantToCall(string input)
        {
            return input.Length;
        }

        public int Age;

        public int ReturnAgeMethod(int age)
        {
            Age = age;

            if (age > 22)
            {
                Console.WriteLine("You are allowed to enter here");
                return age;
            }
            else
            {
                Console.WriteLine("You are not allowed in here");
                return -1;
            }

        }
        public EventHandler Shout;
        public int AngerLevel;
        public void Poke()
        {
            AngerLevel++;
            if (AngerLevel >= 3)
            {
                Shout?.Invoke(this, EventArgs.Empty);
            }
        }
        //TWO DEFAULT DELEGATES USED AS EVENTS
        public delegate void EventHandler(object sender, EventArgs e);
        public delegate void EventHandler<TEventArgs>(object sender, TEventArgs e);

    }
}
