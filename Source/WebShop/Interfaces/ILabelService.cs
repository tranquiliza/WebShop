using System.Collections.Generic;
using System.Threading.Tasks;
using WebShop.Models.Language;

namespace WebShop.Services.Abstractions
{
    public interface ILabelService
    {
        Task<IEnumerable<Label>> Get();
    }
}
