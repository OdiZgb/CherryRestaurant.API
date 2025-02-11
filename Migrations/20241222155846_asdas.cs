using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CherryRestaurant.API.Migrations
{
    /// <inheritdoc />
    public partial class asdas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ItemId",
                table: "HistoryOfCashBill",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);


        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "discount",
                table: "Bills");

            migrationBuilder.AlterColumn<string>(
                name: "ItemId",
                table: "HistoryOfCashBill",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);
        }
    }
}
