using System.Linq.Expressions;

namespace WikiServer.Application.Interfaces
{
    public interface IBusinessService<T> : IDisposable where T : class
    {
        /// <summary>
        /// Verilen ID'lerle eşleşen entity'i veritabanından alır.
        /// </summary>
        /// <param name="id">Entity'nin ID değerleri.</param>
        /// <returns>
        /// Eşleşen <typeparamref name="T"/> tipindeki entity.
        /// </returns>
        /// <remarks>
        /// <para>ID değerlerinin türü ve sırası, belirli bir entity tipi için önemlidir. 
        /// Birden çok ID parametresi, composite key'ler ile çalışırken kullanılabilir.</para>
        /// <para>Bu metot, öncelikle ID'ye göre hızlı bir şekilde sorgulama yapmak için kullanılır.</para>
        /// Örnek kullanım:
        /// <code>
        /// var user = repository.GetById(new object[] { userId });
        /// </code>
        /// Bu örnekte, belirtilen ID değerine sahip kullanıcı veritabanından alınır.
        /// </remarks>
        Task<T> GetByIdAsync(params object[] id);

        /// <summary>
        /// Belirtilen entity'i veritabanına ekler veya varsa günceller.
        /// </summary>
        /// <param name="entity">Eklenmesi veya güncellenmesi gereken entity.</param>
        /// <remarks>
        /// Bu metot, <typeparamref name="T"/> tipindeki bir entity alır ve bu entity'nin veritabanında
        /// olup olmadığını kontrol eder. Eğer entity veritabanında mevcut değilse ekler, varsa günceller.
        /// <para>Örnek kullanım:</para>
        /// <code>
        /// var user = new IdentityUser { Name = "Yeni Kullanıcı", Email = "email@example.com" };
        /// repository.AddOrUpdate(user);
        /// </code>
        /// Bu örnekte, <c>IdentityUser</c> tipindeki bir kullanıcı eklenir veya güncellenir.
        /// </remarks>
        Task AddAsync(T entity);
        Task Update(T entity);
        /// <summary>
        /// Verilen ID değerlerine karşılık gelen entity'i veritabanından siler.
        /// </summary>
        /// <param name="id">Silinecek entity'nin ID değerleri.</param>
        /// <remarks>
        /// Birden fazla ID parametresi verilebilir, bu durumda karşılık gelen tüm entity'ler silinir.
        /// </remarks>
       // Task DeleteAsync(params object[] id);
        Task DeleteAsync(T entity);

        /// <summary>
        /// Verilen entity'i veritabanından siler.
        /// </summary>
        /// <param name="entity">Silinecek entity.</param>
        /// <remarks>
        /// Bu metot, <typeparamref name="T"/> tipindeki bir entity alır ve bu entity'yi veritabanından siler.
        /// Örnek kullanım:
        /// <code>
        /// var user = repository.GetById&lt;IdentityUser&gt;(userId);
        /// repository.Delete(user);
        /// </code>
        /// Bu örnekte, veritabanından bir <c>IdentityUser</c> tipindeki kullanıcı silinir.
        /// </remarks>
       // void Delete(T entity);

        /// <summary>
        /// Belirtilen koşula göre entity'leri bulur ve döndürür.
        /// </summary>
        /// <param name="predicate">Entity'lerin filtreleneceği koşul ifadesi.</param>
        /// <param name="noTracking">Eğer true ise, bulunan entity'ler context üzerinde izlenmez (no-tracking).</param>
        /// <returns>
        /// Koşulu karşılayan <typeparamref name="T"/> tipindeki entity'lerin listesi.
        /// </returns>
        /// <remarks>
        /// <para>noTracking parametresi, performansı artırmak için kullanılabilir. Eğer true olarak belirlenirse, 
        /// bulunan entity'ler üzerinde yapılan değişiklikler context tarafından takip edilmez ve bu da 
        /// sorgu performansını iyileştirir.</para>
        /// <para>Bu metot, LINQ ifadeleri kullanılarak sorgulamalar yapılmasına olanak tanır.</para>
        /// Örnek kullanım:
        /// <code>
        /// var activeUsers = repository.Find(user => user.IsActive, noTracking: true);
        /// </code>
        /// Bu örnekte, aktif kullanıcılar no-tracking ile bulunur ve bir koleksiyon olarak döndürülür.
        /// </remarks>
        Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate, bool noTracking = true);

        Task<IEnumerable<T>> GetAll();

        Task<T> FirstOrDefault(Expression<Func<T, bool>> where, bool noTracking = false);

    }
}
