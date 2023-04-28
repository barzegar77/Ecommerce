namespace Ecommerce.Models.Messages
{
    public partial class AdditionalTokensAddedEvent
    {
        public AdditionalTokensAddedEvent()
        {
            AdditionalTokens = new List<string>();
        }

        public void AddTokens(params string[] additionalTokens)
        {
            foreach (var additionalToken in additionalTokens)
            {
                AdditionalTokens.Add(additionalToken);
            }
        }

        public IList<string> AdditionalTokens { get; }
        public IEnumerable<string> TokenGroups { get; set; }
    }
}