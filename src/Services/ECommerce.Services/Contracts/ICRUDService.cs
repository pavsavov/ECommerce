using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Services.Contracts
{
    public interface ICRUDService<T> where T : class
    {
        /// <summary>
        /// Create an entity.
        /// </summary>
        /// <param name="entity">Entity which will be persisted</param>
        /// <returns>Created entity</returns>
        Task<T> Create(T entity);

        /// <summary>
        /// Deletes and entity by given Entity's id
        /// </summary>
        /// <param name="id">Unique identifier for searching existing Entity which will be deleted</param>
        /// <returns>Boolean value if the deletion operation has been successful</returns>
        Task<bool> Delete(string id);

        /// <summary>
        /// Returns an Entity, searched by given id
        /// </summary>
        /// <param name="id">Identifier of the searched Entity that needs to be retrieved</param>
        /// <returns>The Entity found by it's id</returns>
        Task<T> GetById(string id);

        /// <summary>
        /// Updates an existing Entity.
        /// </summary>
        /// <param name="Entity">Entity with new values</param>
        /// <returns>The updated entity with new values</returns>
        Task<T> Update(T Entity);

        /// <summary>
        /// Gets all Entities;
        /// </summary>
        /// <returns>Enumerable collection of all found records of a given type</returns>
        Task<IEnumerable<T>> GetAll();

    }
}
