using Microsoft.EntityFrameworkCore;
using WebShop.Context.Abstractions;
using WebShop.Models;
using WebShop.Models.Language;

namespace WebShop.Context
{
    public class WebShopContext : DbContext, IWebShopContext
    {
        public WebShopContext(DbContextOptions options) : base(options) { }

        DbSet<GiftcardProduct> IWebShopContext.GiftcardProducts { get; set; }

        DbSet<LabelValue> IWebShopContext.LabelValues { get; set; }

        DbSet<Language> IWebShopContext.Languages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Language>().HasData(new { Id = 1, LanguageName = "Danish", Iso = "da-DK" });

            modelBuilder.Entity<Language>().HasData(new { Id = 2, LanguageName = "UK-English", Iso = "en-GB" });

            modelBuilder.Entity<Label>().HasData(new { Id = 1, Alias = "LBL_TEST_LABEL" });

            modelBuilder.Entity<LabelValue>().HasData(new { Id = 1, Value = "Dette er et test label!", LabelId = 1, LanguageId = 1 });

            modelBuilder.Entity<LabelValue>().HasData(new { Id = 2, Value = "This is a test label!", LabelId = 1, LanguageId = 2 });

            base.OnModelCreating(modelBuilder);
        }
    }
}
