using Microsoft.EntityFrameworkCore.Migrations;

namespace DictionaryWebApp.Migrations
{
    public partial class Migration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LanguageID",
                table: "Word",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Language",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LanguageName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Language", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Word_LanguageID",
                table: "Word",
                column: "LanguageID");

            migrationBuilder.AddForeignKey(
                name: "FK_Word_Language_LanguageID",
                table: "Word",
                column: "LanguageID",
                principalTable: "Language",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Word_Language_LanguageID",
                table: "Word");

            migrationBuilder.DropTable(
                name: "Language");

            migrationBuilder.DropIndex(
                name: "IX_Word_LanguageID",
                table: "Word");

            migrationBuilder.DropColumn(
                name: "LanguageID",
                table: "Word");
        }
    }
}
