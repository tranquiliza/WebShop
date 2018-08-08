using System.Collections.Generic;

namespace Giftcard.Repositories.Abstractions
{
    public interface IBaseRepository<T> where T : class
    {
        void Update(T entity);
        void Insert(T entity);
        void Delete(T entity);
        ICollection<T> Get();
        T Get(int id);
    }
}
