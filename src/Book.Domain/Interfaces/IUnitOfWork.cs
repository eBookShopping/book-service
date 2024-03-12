namespace Book.Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        /// <summary>
        /// Commit the database Transaction
        /// </summary>

        void Commit();
        /// <summary>
        /// Start the database Transaction
        /// </summary>
        void CreateTransaction();

        /// <summary>
        /// Rollback the database Transaction
        /// </summary>
        void Rollback();

        /// <summary>
        /// Saves all changes until now in this unit of work.
        /// </summary>
        Task SaveChangesAsync();

        /// <summary>
        /// Get the shortcut to GetRepository for a specific entity having Guid as primary key.
        /// </summary>
        IRepository<TEntity, Guid> Repository<TEntity, Guid>() where TEntity : class, IEntity<Guid>;

        /// <summary>
        /// Get the repository for a specific entity.
        /// </summary>
        /// <typeparam name="TEntity">Main Entity type this repository works on</typeparam>
        /// <typeparam name="TPrimaryKey">Primary key type of the entity</typeparam>
        IRepository<TEntity, TPrimaryKey> GetRepository<TEntity, TPrimaryKey>() where TEntity : class, IEntity<TPrimaryKey>;
    }
}