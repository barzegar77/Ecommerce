namespace Ecommerce.Models.Messages
{
    public partial class EmailUnsubscribedEvent
    {
        public EmailUnsubscribedEvent(NewsLetterSubscription subscription)
        {
            Subscription = subscription;
        }

        public NewsLetterSubscription Subscription { get; }

        public bool Equals(EmailUnsubscribedEvent other)
        {
            if (other is null)
                return false;

            if (ReferenceEquals(this, other))
                return true;

            return Equals(other.Subscription, Subscription);
        }

        public override bool Equals(object obj)
        {
            if (obj is null)
                return false;

            if (ReferenceEquals(this, obj))
                return true;

            if (obj.GetType() != typeof(EmailUnsubscribedEvent))
                return false;

            return Equals((EmailUnsubscribedEvent)obj);
        }

        public override int GetHashCode()
        {
            return Subscription != null ? Subscription.GetHashCode() : 0;
        }
    }
}