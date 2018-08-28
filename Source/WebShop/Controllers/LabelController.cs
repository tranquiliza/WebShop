using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShop.Contracts.Label;
using WebShop.Repositories.Abstractions;
using WebShop.Translaters;

namespace WebShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LabelController : ControllerBase
    {
        private readonly ILabelRepository _labelRepository;

        public LabelController(ILabelRepository labelRepository)
        {
            _labelRepository = labelRepository;
        }

        /// <summary>
        /// Returns a list of all labels, without their value
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("")]
        public async Task<IEnumerable<LabelAliasDto>> GetLabels()
        {
            var result = await _labelRepository.Get();

            return result.Select(x => x.TranslateToLabelAliasDto());
        }

        /// <summary>
        /// Returns labels for the given language iso code
        /// </summary>
        /// <param name="isoCode"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("{isoCode}")]
        public async Task<IEnumerable<LanguageLabelDto>> GetLabels(string isoCode)
        {
            var result = await _labelRepository.Get();

            return result.Select(x => x.TranslateToLanguageLabelsFor(isoCode));
        }
    }
}