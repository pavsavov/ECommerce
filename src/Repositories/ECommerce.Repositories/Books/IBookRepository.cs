using ECommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Repositories.Books
{
    public interface IBookRepository
    {
        /// <summary>
        /// Finds and returns all entities of type 'Book', filtered by an expression.
        /// </summary>
        /// <param name="expression"></param>
        /// <returns>Collection of all found entities, evaluated against the given expression</returns>
        IQueryable<Book> FilterBooks(Expression<Func<Book, bool>> expression);
    }
}
