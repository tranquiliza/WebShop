using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShop.Models.Language;

namespace WebShop.Repositories.Abstractions
{
    public interface ILabelRepository : IBaseRepository<LabelValue>
    {
        Task<IEnumerable<LabelValue>> Get(string isoCode);
    }
}
