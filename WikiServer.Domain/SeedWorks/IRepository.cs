namespace WikiServer.Domain.SeedWorks
{
    public interface IRepository<T> : IDisposable where T : class
    {
        /// <summary>
        /// Gets All Entities
        /// </summary>
        IEnumerable<T> GetAll { get; }

        /// <summary>
        /// Get entity by identifier
        /// </summary>
        /// <param name="id">Identifier</param>
        /// <returns>Entity</returns>
        T GetById(params object[] id);

        /// <summary>
        /// Insert entity
        /// </summary>
        /// <param name="entity">Entity</param>
        void Insert(T entity);

        /// <summary>
        /// Update entity
        /// </summary>        
        /// <param name="entity">Entity</param>
        void Update(T entity);


        /// <summary>
        /// Delete entity by Id
        /// </summary>        
        /// <param name="id">Id or Ids (if table has composite primary key)</param>
        void Delete(params object[] id);

        /// <summary>
        /// Delete entity 
        /// </summary>
        /// <param name="entity">Entity</param>
        void Delete(T entity);
    }
}
