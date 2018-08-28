using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShop.Context.Abstractions;
using WebShop.Models.Language;
using WebShop.Repositories.Abstractions;

namespace WebShop.Repositories
{
    public class LabelRepository : ILabelRepository
    {
        private readonly DbSet<LabelValue> _labelValues;

        public LabelRepository(IWebShopContext webShopContext)
        {
            _labelValues = webShopContext.LabelValues ?? throw new ArgumentNullException(nameof(webShopContext));
        }

        void IBaseRepository<LabelValue>.Delete(LabelValue entity)
        {
            throw new NotImplementedException();
        }

        async Task<ICollection<LabelValue>> IBaseRepository<LabelValue>.Get()
        {
            var result = await _labelValues
                .Include(x => x.Label)
                .Include(x => x.Language)
                .ToListAsync();

            return result;
        }

        async Task<LabelValue> IBaseRepository<LabelValue>.Get(int id)
        {
            var result = await _labelValues
                .FirstAsync(x => x.Id == id);

            return result;
        }

        async Task<IEnumerable<LabelValue>> ILabelRepository.Get(string isoCode)
        {
            var result = await _labelValues
                .Include(x => x.Label)
                .Include(x => x.Language)
                .Where(x => x.Language.Iso == isoCode)
                .ToListAsync();

            return result;
        }

        void IBaseRepository<LabelValue>.Insert(LabelValue entity)
        {
            throw new NotImplementedException();
        }

        void IBaseRepository<LabelValue>.Update(LabelValue entity)
        {
            throw new NotImplementedException();
        }
    }
}
