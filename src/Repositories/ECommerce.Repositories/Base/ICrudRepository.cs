using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ECommerce.Repository.Base
{
    /// <summary>
    /// Provides basic CRUD methods
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface ICrudRepository<T> where T : class
    {
        /// <summary>
        /// Creates or updates given Entity of type 'T'
        /// </summary>
        /// <param name="entity">Entity which will be created or updated</param>
        /// <returns>Updated or created entity</returns>
        Task<T> SaveAsync(T entity);

        /// <summary>
        /// Deletes entity
        /// </summary>
        /// <param name="id">Entity's unique identifier</param>
        /// <returns>Boolean value if the deletion operation has been successful</returns>
        Task DeleteAsync(T id);

        /// <summary>
        /// Returns single entity of type 'T'
        /// </summary>
        /// <param name="id">Entity's unique identifier</param>
        /// <returns>Found Entity</returns>
        Task<T> GetByIdAsync(Guid id);

        /// <summary>
        /// Gets all entities of type 'T';
        /// </summary>
        /// <returns>Enumerable collection of all found records of a given type</returns>
        IQueryable<T> GetAll();   
    }
}
