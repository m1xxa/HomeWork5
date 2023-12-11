namespace HomeWork5.Subscriber
{
    public interface IMessageListener
    {
        void OnMessagePublished(string message);
    }
}