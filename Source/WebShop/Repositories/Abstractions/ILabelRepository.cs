using System.Collections.Generic;
using System.Threading.Tasks;
using WebShop.Models.Language;

namespace WebShop.Repositories.Abstractions
{
    public interface ILabelRepository
    {
        /// <summary>
        /// Use to get ALL labels
        /// </summary>
        /// <returns></returns>
        Task<ICollection<Label>> Get();

        /// <summary>
        /// Use to get a specific label
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<Label> Get(int id);
    }
}
