using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebShop.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GiftcardProducts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Price = table.Column<int>(nullable: false),
                    IsPriceOverrideable = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GiftcardProducts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LabelsAlias",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Alias = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LabelsAlias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LanguageName = table.Column<string>(nullable: true),
                    IsoCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LabelValues",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Value = table.Column<string>(nullable: true),
                    LanguageId = table.Column<int>(nullable: true),
                    LabelId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LabelValues", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LabelValues_LabelsAlias_LabelId",
                        column: x => x.LabelId,
                        principalTable: "LabelsAlias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LabelValues_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "LabelsAlias",
                columns: new[] { "Id", "Alias" },
                values: new object[,]
                {
                    { 1, "LBL_TEST_LABEL" },
                    { 2, "LBL_TEST_NUMBER_TWO" }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "IsoCode", "LanguageName" },
                values: new object[,]
                {
                    { 1, "da-DK", "Danish" },
                    { 2, "en-GB", "UK-English" }
                });

            migrationBuilder.InsertData(
                table: "LabelValues",
                columns: new[] { "Id", "LabelId", "LanguageId", "Value" },
                values: new object[,]
                {
                    { 1, 1, 1, "Dette er et test label!" },
                    { 3, 2, 1, "Endnu et test label" },
                    { 2, 1, 2, "This is a test label!" },
                    { 4, 2, 2, "Yet another test label" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_LabelValues_LabelId",
                table: "LabelValues",
                column: "LabelId");

            migrationBuilder.CreateIndex(
                name: "IX_LabelValues_LanguageId",
                table: "LabelValues",
                column: "LanguageId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GiftcardProducts");

            migrationBuilder.DropTable(
                name: "LabelValues");

            migrationBuilder.DropTable(
                name: "LabelsAlias");

            migrationBuilder.DropTable(
                name: "Languages");
        }
    }
}
