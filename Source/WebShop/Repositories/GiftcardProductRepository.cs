﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebShop.Models.Products;
using WebShop.Repositories.Interfaces;

namespace WebShop.Repositories
{
    public class GiftcardProductRepository : IGiftcardProductRepository
    {
        void IBaseRepository<GiftcardProduct>.Delete(GiftcardProduct entity)
        {
            throw new NotImplementedException();
        }

        async Task<ICollection<GiftcardProduct>> IBaseRepository<GiftcardProduct>.Get()
        {
            var collection = new List<GiftcardProduct>();
            for (int i = 0; i < 10; i++)
            {
                collection.Add(new GiftcardProduct($"SomeName {1}", (10 * i) + 20));
            }
            return collection;
        }

        async Task<GiftcardProduct> IBaseRepository<GiftcardProduct>.Get(int id)
        {
            var item = new GiftcardProduct("Something", 10);
            return item;
        }

        void IBaseRepository<GiftcardProduct>.Insert(GiftcardProduct entity)
        {
            throw new NotImplementedException();
        }

        void IBaseRepository<GiftcardProduct>.Update(GiftcardProduct entity)
        {
            throw new NotImplementedException();
        }
    }
}
