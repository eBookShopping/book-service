namespace Book.Domain.Exceptions
{
    /// <summary>
    /// Base exception type for those are thrown by Domain Layer for Domain specific exceptions.
    /// </summary>
    [Serializable]
    public class DomainException : Exception
    {
        /// <summary>
        /// Creates a new <see cref="DomainException"/> object.
        /// </summary>
        /// <param name="message">Exception message</param>
        public DomainException (string message)
            : base (message) { }

        /// <summary>
        /// Creates a new <see cref="DomainException"/> object.
        /// </summary>
        /// <param name="message">Exception message</param>
        /// <param name="innerException">Inner exception</param>
        public DomainException(string message, Exception innerException)
            : base(message, innerException)
        { }
    }
}