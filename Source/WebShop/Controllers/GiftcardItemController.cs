using WebShop.Contracts.GiftcardItem;
using WebShop.Repositories.Abstractions;
using WebShop.Services.Abstractions;
using WebShop.Translaters;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace WebShop.Controllers
{
    [Produces("application/json")]
    [Route("api/GiftcardItem")]
    public class GiftcardItemController : Controller
    {
        private readonly IGiftcardProductService _giftcardItemService;

        public GiftcardItemController(IGiftcardProductService giftcardItemService)
        {
            _giftcardItemService = giftcardItemService ?? throw new ArgumentNullException(nameof(giftcardItemService));
        }

        [HttpGet]
        public IEnumerable<GiftcardItemDto> Get()
        {
            var result = _giftcardItemService.Get();

            return result.Map();
        }

        [HttpGet("{Id}")]
        public GiftcardItemDto Get(int id)
        {
            var result = _giftcardItemService.Get(id);

            return result.Map();
        }

        [HttpPost("CreateGiftcard")]
        public void CreateGiftcard([FromBody] CreateGiftCardDto createGiftCardDto)
        {
            _giftcardItemService.CreateGiftcard(createGiftCardDto.Name, createGiftCardDto.Price);
        }
    }
}