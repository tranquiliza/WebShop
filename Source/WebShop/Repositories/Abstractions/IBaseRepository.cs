using System.Collections.Generic;

namespace WebShop.Repositories.Abstractions
{
    interface IBaseRepository<T> where T : class
    {
        void Update(T entity);
        void Insert(T entity);
        void Delete(T entity);
        ICollection<T> Get();
        T Get(int id);
    }
}
