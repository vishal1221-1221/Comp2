namespace TweetApp.Api.RabbitMQSender
{
    public interface IRabbitMQMessageSender
    {
        void Publish(string message);
    }
}
