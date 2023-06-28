using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig_ContactTableName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Username",
                table: "Contacts",
                newName: "Name");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Contacts",
                newName: "Username");
        }
    }
}
