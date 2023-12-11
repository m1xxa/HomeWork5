using System.Collections.Generic;

namespace HomeWork5.Subscriber
{
    public class MessageBus
    {
        private readonly List<IMessageListener> _listeners = new();

        public void Subscribe(IMessageListener listener)
        {
            _listeners.Add(listener);
        }

        public void PublishMessage(string message)
        {
            foreach (var listener in _listeners)
            {
                listener.OnMessagePublished(message);
            }
        }
    }
}