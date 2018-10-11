using System.Collections.Generic;
using System.Threading.Tasks;
using WebShop.Models.Languages;

namespace WebShop.Repositories.Interfaces
{
    public interface ILabelRepository
    {
        Task<ICollection<Label>> Get();

        Task<Label> Get(int id);
    }
}
