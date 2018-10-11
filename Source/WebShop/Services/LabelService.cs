using System.Collections.Generic;
using System.Threading.Tasks;
using WebShop.Models.Languages;
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
