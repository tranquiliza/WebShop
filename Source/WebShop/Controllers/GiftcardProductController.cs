using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using WebShop.Contracts.GiftcardItem;
using WebShop.Services.Interfaces;
using WebShop.Translaters;

namespace WebShop.Controllers
{
    [Produces("application/json")]
    [Route("api/GiftcardItem")]
    public class GiftcardProductController : ControllerBase
    {
        private readonly IGiftcardProductService _giftcardItemService;

        public GiftcardProductController(IGiftcardProductService giftcardItemService)
        {
            _giftcardItemService = giftcardItemService ?? throw new ArgumentNullException(nameof(giftcardItemService));
        }

        [HttpGet]
        public IEnumerable<GiftcardProductDto> Get()
        {
            var result = _giftcardItemService.Get();

            return result.Map();
        }

        [HttpGet("{Id}")]
        public GiftcardProductDto Get(int id)
        {
            var result = _giftcardItemService.Get(id);

            return result.Map();
        }

        [HttpPost("CreateGiftcard")]
        public void CreateGiftcard([FromBody] CreateGiftcardProductDto createGiftCardDto)
        {
            _giftcardItemService.CreateGiftcard(createGiftCardDto.Name, createGiftCardDto.Price);
        }
    }
}