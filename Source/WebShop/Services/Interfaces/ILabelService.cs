using System.Collections.Generic;
using System.Threading.Tasks;
using WebShop.Models.Languages;

namespace WebShop.Services.Interfaces
{
    public interface ILabelService
    {
        Task<IEnumerable<Label>> Get();
    }
}
