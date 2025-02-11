using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CherryRestaurant.API.Migrations
{
    /// <inheritdoc />
    public partial class addedDateToCashBill : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "dateTime",
                table: "HistoryOfCashBill",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "dateTime",
                table: "HistoryOfCashBill");
        }
    }
}
