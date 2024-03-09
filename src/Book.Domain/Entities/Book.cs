namespace BookStore.Domain.Entities
{
    public class Book : FullAuditedEntity<Guid>
    {
        public required string ISBN { get; set; }
        public required string Title { get; set; }
        public required int Year { get; set; }
        public required Money Price { get; set; }

        public required Publisher Publisher { get; set; }
        public required Author Author { get; set; }
    }
}