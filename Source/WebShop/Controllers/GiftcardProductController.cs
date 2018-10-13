using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using WebShop.Contracts.GiftcardProduct;
using WebShop.Services.Interfaces;
using WebShop.Translaters;

namespace WebShop.Controllers
{
    [Produces("application/json")]
    [Route("api/GiftcardProduct")]
    public class GiftcardProductController : ControllerBase
    {
        private readonly IGiftcardProductService _giftcardProductService;

        public GiftcardProductController(IGiftcardProductService giftcardProductService)
        {
            _giftcardProductService = giftcardProductService ?? throw new ArgumentNullException(nameof(giftcardProductService));
        }

        [HttpGet]
        public IEnumerable<GiftcardProductDto> Get()
        {
            var result = _giftcardProductService.Get();

            return result.Map();
        }

        [HttpGet("{Id}")]
        public GiftcardProductDto Get(int id)
        {
            var result = _giftcardProductService.Get(id);

            return result.Map();
        }

        [HttpPost("CreateGiftcard")]
        public void CreateGiftcard([FromBody] CreateGiftcardProductDto createGiftCardDto)
        {
            _giftcardProductService.CreateGiftcard(createGiftCardDto.Name, createGiftCardDto.Price);
        }
    }
}