﻿// <auto-generated />
using System;
using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CherryRestaurant.API.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.10");

            modelBuilder.Entity("Bill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ClientDebtId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ClientDebtId1")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ClientId")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Discount")
                        .HasColumnType("REAL");

                    b.Property<int?>("EmployeeId")
                        .HasColumnType("INTEGER");

                    b.Property<double>("ExchangeRepaied")
                        .HasColumnType("REAL");

                    b.Property<int?>("IsRefund")
                        .HasColumnType("INTEGER");

                    b.Property<double>("PaiedPrice")
                        .HasColumnType("REAL");

                    b.Property<double>("RequierdPrice")
                        .HasColumnType("REAL");

                    b.Property<DateTime>("Time")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ClientDebtId1");

                    b.ToTable("Bills");
                });

            modelBuilder.Entity("Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageURL")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("CategoryProperty", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("CategoryProperty");
                });

            modelBuilder.Entity("Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("MobileNumber")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("ClientDebt", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("BillId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ClientId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DebtDate")
                        .HasColumnType("TEXT");

                    b.Property<bool>("DebtFree")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("DebtFreeDate")
                        .HasColumnType("TEXT");

                    b.Property<double>("DebtPayed")
                        .HasColumnType("REAL");

                    b.Property<double>("DebtValue")
                        .HasColumnType("REAL");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("ClientDebts");
                });

            modelBuilder.Entity("Data.EmployeeAttendance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CheckInTime")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("CheckOutTime")
                        .HasColumnType("TEXT");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("EmployeeAttendances");
                });

            modelBuilder.Entity("Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("ExpenseCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("ExpenseCategories");
                });

            modelBuilder.Entity("ExpenseItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("Cost")
                        .HasColumnType("REAL");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ExpenseCategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("dateTime")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("ExpenseCategoryId");

                    b.ToTable("ExpenseItems");
                });

            modelBuilder.Entity("HistoryOfCashBill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double?>("ClientCashPayed")
                        .HasColumnType("REAL");

                    b.Property<int?>("ClientId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClientName")
                        .HasColumnType("TEXT");

                    b.Property<double?>("ClientRecived")
                        .HasColumnType("REAL");

                    b.Property<int?>("EmployeeId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("EmployeeName")
                        .HasColumnType("TEXT");

                    b.Property<int?>("InventoryId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("InventoryName")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("IsRefund")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ItemBarcode")
                        .HasColumnType("TEXT");

                    b.Property<double?>("ItemCostIn")
                        .HasColumnType("REAL");

                    b.Property<double?>("ItemCostOut")
                        .HasColumnType("REAL");

                    b.Property<int?>("ItemId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ItemName")
                        .HasColumnType("TEXT");

                    b.Property<double?>("RequierdPrice")
                        .HasColumnType("REAL");

                    b.Property<int?>("SoftDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("TraderId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TraderName")
                        .HasColumnType("TEXT");

                    b.Property<string>("barcode")
                        .HasColumnType("TEXT");

                    b.Property<int?>("billId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("dateTime")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("HistoryOfCashBill");
                });

            modelBuilder.Entity("Inventory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("ArrivalDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Barcode")
                        .HasColumnType("TEXT");

                    b.Property<int?>("EmployeeId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("ExpirationDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("ItemId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("ManufacturingDate")
                        .HasColumnType("TEXT");

                    b.Property<int?>("NumberOfUnits")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("PatchId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("PriceInId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("TraderId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("ItemId");

                    b.HasIndex("PriceInId");

                    b.HasIndex("TraderId");

                    b.ToTable("Inventory");
                });

            modelBuilder.Entity("Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Barcode")
                        .HasColumnType("TEXT");

                    b.Property<int?>("BillId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MarkaId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("PriceInId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("PriceInId1")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PriceOutId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("PriceOutId1")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("BillId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("MarkaId");

                    b.HasIndex("PriceInId1");

                    b.HasIndex("PriceOutId1");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("ItemImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AlterText")
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageURL")
                        .HasColumnType("TEXT");

                    b.Property<int>("ItemId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ItemId");

                    b.ToTable("ItemsImages");
                });

            modelBuilder.Entity("Marka", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageURL")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Marka");
                });

            modelBuilder.Entity("ParentChildItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ChildeItemId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("NumberOfChildren")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ParentItemId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("ParentChildItems");
                });

            modelBuilder.Entity("PayLater", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("note")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("value")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("PayLaters");
                });

            modelBuilder.Entity("PriceIn", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ExpirationDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("ItemId")
                        .HasColumnType("INTEGER");

                    b.Property<float>("Price")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("PriceIn");
                });

            modelBuilder.Entity("PriceOut", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ExpirationDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("ItemId")
                        .HasColumnType("INTEGER");

                    b.Property<float>("Price")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("PriceOut");
                });

            modelBuilder.Entity("Salary", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("INTEGER");

                    b.Property<double>("value")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("Salarys");
                });

            modelBuilder.Entity("ShipmentImage", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AlterText")
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageURL")
                        .HasColumnType("TEXT");

                    b.Property<int>("InventoryId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("barcode")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("ShipmentImage");
                });

            modelBuilder.Entity("Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("TagItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ItemId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TagId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("TagItems");
                });

            modelBuilder.Entity("Trader", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("MobileNumber")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Traders");
                });

            modelBuilder.Entity("User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsClient")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsEmployee")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsTrader")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("SecurityLevel")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UserType")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Bill", b =>
                {
                    b.HasOne("ClientDebt", "ClientDebt")
                        .WithMany()
                        .HasForeignKey("ClientDebtId1");

                    b.Navigation("ClientDebt");
                });

            modelBuilder.Entity("CategoryProperty", b =>
                {
                    b.HasOne("Category", "Category")
                        .WithMany("CategoryProperties")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("ClientDebt", b =>
                {
                    b.HasOne("Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("Data.EmployeeAttendance", b =>
                {
                    b.HasOne("Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("Employee", b =>
                {
                    b.HasOne("User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ExpenseItem", b =>
                {
                    b.HasOne("Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ExpenseCategory", "ExpenseCategory")
                        .WithMany("expenseItems")
                        .HasForeignKey("ExpenseCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("ExpenseCategory");
                });

            modelBuilder.Entity("Inventory", b =>
                {
                    b.HasOne("Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId");

                    b.HasOne("Item", "Item")
                        .WithMany()
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PriceIn", "PriceIn")
                        .WithMany()
                        .HasForeignKey("PriceInId");

                    b.HasOne("Trader", "Trader")
                        .WithMany("Inventories")
                        .HasForeignKey("TraderId");

                    b.Navigation("Employee");

                    b.Navigation("Item");

                    b.Navigation("PriceIn");

                    b.Navigation("Trader");
                });

            modelBuilder.Entity("Item", b =>
                {
                    b.HasOne("Bill", null)
                        .WithMany("Items")
                        .HasForeignKey("BillId");

                    b.HasOne("Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Marka", "Marka")
                        .WithMany()
                        .HasForeignKey("MarkaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PriceIn", "PriceIn")
                        .WithMany()
                        .HasForeignKey("PriceInId1");

                    b.HasOne("PriceOut", "PriceOut")
                        .WithMany()
                        .HasForeignKey("PriceOutId1");

                    b.Navigation("Category");

                    b.Navigation("Marka");

                    b.Navigation("PriceIn");

                    b.Navigation("PriceOut");
                });

            modelBuilder.Entity("ItemImage", b =>
                {
                    b.HasOne("Item", null)
                        .WithMany("itemImages")
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Bill", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("Category", b =>
                {
                    b.Navigation("CategoryProperties");
                });

            modelBuilder.Entity("ExpenseCategory", b =>
                {
                    b.Navigation("expenseItems");
                });

            modelBuilder.Entity("Item", b =>
                {
                    b.Navigation("itemImages");
                });

            modelBuilder.Entity("Trader", b =>
                {
                    b.Navigation("Inventories");
                });
#pragma warning restore 612, 618
        }
    }
}
