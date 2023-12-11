using System;

namespace HomeWork5.Subscriber
{
    public class MessageConsumer : IMessageListener
    {
        public void OnMessagePublished(string message)
        {
            Console.WriteLine($"Consumer with hash: {GetHashCode()} receives message: {message}");
        }
    }
}