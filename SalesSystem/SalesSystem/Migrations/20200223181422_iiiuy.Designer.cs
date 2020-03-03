﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using SalesSystem.Models;
using System;

namespace SalesSystem.Migrations
{
    [DbContext(typeof(DbContextSales))]
    [Migration("20200223181422_iiiuy")]
    partial class iiiuy
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SalesSystem.Models.Accounts.AccountsGroupe", b =>
                {
                    b.Property<string>("Groupe_Name")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("EngName");

                    b.Property<int>("Groupe_Id");

                    b.Property<int>("State");

                    b.HasKey("Groupe_Name");

                    b.ToTable("accountsGroupes");
                });

            modelBuilder.Entity("SalesSystem.Models.Accounts.AccountsRanks", b =>
                {
                    b.Property<string>("Rank_Name")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("EngName");

                    b.Property<int>("Length");

                    b.Property<int>("Rank_Id");

                    b.HasKey("Rank_Name");

                    b.ToTable("AccountsRanks");
                });

            modelBuilder.Entity("SalesSystem.Models.Accounts.AccountsTypes", b =>
                {
                    b.Property<string>("Type_Name")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("EngName");

                    b.Property<int>("State");

                    b.Property<int>("Type_Id");

                    b.HasKey("Type_Name");

                    b.ToTable("AccountsTypes");
                });

            modelBuilder.Entity("SalesSystem.Models.Accounts.Banks", b =>
                {
                    b.Property<int>("Bnk_Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AccountsAccount_Id");

                    b.Property<string>("BakArabic_Name");

                    b.Property<string>("BakEnglish_Name");

                    b.Property<int>("Bak_MainAccountNB");

                    b.Property<string>("Bak_Netuarl");

                    b.Property<string>("Bak_State");

                    b.Property<string>("Bak_Type");

                    b.Property<string>("MoneysM_Name");

                    b.HasKey("Bnk_Id");

                    b.HasIndex("AccountsAccount_Id");

                    b.HasIndex("MoneysM_Name");

                    b.ToTable("Banks");
                });

            modelBuilder.Entity("SalesSystem.Models.Accounts.Boxs", b =>
                {
                    b.Property<int>("Box_Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BoxArabic_Name");

                    b.Property<string>("BoxEnglish_Name");

                    b.Property<int>("Box_MainAccountNB");

                    b.Property<string>("Box_Netuarl");

                    b.Property<string>("Box_State");

                    b.Property<string>("Box_Type");

                    b.Property<int?>("MainAccountsAccount_Id");

                    b.Property<string>("MoneysM_Name");

                    b.HasKey("Box_Id");

                    b.HasIndex("MainAccountsAccount_Id");

                    b.HasIndex("MoneysM_Name");

                    b.ToTable("Boxs");
                });

            modelBuilder.Entity("SalesSystem.Models.Accounts.CostCenters", b =>
                {
                    b.Property<string>("C_Name")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Center_Id");

                    b.Property<string>("Groupe");

                    b.Property<string>("Rank_Name");

                    b.Property<string>("Type");

                    b.HasKey("C_Name");

                    b.HasIndex("Rank_Name");

                    b.ToTable("CostCenters");
                });

            modelBuilder.Entity("SalesSystem.Models.Accounts.Customers", b =>
                {
                    b.Property<int>("Cust_Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Account_Id");

                    b.Property<string>("City");

                    b.Property<string>("Country");

                    b.Property<string>("Cust_Address");

                    b.Property<string>("Cust_DebtorsTime");

                    b.Property<double>("Cust_DebtorsTop");

                    b.Property<DateTime>("Cust_History");

                    b.Property<int>("Cust_MainAccountNB");

                    b.Property<string>("Cust_Name");

                    b.Property<string>("Cust_Netuarl");

                    b.Property<string>("Cust_Rank");

                    b.Property<string>("Cust_SaleMoney");

                    b.Property<string>("Cust_SalePrice");

                    b.Property<string>("Cust_State");

                    b.Property<string>("Cust_Type");

                    b.Property<double>("Cust_phone");

                    b.Property<int>("M_Name");

                    b.Property<string>("MoneysM_Name");

                    b.Property<int?>("SalesAreasA_Id");

                    b.Property<string>("SummationS_Name");

                    b.HasKey("Cust_Id");

                    b.HasIndex("Account_Id");

                    b.HasIndex("Cust_Type");

                    b.HasIndex("MoneysM_Name");

                    b.HasIndex("SalesAreasA_Id");

                    b.HasIndex("SummationS_Name");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("SalesSystem.Models.Accounts.Employees", b =>
                {
                    b.Property<int>("Emp_Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AccountsNBAccount_Id");

                    b.Property<int>("Emp_BankAccountNB");

                    b.Property<int>("Emp_Card");

                    b.Property<string>("Emp_Center");

                    b.Property<string>("Emp_City");

                    b.Property<string>("Emp_CostCenter");

                    b.Property<string>("Emp_Country");

                    b.Property<DateTime>("Emp_History");

                    b.Property<int>("Emp_InclusionCard");

                    b.Property<int>("Emp_InclusionNB");

                    b.Property<string>("Emp_InclusionName");

                    b.Property<string>("Emp_Job");

                    b.Property<int>("Emp_MainAccountNB");

                    b.Property<string>("Emp_Name");

                    b.Property<string>("Emp_Netural");

                    b.Property<int>("Emp_Phone");

                    b.Property<string>("Emp_PushingMethod");

                    b.Property<string>("Emp_Qualification");

                    b.Property<string>("Emp_Rank");

                    b.Property<double>("Emp_Salery");

                    b.Property<string>("Emp_State");

                    b.Property<DateTime>("Emp_WStateHis");

                    b.Property<string>("Emp_WorkArea");

                    b.Property<int>("Emp_WorkTime");

                    b.Property<string>("Emp_address");

                    b.Property<string>("MoneysM_Name");

                    b.Property<int?>("SalesAreasA_Id");

                    b.HasKey("Emp_Id");

                    b.HasIndex("AccountsNBAccount_Id");

                    b.HasIndex("MoneysM_Name");

                    b.HasIndex("SalesAreasA_Id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("SalesSystem.Models.Accounts.MainAccounts", b =>
                {
                    b.Property<int>("Account_Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Account_Confidentility");

                    b.Property<string>("Account_Main");

                    b.Property<string>("Account_Name");

                    b.Property<string>("Account_Netural");

                    b.Property<string>("Account_State");

                    b.Property<string>("C_Name");

                    b.Property<string>("Groupe_Name");

                    b.Property<string>("M_Name");

                    b.Property<double>("MainAccount_Id");

                    b.Property<string>("Rank_Name");

                    b.Property<string>("Type_Name");

                    b.HasKey("Account_Id");

                    b.HasIndex("C_Name");

                    b.HasIndex("Groupe_Name");

                    b.HasIndex("M_Name");

                    b.HasIndex("Rank_Name");

                    b.HasIndex("Type_Name");

                    b.ToTable("MainAccounts");
                });

            modelBuilder.Entity("SalesSystem.Models.Accounts.Moneys", b =>
                {
                    b.Property<string>("M_Name")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("M_Barket");

                    b.Property<string>("M_Country");

                    b.Property<DateTime>("M_History");

                    b.Property<double>("M_Pric");

                    b.Property<double>("M_PriceLess");

                    b.Property<double>("M_PriceTop");

                    b.Property<string>("M_State");

                    b.Property<string>("M_Symbole");

                    b.Property<string>("M_Type");

                    b.Property<int>("_Id");

                    b.HasKey("M_Name");

                    b.ToTable("Moneys");
                });

            modelBuilder.Entity("SalesSystem.Models.Accounts.Suppliers", b =>
                {
                    b.Property<int>("Sup_Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Account_Id");

                    b.Property<string>("Country");

                    b.Property<string>("Email");

                    b.Property<string>("M_Name");

                    b.Property<int?>("SalesAreasA_Id");

                    b.Property<string>("Summation");

                    b.Property<string>("SummationS_Name");

                    b.Property<string>("Sup_Address");

                    b.Property<string>("Sup_DebtorsTime");

                    b.Property<double>("Sup_DebtorsTop");

                    b.Property<DateTime>("Sup_History");

                    b.Property<int>("Sup_MainAccountNB");

                    b.Property<string>("Sup_Name");

                    b.Property<string>("Sup_Netuarl");

                    b.Property<string>("Sup_Rank");

                    b.Property<string>("Sup_SaleMoney");

                    b.Property<string>("Sup_SalePrice");

                    b.Property<string>("Sup_State");

                    b.Property<int>("Sup_Type");

                    b.Property<double>("Sup_phone");

                    b.Property<string>("SupllierTypeSup_Type");

                    b.HasKey("Sup_Id");

                    b.HasIndex("Account_Id");

                    b.HasIndex("M_Name");

                    b.HasIndex("SalesAreasA_Id");

                    b.HasIndex("SummationS_Name");

                    b.HasIndex("SupllierTypeSup_Type");

                    b.ToTable("Suppliers");
                });

            modelBuilder.Entity("SalesSystem.Models.BillsSetting.BillsVariables.CustomersType", b =>
                {
                    b.Property<string>("Cust_Type")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Aressting");

                    b.Property<int>("Aressting_Name");

                    b.Property<string>("CommunicationTop");

                    b.Property<string>("EngName");

                    b.Property<int>("Id");

                    b.Property<string>("State");

                    b.HasKey("Cust_Type");

                    b.ToTable("customersTypes");
                });

            modelBuilder.Entity("SalesSystem.Models.BillsSetting.BillsVariables.SupllierType", b =>
                {
                    b.Property<string>("Sup_Type")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Aressting");

                    b.Property<int>("Aressting_Name");

                    b.Property<string>("EngName");

                    b.Property<int>("Id");

                    b.Property<string>("State");

                    b.HasKey("Sup_Type");

                    b.ToTable("SupllierType");
                });

            modelBuilder.Entity("SalesSystem.Models.BillsSetting.Employee_Lower", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Communique");

                    b.Property<string>("Emp_Name");

                    b.Property<int?>("EmployeesEmp_Id");

                    b.Property<DateTime>("FromHistory");

                    b.Property<DateTime>("History");

                    b.Property<double>("LowerHigh");

                    b.Property<double>("LowerLess");

                    b.Property<string>("State");

                    b.Property<DateTime>("ToHistory");

                    b.HasKey("Id");

                    b.HasIndex("EmployeesEmp_Id");

                    b.ToTable("Employee_Lower");
                });

            modelBuilder.Entity("SalesSystem.Models.BillsSetting.SalesAreas", b =>
                {
                    b.Property<int>("A_Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("City");

                    b.Property<string>("Country");

                    b.Property<string>("History");

                    b.Property<string>("Location");

                    b.Property<string>("Name");

                    b.Property<string>("Phone");

                    b.Property<string>("State");

                    b.HasKey("A_Id");

                    b.ToTable("SalesAreas");
                });

            modelBuilder.Entity("SalesSystem.Models.BillsSetting.Summation", b =>
                {
                    b.Property<string>("S_Name")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Adddress");

                    b.Property<DateTime>("History");

                    b.Property<int?>("MainAccountsAccount_Id");

                    b.Property<int>("Phone");

                    b.Property<int>("S_Id");

                    b.Property<int?>("SalesAreasA_Id");

                    b.Property<string>("State");

                    b.Property<string>("Type");

                    b.HasKey("S_Name");

                    b.HasIndex("MainAccountsAccount_Id");

                    b.HasIndex("SalesAreasA_Id");

                    b.ToTable("Summations");
                });

            modelBuilder.Entity("SalesSystem.Models.Accounts.Banks", b =>
                {
                    b.HasOne("SalesSystem.Models.Accounts.MainAccounts", "Accounts")
                        .WithMany("Banks")
                        .HasForeignKey("AccountsAccount_Id");

                    b.HasOne("SalesSystem.Models.Accounts.Moneys", "Moneys")
                        .WithMany("Banks")
                        .HasForeignKey("MoneysM_Name");
                });

            modelBuilder.Entity("SalesSystem.Models.Accounts.Boxs", b =>
                {
                    b.HasOne("SalesSystem.Models.Accounts.MainAccounts", "MainAccounts")
                        .WithMany("Boxs")
                        .HasForeignKey("MainAccountsAccount_Id");

                    b.HasOne("SalesSystem.Models.Accounts.Moneys", "Moneys")
                        .WithMany("Boxs")
                        .HasForeignKey("MoneysM_Name");
                });

            modelBuilder.Entity("SalesSystem.Models.Accounts.CostCenters", b =>
                {
                    b.HasOne("SalesSystem.Models.Accounts.AccountsRanks", "AccountsRanks")
                        .WithMany()
                        .HasForeignKey("Rank_Name");
                });

            modelBuilder.Entity("SalesSystem.Models.Accounts.Customers", b =>
                {
                    b.HasOne("SalesSystem.Models.Accounts.MainAccounts", "Accounts")
                        .WithMany("Customers")
                        .HasForeignKey("Account_Id")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SalesSystem.Models.BillsSetting.BillsVariables.CustomersType", "CustomersType")
                        .WithMany("Customers")
                        .HasForeignKey("Cust_Type");

                    b.HasOne("SalesSystem.Models.Accounts.Moneys", "Moneys")
                        .WithMany("Customers")
                        .HasForeignKey("MoneysM_Name");

                    b.HasOne("SalesSystem.Models.BillsSetting.SalesAreas", "SalesAreas")
                        .WithMany("Customers")
                        .HasForeignKey("SalesAreasA_Id");

                    b.HasOne("SalesSystem.Models.BillsSetting.Summation", "Summation")
                        .WithMany("Customers")
                        .HasForeignKey("SummationS_Name");
                });

            modelBuilder.Entity("SalesSystem.Models.Accounts.Employees", b =>
                {
                    b.HasOne("SalesSystem.Models.Accounts.MainAccounts", "AccountsNB")
                        .WithMany("Employees")
                        .HasForeignKey("AccountsNBAccount_Id");

                    b.HasOne("SalesSystem.Models.Accounts.Moneys", "Moneys")
                        .WithMany("Employees")
                        .HasForeignKey("MoneysM_Name");

                    b.HasOne("SalesSystem.Models.BillsSetting.SalesAreas", "SalesAreas")
                        .WithMany("Employees")
                        .HasForeignKey("SalesAreasA_Id");
                });

            modelBuilder.Entity("SalesSystem.Models.Accounts.MainAccounts", b =>
                {
                    b.HasOne("SalesSystem.Models.Accounts.CostCenters", "CostCenter")
                        .WithMany("MainAccounts")
                        .HasForeignKey("C_Name");

                    b.HasOne("SalesSystem.Models.Accounts.AccountsGroupe", "Accounts")
                        .WithMany("MainAccounts")
                        .HasForeignKey("Groupe_Name");

                    b.HasOne("SalesSystem.Models.Accounts.Moneys", "Moneys")
                        .WithMany("MainAccounts")
                        .HasForeignKey("M_Name");

                    b.HasOne("SalesSystem.Models.Accounts.AccountsRanks", "Account")
                        .WithMany("MainAccounts")
                        .HasForeignKey("Rank_Name");

                    b.HasOne("SalesSystem.Models.Accounts.AccountsTypes", "accounts")
                        .WithMany("MainAccounts")
                        .HasForeignKey("Type_Name");
                });

            modelBuilder.Entity("SalesSystem.Models.Accounts.Suppliers", b =>
                {
                    b.HasOne("SalesSystem.Models.Accounts.MainAccounts", "Accounts")
                        .WithMany("Suppliers")
                        .HasForeignKey("Account_Id")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SalesSystem.Models.Accounts.Moneys", "Moneys")
                        .WithMany("Suppliers")
                        .HasForeignKey("M_Name");

                    b.HasOne("SalesSystem.Models.BillsSetting.SalesAreas", "SalesAreas")
                        .WithMany("Suppliers")
                        .HasForeignKey("SalesAreasA_Id");

                    b.HasOne("SalesSystem.Models.BillsSetting.Summation")
                        .WithMany("Suppliers")
                        .HasForeignKey("SummationS_Name");

                    b.HasOne("SalesSystem.Models.BillsSetting.BillsVariables.SupllierType", "SupllierType")
                        .WithMany("Suppliers")
                        .HasForeignKey("SupllierTypeSup_Type");
                });

            modelBuilder.Entity("SalesSystem.Models.BillsSetting.Employee_Lower", b =>
                {
                    b.HasOne("SalesSystem.Models.Accounts.Employees", "Employees")
                        .WithMany("Employee_Lowers")
                        .HasForeignKey("EmployeesEmp_Id");
                });

            modelBuilder.Entity("SalesSystem.Models.BillsSetting.Summation", b =>
                {
                    b.HasOne("SalesSystem.Models.Accounts.MainAccounts", "MainAccounts")
                        .WithMany("Summations")
                        .HasForeignKey("MainAccountsAccount_Id");

                    b.HasOne("SalesSystem.Models.BillsSetting.SalesAreas", "SalesAreas")
                        .WithMany("Summations")
                        .HasForeignKey("SalesAreasA_Id");
                });
#pragma warning restore 612, 618
        }
    }
}