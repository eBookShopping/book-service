namespace Book.Domain.Exceptions
{
    /// <summary>
    /// This exception is thrown if an entity excepted to be found but not found.
    /// </summary>
    [Serializable]
    public class EntityNotFoundException : DomainException
    {
        private const string _errorFormat = "There is no such an entity. Entity type: {0}, id: {1}";

        /// <summary>
        /// Creates a new <see cref="EntityNotFoundException"/> object.
        /// </summary>
        public EntityNotFoundException(Type entityType, object id)
            : base(string.Format(_errorFormat, entityType.FullName, id))
        { }

        /// <summary>
        /// Creates a new <see cref="EntityNotFoundException"/> object.
        /// </summary>
        public EntityNotFoundException(Type entityType, object id, Exception innerException)
            : base(string.Format(_errorFormat, entityType.FullName, id), innerException)
        { }

        /// <summary>
        /// Creates a new <see cref="EntityNotFoundException"/> object.
        /// </summary>
        /// <param name="message">Exception message</param>
        public EntityNotFoundException(string message)
            : base(message)
        { }

        /// <summary>
        /// Creates a new <see cref="EntityNotFoundException"/> object.
        /// </summary>
        /// <param name="message">Exception message</param>
        /// <param name="innerException">Inner exception</param>
        public EntityNotFoundException(string message, Exception innerException)
            : base(message, innerException)
        { }
    }
}