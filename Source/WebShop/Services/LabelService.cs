using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShop.Models.Language;
using WebShop.Repositories.Interfaces;
using WebShop.Services.Interfaces;

namespace WebShop.Services
{
    public class LabelService : ILabelService
    {
        private readonly ILabelRepository _labelRepository;

        public LabelService( ILabelRepository labelRepository)
        {
            _labelRepository = labelRepository;
        }

        async Task<IEnumerable<Label>> ILabelService.Get()
        {
            var result = await _labelRepository.Get();
            return result;
        }
    }
}
