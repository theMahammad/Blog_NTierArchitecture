using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class AddingClickAmountOfArticle : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "ClickAmount",
                table: "Articles",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);
            migrationBuilder.Sql(@"create trigger CreateSlug 
                                 on ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClickAmount",
                table: "Articles");
        }
    }
}
