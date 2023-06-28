using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig_ContactTablesDefaultValues : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsReaded",
                table: "Contacts",
                type: "bit",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Contacts",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "GETDATE()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsReaded",
                table: "Contacts",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Contacts",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValueSql: "GETDATE()");
        }
    }
}
