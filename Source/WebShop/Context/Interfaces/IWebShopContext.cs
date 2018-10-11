using Microsoft.EntityFrameworkCore;
using WebShop.Models;
using WebShop.Models.Language;

namespace WebShop.Context.Interfaces
{
    public interface IWebShopContext
    {
        DbSet<GiftcardProduct> GiftcardProducts { get; set; }

        DbSet<LabelValue> LabelValues { get; set; }

        DbSet<Label> LabelsAlias { get; set; }

        DbSet<Language> Languages { get; set; }
    }
}
