using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebShop.Context.Abstractions;
using WebShop.Models.Language;
using WebShop.Repositories.Abstractions;

namespace WebShop.Repositories
{
    public class LabelRepository : ILabelRepository
    {
        private readonly DbSet<Label> _labelAlias;

        public LabelRepository(IWebShopContext webShopContext)
        {
            if (webShopContext == null) throw new ArgumentNullException(nameof(webShopContext));

            _labelAlias = webShopContext.LabelsAlias;
        }

        async Task<ICollection<Label>> ILabelRepository.Get()
        {
            var result = await _labelAlias
                .Include(labels => labels.LabelValues)
                .ThenInclude(language => language.Language)
                .ToListAsync();

            return result;
        }

        async Task<Label> ILabelRepository.Get(int id)
        {
            var result = await _labelAlias
                .Include(label => label.LabelValues)
                .ThenInclude(values => values.Language)
                .SingleAsync(x => x.Id == id);

            return result;
        }
    }
}
