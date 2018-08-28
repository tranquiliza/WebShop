using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebShop.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Label",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Alias = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Label", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WebShop.Context.Abstractions.IWebShopContext.GiftcardProducts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Price = table.Column<int>(nullable: false),
                    IsPriceOverrideable = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WebShop.Context.Abstractions.IWebShopContext.GiftcardProducts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WebShop.Context.Abstractions.IWebShopContext.LabelValues",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WebShop.Context.Abstractions.IWebShopContext.LabelValues", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WebShop.Context.Abstractions.IWebShopContext.Languages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LanguageName = table.Column<string>(nullable: true),
                    Iso = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WebShop.Context.Abstractions.IWebShopContext.Languages", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Label",
                columns: new[] { "Id", "Alias" },
                values: new object[] { 1, "LBL_TEST_LABEL" });

            migrationBuilder.InsertData(
                table: "WebShop.Context.Abstractions.IWebShopContext.LabelValues",
                columns: new[] { "Id", "Value" },
                values: new object[,]
                {
                    { 1, "Dette er et test label!" },
                    { 2, "This is a test label!" }
                });

            migrationBuilder.InsertData(
                table: "WebShop.Context.Abstractions.IWebShopContext.Languages",
                columns: new[] { "Id", "Iso", "LanguageName" },
                values: new object[,]
                {
                    { 1, "da-DK", "Danish" },
                    { 2, "en-GB", "UK-English" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Label");

            migrationBuilder.DropTable(
                name: "WebShop.Context.Abstractions.IWebShopContext.GiftcardProducts");

            migrationBuilder.DropTable(
                name: "WebShop.Context.Abstractions.IWebShopContext.LabelValues");

            migrationBuilder.DropTable(
                name: "WebShop.Context.Abstractions.IWebShopContext.Languages");
        }
    }
}
