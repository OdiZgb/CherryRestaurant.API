using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CherryRestaurant.API.Migrations
{
    /// <inheritdoc />
    public partial class addedPaylaters : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PayLaters_Employees_EmployeeId",
                table: "PayLaters");

            migrationBuilder.DropIndex(
                name: "IX_PayLaters_EmployeeId",
                table: "PayLaters");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_PayLaters_EmployeeId",
                table: "PayLaters",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_PayLaters_Employees_EmployeeId",
                table: "PayLaters",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
