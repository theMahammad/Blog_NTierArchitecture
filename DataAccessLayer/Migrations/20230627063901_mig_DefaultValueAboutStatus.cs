using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig_DefaultValueAboutStatus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "True",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "True");
        }
    }
}
