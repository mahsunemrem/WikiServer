namespace WikiServer.Domain.SeedWorks
{
    public interface IRepository<T> : IDisposable where T : class
    {
        /// <summary>
        /// Gets All Entities
        /// </summary>
        IEnumerable<T> GetAll { get; }

        IQueryable<T> GetAllNoTracking { get; }

        /// <summary>
        /// Get entity by identifier
        /// </summary>
        /// <param name="id">Identifier</param>
        /// <returns>Entity</returns>
        Task<T> GetById(params object[] id);

        /// <summary>
        /// Insert entity
        /// </summary>
        /// <param name="entity">Entity</param>
        Task Insert(T entity);

        /// <summary>
        /// Update entity
        /// </summary>        
        /// <param name="entity">Entity</param>
        void Update(T entity);


        /// <summary>
        /// Delete entity by Id
        /// </summary>        
        /// <param name="id">Id or Ids (if table has composite primary key)</param>
     //   Task Delete(params object[] id);

        /// <summary>
        /// Delete entity 
        /// </summary>
        /// <param name="entity">Entity</param>
        Task Delete(T entity);
    }
}
