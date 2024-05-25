using Schmidt.Planning.Common.Abstractions;

namespace Schmidt.Planning.Domain.Entities
{
    public class User : IEntity
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
    }
}
