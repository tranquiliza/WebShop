using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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

        [HttpGet]
        [Route("")]
        public async Task<IEnumerable<LabelDto>> GetLabels()
        {
            var result = await _labelRepository.Get();

            var mapped = result.Select(x => x.Translate());

            return mapped;
        }

        [HttpGet]
        [Route("{isoCode}")]
        public async Task<IEnumerable<LabelDto>> GetLabels(string isoCode)
        {
            var result = await _labelRepository.Get(isoCode);

            var mapped = result.Select(x => x.Translate());

            return mapped;
        }
    }
}