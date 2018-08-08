using Giftcard.Models;
using Giftcard.Repositories.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Giftcard.Repositories
{
    public class GiftcardItemRepository : IGiftcardItemRepository
    {
        void IBaseRepository<GiftcardItem>.Delete(GiftcardItem entity)
        {
            throw new NotImplementedException();
        }

        ICollection<GiftcardItem> IBaseRepository<GiftcardItem>.Get()
        {
            var collection = new List<GiftcardItem>();
            for (int i = 0; i < 10; i++)
            {
                collection.Add(new GiftcardItem($"SomeName {1}", (10 * i) + 20));
            }
            return collection;
        }

        GiftcardItem IBaseRepository<GiftcardItem>.Get(int id)
        {
            var item = new GiftcardItem("Something", 10);
            return item;
        }

        void IBaseRepository<GiftcardItem>.Insert(GiftcardItem entity)
        {
            throw new NotImplementedException();
        }

        void IBaseRepository<GiftcardItem>.Update(GiftcardItem entity)
        {
            throw new NotImplementedException();
        }
    }
}
