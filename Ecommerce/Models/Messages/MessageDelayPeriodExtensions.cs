namespace Ecommerce.Models.Messages
{
    public static class MessageDelayPeriodExtensions
    {
        public static int ToHours(this MessageDelayPeriod period, int value)
        {
            return period switch
            {
                MessageDelayPeriod.Hours => value,
                MessageDelayPeriod.Days => value * 24,
                _ => throw new ArgumentOutOfRangeException(nameof(period)),
            };
        }
    }
}