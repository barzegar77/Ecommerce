namespace Ecommerce.Models.Polls
{
    public partial class PollVotingRecord
    {
        public int Id { get; set; }
        public int PollAnswerId { get; set; }
        public int CustomerId { get; set; }
        public DateTime CreatedOnUtc { get; set; }
    }
}