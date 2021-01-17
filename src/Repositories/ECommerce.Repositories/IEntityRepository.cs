using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Repositories
{
    public interface IEntityRepository<TEntity>
    {
        /// <summary>
        /// Finds and returns all entities of type 'Book', filtered by an expression.
        /// </summary>
        /// <param name="expression"></param>
        /// <returns>Collection of all found entities, evaluated against the given expression</returns>
        IQueryable<TEntity> FilterSet(Expression<Func<TEntity, bool>> expression);
    }
}
