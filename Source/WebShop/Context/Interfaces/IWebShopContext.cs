using Microsoft.EntityFrameworkCore;
using WebShop.Models.Baskets;
using WebShop.Models.Customers;
using WebShop.Models.Languages;
using WebShop.Models.Orders;
using WebShop.Models.Organisations;
using WebShop.Models.Products;
using WebShop.Models.Users;

namespace WebShop.Context.Interfaces
{
    public interface IWebShopContext
    {
        DbSet<GiftcardProduct> GiftcardProducts { get; set; }

        DbSet<LabelValue> LabelValues { get; set; }

        DbSet<Label> LabelsAlias { get; set; }

        DbSet<Language> Languages { get; set; }

        DbSet<Basket> Baskets { get; set; }

        DbSet<Customer> Customers { get; set; }

        DbSet<Order> Orders { get; set; }

        DbSet<Organisation> Organisations { get; set; }

        DbSet<Product> Products { get; set; }

        DbSet<User> Users { get; set; }
    }
}
