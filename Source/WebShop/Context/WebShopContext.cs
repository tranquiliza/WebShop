using Microsoft.EntityFrameworkCore;
using WebShop.Context.Interfaces;
using WebShop.Models;
using WebShop.Models.Language;

namespace WebShop.Context
{
    public class WebShopContext : DbContext, IWebShopContext
    {
        public WebShopContext(DbContextOptions options) : base(options) { }

        public DbSet<GiftcardProduct> GiftcardProducts { get; set; }

        public DbSet<LabelValue> LabelValues { get; set; }

        public DbSet<Label> LabelsAlias { get; set; }

        public DbSet<Language> Languages { get; set; }

        #region .SEEDING.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Language>().HasData(new { Id = 1, LanguageName = "Danish", IsoCode = "da-DK" });

            modelBuilder.Entity<Language>().HasData(new { Id = 2, LanguageName = "UK-English", IsoCode = "en-GB" });

            modelBuilder.Entity<Label>().HasData(new { Id = 1, Alias = "LBL_TEST_LABEL" });
            modelBuilder.Entity<Label>().HasData(new { Id = 2, Alias = "LBL_TEST_NUMBER_TWO" });

            modelBuilder.Entity<LabelValue>().HasData(new { Id = 1, Value = "Dette er et test label!", LabelId = 1, LanguageId = 1 });

            modelBuilder.Entity<LabelValue>().HasData(new { Id = 2, Value = "This is a test label!", LabelId = 1, LanguageId = 2 });

            modelBuilder.Entity<LabelValue>().HasData(new { Id = 3, Value = "Endnu et test label", LabelId = 2, LanguageId = 1 });
            modelBuilder.Entity<LabelValue>().HasData(new { Id = 4, Value = "Yet another test label", LabelId = 2, LanguageId = 2 });

            base.OnModelCreating(modelBuilder);
        }
        #endregion
    }
}
