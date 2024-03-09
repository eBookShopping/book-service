namespace BookStore.Domain.Entities
{
    public class Author : FullAuditedEntity<Guid>
    {
        public required string Name { get; set; }
        public required Uri URL { get; set; }
        public required Address Address { get; set; }

        public ICollection<Book> Books { get; set; } = new HashSet<Book>();
    }
}