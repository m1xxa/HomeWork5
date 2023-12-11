using System;

namespace HomeWork5.Subscriber
{
    public class MessageProducer
    {
        private readonly MessageBus _messageBus;

        public MessageProducer(MessageBus messageBus)
        {
            _messageBus = messageBus;
        }

        public void SendMessage(string message)
        {
            Console.WriteLine($"Producer sends message: {message}");
            _messageBus.PublishMessage(message);
        }
    }
}