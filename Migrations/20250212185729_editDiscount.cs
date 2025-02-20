﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CherryRestaurant.API.Migrations
{
    /// <inheritdoc />
    public partial class editDiscount : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    ImageURL = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    MobileNumber = table.Column<string>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ExpenseCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExpenseCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HistoryOfCashBill",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ItemName = table.Column<string>(type: "TEXT", nullable: true),
                    ItemId = table.Column<int>(type: "INTEGER", nullable: true),
                    ItemBarcode = table.Column<string>(type: "TEXT", nullable: true),
                    ItemCostIn = table.Column<double>(type: "REAL", nullable: true),
                    ItemCostOut = table.Column<double>(type: "REAL", nullable: true),
                    EmployeeName = table.Column<string>(type: "TEXT", nullable: true),
                    EmployeeId = table.Column<int>(type: "INTEGER", nullable: true),
                    ClientName = table.Column<string>(type: "TEXT", nullable: true),
                    ClientId = table.Column<int>(type: "INTEGER", nullable: true),
                    InventoryName = table.Column<int>(type: "INTEGER", nullable: true),
                    InventoryId = table.Column<int>(type: "INTEGER", nullable: true),
                    barcode = table.Column<string>(type: "TEXT", nullable: true),
                    billId = table.Column<int>(type: "INTEGER", nullable: true),
                    TraderName = table.Column<string>(type: "TEXT", nullable: true),
                    TraderId = table.Column<int>(type: "INTEGER", nullable: true),
                    RequierdPrice = table.Column<double>(type: "REAL", nullable: true),
                    ClientCashPayed = table.Column<double>(type: "REAL", nullable: true),
                    ClientRecived = table.Column<double>(type: "REAL", nullable: true),
                    SoftDeleted = table.Column<int>(type: "INTEGER", nullable: true),
                    IsRefund = table.Column<int>(type: "INTEGER", nullable: true),
                    dateTime = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoryOfCashBill", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Marka",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    ImageURL = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marka", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ParentChildItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ParentItemId = table.Column<int>(type: "INTEGER", nullable: false),
                    ChildeItemId = table.Column<int>(type: "INTEGER", nullable: false),
                    NumberOfChildren = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParentChildItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PriceIn",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ItemId = table.Column<int>(type: "INTEGER", nullable: false),
                    Price = table.Column<float>(type: "REAL", nullable: false),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ExpirationDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PriceIn", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PriceOut",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ItemId = table.Column<int>(type: "INTEGER", nullable: false),
                    Price = table.Column<float>(type: "REAL", nullable: false),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ExpirationDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PriceOut", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Salarys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EmployeeId = table.Column<int>(type: "INTEGER", nullable: false),
                    value = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salarys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ShipmentImage",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    barcode = table.Column<string>(type: "TEXT", nullable: true),
                    InventoryId = table.Column<int>(type: "INTEGER", nullable: false),
                    ImageURL = table.Column<string>(type: "TEXT", nullable: true),
                    AlterText = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShipmentImage", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TagItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TagId = table.Column<int>(type: "INTEGER", nullable: false),
                    ItemId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TagItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Traders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    MobileNumber = table.Column<string>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Traders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Password = table.Column<string>(type: "TEXT", nullable: false),
                    SecurityLevel = table.Column<int>(type: "INTEGER", nullable: false),
                    UserType = table.Column<int>(type: "INTEGER", nullable: false),
                    IsTrader = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsEmployee = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsClient = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CategoryProperty",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CategoryId = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryProperty", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CategoryProperty_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ClientDebts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BillId = table.Column<int>(type: "INTEGER", nullable: true),
                    ClientId = table.Column<int>(type: "INTEGER", nullable: false),
                    EmployeeId = table.Column<int>(type: "INTEGER", nullable: false),
                    DebtValue = table.Column<double>(type: "REAL", nullable: false),
                    DebtPayed = table.Column<double>(type: "REAL", nullable: false),
                    DebtFree = table.Column<bool>(type: "INTEGER", nullable: false),
                    DebtDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DebtFreeDate = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientDebts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClientDebts_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClientDebts_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExpenseItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Cost = table.Column<double>(type: "REAL", nullable: false),
                    ExpenseCategoryId = table.Column<int>(type: "INTEGER", nullable: false),
                    EmployeeId = table.Column<int>(type: "INTEGER", nullable: false),
                    dateTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Notes = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExpenseItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExpenseItems_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExpenseItems_ExpenseCategories_ExpenseCategoryId",
                        column: x => x.ExpenseCategoryId,
                        principalTable: "ExpenseCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ClientId = table.Column<int>(type: "INTEGER", nullable: true),
                    EmployeeId = table.Column<int>(type: "INTEGER", nullable: true),
                    ClientDebtId = table.Column<int>(type: "INTEGER", nullable: true),
                    RequierdPrice = table.Column<double>(type: "REAL", nullable: false),
                    PaiedPrice = table.Column<double>(type: "REAL", nullable: false),
                    ExchangeRepaied = table.Column<double>(type: "REAL", nullable: false),
                    Discount = table.Column<double>(type: "REAL", nullable: false),
                    Time = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ClientDebtId1 = table.Column<int>(type: "INTEGER", nullable: true),
                    IsRefund = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bills_ClientDebts_ClientDebtId1",
                        column: x => x.ClientDebtId1,
                        principalTable: "ClientDebts",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Barcode = table.Column<string>(type: "TEXT", nullable: true),
                    PriceInId = table.Column<int>(type: "INTEGER", nullable: false),
                    PriceOutId = table.Column<int>(type: "INTEGER", nullable: false),
                    CategoryId = table.Column<int>(type: "INTEGER", nullable: false),
                    MarkaId = table.Column<int>(type: "INTEGER", nullable: false),
                    PriceInId1 = table.Column<int>(type: "INTEGER", nullable: true),
                    PriceOutId1 = table.Column<int>(type: "INTEGER", nullable: true),
                    BillId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Items_Bills_BillId",
                        column: x => x.BillId,
                        principalTable: "Bills",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Items_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Items_Marka_MarkaId",
                        column: x => x.MarkaId,
                        principalTable: "Marka",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Items_PriceIn_PriceInId1",
                        column: x => x.PriceInId1,
                        principalTable: "PriceIn",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Items_PriceOut_PriceOutId1",
                        column: x => x.PriceOutId1,
                        principalTable: "PriceOut",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Inventory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ItemId = table.Column<int>(type: "INTEGER", nullable: false),
                    NumberOfUnits = table.Column<int>(type: "INTEGER", nullable: true),
                    PatchId = table.Column<int>(type: "INTEGER", nullable: true),
                    Barcode = table.Column<string>(type: "TEXT", nullable: true),
                    PriceInId = table.Column<int>(type: "INTEGER", nullable: true),
                    TraderId = table.Column<int>(type: "INTEGER", nullable: true),
                    EmployeeId = table.Column<int>(type: "INTEGER", nullable: true),
                    ArrivalDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ManufacturingDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ExpirationDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Inventory_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Inventory_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Inventory_PriceIn_PriceInId",
                        column: x => x.PriceInId,
                        principalTable: "PriceIn",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Inventory_Traders_TraderId",
                        column: x => x.TraderId,
                        principalTable: "Traders",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ItemsImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ItemId = table.Column<int>(type: "INTEGER", nullable: false),
                    ImageURL = table.Column<string>(type: "TEXT", nullable: true),
                    AlterText = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemsImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemsImages_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bills_ClientDebtId1",
                table: "Bills",
                column: "ClientDebtId1");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryProperty_CategoryId",
                table: "CategoryProperty",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ClientDebts_ClientId",
                table: "ClientDebts",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_ClientDebts_EmployeeId",
                table: "ClientDebts",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_UserId",
                table: "Employees",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ExpenseItems_EmployeeId",
                table: "ExpenseItems",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_ExpenseItems_ExpenseCategoryId",
                table: "ExpenseItems",
                column: "ExpenseCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Inventory_EmployeeId",
                table: "Inventory",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Inventory_ItemId",
                table: "Inventory",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Inventory_PriceInId",
                table: "Inventory",
                column: "PriceInId");

            migrationBuilder.CreateIndex(
                name: "IX_Inventory_TraderId",
                table: "Inventory",
                column: "TraderId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_BillId",
                table: "Items",
                column: "BillId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_CategoryId",
                table: "Items",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_MarkaId",
                table: "Items",
                column: "MarkaId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_PriceInId1",
                table: "Items",
                column: "PriceInId1");

            migrationBuilder.CreateIndex(
                name: "IX_Items_PriceOutId1",
                table: "Items",
                column: "PriceOutId1");

            migrationBuilder.CreateIndex(
                name: "IX_ItemsImages_ItemId",
                table: "ItemsImages",
                column: "ItemId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryProperty");

            migrationBuilder.DropTable(
                name: "ExpenseItems");

            migrationBuilder.DropTable(
                name: "HistoryOfCashBill");

            migrationBuilder.DropTable(
                name: "Inventory");

            migrationBuilder.DropTable(
                name: "ItemsImages");

            migrationBuilder.DropTable(
                name: "ParentChildItems");

            migrationBuilder.DropTable(
                name: "Salarys");

            migrationBuilder.DropTable(
                name: "ShipmentImage");

            migrationBuilder.DropTable(
                name: "TagItems");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropTable(
                name: "ExpenseCategories");

            migrationBuilder.DropTable(
                name: "Traders");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Bills");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Marka");

            migrationBuilder.DropTable(
                name: "PriceIn");

            migrationBuilder.DropTable(
                name: "PriceOut");

            migrationBuilder.DropTable(
                name: "ClientDebts");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
