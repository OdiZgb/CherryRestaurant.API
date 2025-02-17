using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CherryRestaurant.API.Migrations
{
    /// <inheritdoc />
    public partial class addedEmployeePayLater : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PayLaters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EmployeeId = table.Column<int>(type: "INTEGER", nullable: false),
                    note = table.Column<string>(type: "TEXT", nullable: false),
                    value = table.Column<double>(type: "REAL", nullable: false),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PayLaters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PayLaters_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PayLaters_EmployeeId",
                table: "PayLaters",
                column: "EmployeeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PayLaters");
        }
    }
}
