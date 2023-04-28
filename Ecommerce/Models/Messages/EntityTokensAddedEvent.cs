namespace Ecommerce.Models.Messages
{
    public partial class EntityTokensAddedEvent<T, U>
    {
        public int Id { get; set; }

        public EntityTokensAddedEvent(T entity, IList<U> tokens)
        {
            Entity = entity;
            Tokens = tokens;
        }
        public T Entity { get; }

        public IList<U> Tokens { get; }
    }
}