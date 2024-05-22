using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NewsSiteScraper.Data.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Headlines",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IMageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BlurbText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CommentCount = table.Column<int>(type: "int", nullable: false),
                    ArticleUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Headlines", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Headlines");
        }
    }
}
