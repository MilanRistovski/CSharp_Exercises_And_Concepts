using System;
using System.Collections.Generic;

namespace CSharpNetCoreDesignPatterns2
{
    class Program
    {
        static void Main(string[] args)
        {
            var messages = new List<IMessage>
            {
                new NormalDecorator(new SimpleMessage("First Message")),
                new NormalDecorator(new AlertMessage ("SEcond message with a beep!")),
                new ErrorDecorator(new AlertMessage("Third message with a beep and in red")),
                new SimpleMessage("No decoration")
            };

            foreach (var message in messages)
            {
                message.PrintMessage();
            }
            Console.ReadLine();
        }
    }
    interface IMessage
    {
        void PrintMessage();
    }
    abstract class Message : IMessage
    {
        protected string _text;
        public Message(string text)
        {
            _text = text;
        }
        abstract public void PrintMessage();
    }
    class SimpleMessage : Message
    {
        public SimpleMessage(string text) : base(text) { }
        public override void PrintMessage()
        {
            Console.WriteLine(_text);
        }
    }
    class AlertMessage : Message
    {
        public AlertMessage(string text) : base(text) { }
        public override void PrintMessage()
        {
            Console.Beep();
            Console.WriteLine(_text);
        }
    }
    abstract class MessageDecorator : IMessage
    {
        protected Message _message;
        public MessageDecorator(Message message)
        {
            _message = message;
        }
        public abstract void PrintMessage();
    }
    class NormalDecorator : MessageDecorator
    {
        public NormalDecorator(Message message) : base(message) { }
        public override void PrintMessage ()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            _message.PrintMessage();
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
    class ErrorDecorator : MessageDecorator
    {
        public ErrorDecorator(Message message) : base(message) { }
        public override void PrintMessage()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            _message.PrintMessage();
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
