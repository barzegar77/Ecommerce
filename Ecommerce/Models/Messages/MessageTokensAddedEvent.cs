namespace Ecommerce.Models.Messages
{
    public partial class MessageTokensAddedEvent<U>
    {
        public MessageTemplate Message { get; }
        public IList<U> Tokens { get; }
        public MessageTokensAddedEvent(MessageTemplate message, IList<U> tokens)
        {
            Message = message;
            Tokens = tokens;
        }

    }
}