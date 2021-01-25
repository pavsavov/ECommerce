using ECommerce.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ECommerce.Services.Base
{
    public interface ICrudService<T> where T : ServiceModel
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
        /// <param name="deleteObject">Entity to be deleted</param>
        /// <returns>Boolean value if the deletion operation has been successful</returns>
        Task<bool> DeleteAsync(T deleteObject);

        /// <summary>
        /// Returns single entity of type 'T'
        /// </summary>
        /// <param name="id">Entity's unique identifier</param>
        /// <returns>Found Entity</returns>
        Task<T> GetByIdAsync(Guid? id);

        /// <summary>
        /// Gets all entities of type 'T';
        /// </summary>
        /// <returns>Enumerable collection of all found records of a given type</returns>
        Task<IEnumerable<T>> GetAllAsync();

        /// <summary>
        /// Finds and returns all entities of type 'T', filtered by an expression.
        /// </summary>
        /// <param name="expression"></param>
        /// <returns>Collection of all found entities, evaluated against the given expression</returns>
        Task<IEnumerable<T>> FilterByAsync(Expression<Func<T, bool>> expression);
    }
}
