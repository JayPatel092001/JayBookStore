using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace JayBooks.DataAccess.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        T Get(int id);  //retrive category by id
        IEnumerable<T> GetAll(
            Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            String includeProperties = null  //usefull for foreign key refrences
            );

        T GetFirstOrDefault(
           Expression<Func<T, bool>> filter = null,
           String includeProperties = null
           );

        void Add(T entity); // to add  an entity
        void Remove(int id); // to remove an object or category
        void Remove(T entity); //another way to remove object 
        void RemoveRange(IEnumerable<T> entity); //remove a complete range of entities
    }
}
