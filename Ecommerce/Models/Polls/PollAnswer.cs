namespace Ecommerce.Models.Polls
{
    public partial class PollAnswer
    {
        public int Id { get; set; }
        public int PollId { get; set; }
        public string Name { get; set; }
        public int NumberOfVotes { get; set; }
        public int DisplayOrder { get; set; }
    }
}