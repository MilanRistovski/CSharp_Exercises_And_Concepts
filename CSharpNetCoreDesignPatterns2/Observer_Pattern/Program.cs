using System;
using System.Xml;

namespace Observer_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var subject = new Subject();
            var greenObserver = new Observer(ConsoleColor.Green);
            var redObserver = new Observer(ConsoleColor.Red);
            var blueObserver = new Observer(ConsoleColor.Blue);

            subject.OnQuantityUpdated += greenObserver.ObserverQuantity;
            subject.OnQuantityUpdated += blueObserver.ObserverQuantity;
            subject.OnQuantityUpdated += redObserver.ObserverQuantity;

            subject.UpdateQuantity(12);
            subject.UpdateQuantity(44);
        }
        class Subject
        {
            private int _quantity = 0;
            public void UpdateQuantity (int value)
            {
                _quantity += value;
                OnQuantityUpdated?.Invoke(_quantity);
            }
            public delegate void QuantityUpdated(int quantity);
            public event QuantityUpdated OnQuantityUpdated;
        }

        class Observer
        {
            ConsoleColor _color;
            public Observer(ConsoleColor color)
            {
                _color = color;
            }
            internal void ObserverQuantity(int quantity)
            {
                Console.ForegroundColor = _color;
                Console.WriteLine($"I observer the new cuantity value of {quantity}");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        

    }
}
