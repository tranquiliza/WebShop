using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Giftcard.Contracts;
using Giftcard.Repositories.Abstractions;
using Giftcard.Translaters;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Giftcard.Controllers
{
    [Produces("application/json")]
    [Route("api/GiftcardItem")]
    public class GiftcardItemController : Controller
    {
        private readonly IGiftcardItemRepository _giftcardItemRepository;

        public GiftcardItemController(IGiftcardItemRepository giftcardItemRepository)
        {
            _giftcardItemRepository = giftcardItemRepository ?? throw new ArgumentNullException(nameof(giftcardItemRepository));
        }

        [HttpGet]
        public IEnumerable<GiftcardItemDto> Get()
        {
            var result = _giftcardItemRepository.Get();

            return result.Map();
        }

        [HttpGet("{Id}")]
        public GiftcardItemDto Get(int id)
        {
            var result = _giftcardItemRepository.Get(id);

            return result.Map();
        }
    }
}