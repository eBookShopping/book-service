namespace BookStore.Domain.Entities
{
    public class Customer : FullAuditedEntity<Guid>
    {
        public required string Username { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required EmailAddress Email { get; set; }
        public required PhoneNumber MobilePhone { get; set; }
    }
}