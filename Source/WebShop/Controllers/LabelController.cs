using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShop.Contracts.Label;
using WebShop.Services.Abstractions;
using WebShop.Translaters;

namespace WebShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LabelController : ControllerBase
    {
        private readonly ILabelService _labelService;

        public LabelController(ILabelService labelService)
        {
            _labelService = labelService;
        }

        [HttpGet]
        public async Task<IEnumerable<LabelAliasDto>> GetLabels()
        {
            var result = await _labelService.Get();

            return result.Select(x => x.TranslateToLabelAliasDto());
        }

        [HttpGet]
        [Route("{isoCode}")]
        public async Task<IEnumerable<LanguageLabelDto>> GetLabels(string isoCode)
        {
            var result = await _labelService.Get();

            return result.Select(x => x.TranslateToLanguageLabelsFor(isoCode));
        }
    }
}