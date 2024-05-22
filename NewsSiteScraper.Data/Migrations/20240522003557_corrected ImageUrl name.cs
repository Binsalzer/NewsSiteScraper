using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NewsSiteScraper.Data.Migrations
{
    /// <inheritdoc />
    public partial class correctedImageUrlname : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IMageUrl",
                table: "Headlines",
                newName: "ImageUrl");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "Headlines",
                newName: "IMageUrl");
        }
    }
}
