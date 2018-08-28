using Microsoft.EntityFrameworkCore.Migrations;

namespace WebShop.Migrations
{
    public partial class Initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LabelId",
                table: "WebShop.Context.Abstractions.IWebShopContext.LabelValues",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LanguageId",
                table: "WebShop.Context.Abstractions.IWebShopContext.LabelValues",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "WebShop.Context.Abstractions.IWebShopContext.LabelValues",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "LabelId", "LanguageId" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "WebShop.Context.Abstractions.IWebShopContext.LabelValues",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "LabelId", "LanguageId" },
                values: new object[] { 1, 2 });

            migrationBuilder.CreateIndex(
                name: "IX_WebShop.Context.Abstractions.IWebShopContext.LabelValues_LabelId",
                table: "WebShop.Context.Abstractions.IWebShopContext.LabelValues",
                column: "LabelId");

            migrationBuilder.CreateIndex(
                name: "IX_WebShop.Context.Abstractions.IWebShopContext.LabelValues_LanguageId",
                table: "WebShop.Context.Abstractions.IWebShopContext.LabelValues",
                column: "LanguageId");

            migrationBuilder.AddForeignKey(
                name: "FK_WebShop.Context.Abstractions.IWebShopContext.LabelValues_Label_LabelId",
                table: "WebShop.Context.Abstractions.IWebShopContext.LabelValues",
                column: "LabelId",
                principalTable: "Label",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WebShop.Context.Abstractions.IWebShopContext.LabelValues_WebShop.Context.Abstractions.IWebShopContext.Languages_LanguageId",
                table: "WebShop.Context.Abstractions.IWebShopContext.LabelValues",
                column: "LanguageId",
                principalTable: "WebShop.Context.Abstractions.IWebShopContext.Languages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WebShop.Context.Abstractions.IWebShopContext.LabelValues_Label_LabelId",
                table: "WebShop.Context.Abstractions.IWebShopContext.LabelValues");

            migrationBuilder.DropForeignKey(
                name: "FK_WebShop.Context.Abstractions.IWebShopContext.LabelValues_WebShop.Context.Abstractions.IWebShopContext.Languages_LanguageId",
                table: "WebShop.Context.Abstractions.IWebShopContext.LabelValues");

            migrationBuilder.DropIndex(
                name: "IX_WebShop.Context.Abstractions.IWebShopContext.LabelValues_LabelId",
                table: "WebShop.Context.Abstractions.IWebShopContext.LabelValues");

            migrationBuilder.DropIndex(
                name: "IX_WebShop.Context.Abstractions.IWebShopContext.LabelValues_LanguageId",
                table: "WebShop.Context.Abstractions.IWebShopContext.LabelValues");

            migrationBuilder.DropColumn(
                name: "LabelId",
                table: "WebShop.Context.Abstractions.IWebShopContext.LabelValues");

            migrationBuilder.DropColumn(
                name: "LanguageId",
                table: "WebShop.Context.Abstractions.IWebShopContext.LabelValues");
        }
    }
}
