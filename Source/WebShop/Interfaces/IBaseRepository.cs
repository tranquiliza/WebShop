using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebShop.Repositories.Abstractions
{
    public interface IBaseRepository<T> where T : class
    {
        void Update(T entity);
        void Insert(T entity);
        void Delete(T entity);
        Task<ICollection<T>> Get();
        Task<T> Get(int id);
    }
}
