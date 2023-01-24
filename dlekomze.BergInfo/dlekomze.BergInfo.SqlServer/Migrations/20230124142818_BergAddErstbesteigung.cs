using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dlekomze.BergInfo.SqlServer.Migrations
{
    /// <inheritdoc />
    public partial class BergAddErstbesteigung : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Ersbesteigung",
                schema: "BergInfo",
                table: "Berg",
                type: "date",
                nullable: true);

            migrationBuilder.UpdateData(
                schema: "BergInfo",
                table: "Berg",
                keyColumn: "ID",
                keyValue: 1,
                column: "Ersbesteigung",
                value: null);

            migrationBuilder.UpdateData(
                schema: "BergInfo",
                table: "Berg",
                keyColumn: "ID",
                keyValue: 2,
                column: "Ersbesteigung",
                value: null);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ersbesteigung",
                schema: "BergInfo",
                table: "Berg");
        }
    }
}
