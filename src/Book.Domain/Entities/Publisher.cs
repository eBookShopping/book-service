namespace BookStore.Domain.Entities
{
    public class Publisher : FullAuditedEntity<Guid>
    {
        public required string Name { get; set; }
        public required Uri URL { get; set; }
        public required Address Address { get; set; }
        public required PhoneNumber Telephone { get; set; }
        public required PhoneNumber MobilePhone { get; set; }

        public ICollection<Book> Books { get; set; } = new HashSet<Book>();
    }
}