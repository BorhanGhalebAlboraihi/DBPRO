using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SalesSystem.Migrations
{
    public partial class tt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "accountsGroupes",
                columns: table => new
                {
                    Groupe_Name = table.Column<string>(nullable: false),
                    EngName = table.Column<string>(nullable: true),
                    Groupe_Id = table.Column<int>(nullable: false),
                    State = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_accountsGroupes", x => x.Groupe_Name);
                });

            migrationBuilder.CreateTable(
                name: "AccountsRanks",
                columns: table => new
                {
                    Rank_Name = table.Column<string>(nullable: false),
                    EngName = table.Column<string>(nullable: true),
                    Length = table.Column<int>(nullable: false),
                    Rank_Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountsRanks", x => x.Rank_Name);
                });

            migrationBuilder.CreateTable(
                name: "AccountsTypes",
                columns: table => new
                {
                    Type_Name = table.Column<string>(nullable: false),
                    EngName = table.Column<string>(nullable: true),
                    State = table.Column<int>(nullable: false),
                    Type_Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountsTypes", x => x.Type_Name);
                });

            migrationBuilder.CreateTable(
                name: "customersTypes",
                columns: table => new
                {
                    Cust_Type = table.Column<string>(nullable: false),
                    Aressting = table.Column<int>(nullable: false),
                    Aressting_Name = table.Column<int>(nullable: false),
                    CommunicationTop = table.Column<string>(nullable: true),
                    EngName = table.Column<string>(nullable: true),
                    Id = table.Column<int>(nullable: false),
                    State = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customersTypes", x => x.Cust_Type);
                });

            migrationBuilder.CreateTable(
                name: "Moneys",
                columns: table => new
                {
                    M_Name = table.Column<string>(nullable: false),
                    M_Barket = table.Column<string>(nullable: true),
                    M_Country = table.Column<string>(nullable: true),
                    M_History = table.Column<DateTime>(nullable: false),
                    M_Pric = table.Column<double>(nullable: false),
                    M_PriceLess = table.Column<double>(nullable: false),
                    M_PriceTop = table.Column<double>(nullable: false),
                    M_State = table.Column<string>(nullable: true),
                    M_Symbole = table.Column<string>(nullable: true),
                    M_Type = table.Column<string>(nullable: true),
                    _Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Moneys", x => x.M_Name);
                });

            migrationBuilder.CreateTable(
                name: "SalesAreas",
                columns: table => new
                {
                    A_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Address = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    History = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesAreas", x => x.A_Id);
                });

            migrationBuilder.CreateTable(
                name: "SupllierType",
                columns: table => new
                {
                    Sup_Type = table.Column<string>(nullable: false),
                    Aressting = table.Column<int>(nullable: false),
                    Aressting_Name = table.Column<int>(nullable: false),
                    EngName = table.Column<string>(nullable: true),
                    Id = table.Column<int>(nullable: false),
                    State = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupllierType", x => x.Sup_Type);
                });

            migrationBuilder.CreateTable(
                name: "MainAccounts",
                columns: table => new
                {
                    Account_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Account_Confidentility = table.Column<string>(nullable: true),
                    Account_Main = table.Column<string>(nullable: true),
                    Account_Name = table.Column<string>(nullable: true),
                    Account_Netural = table.Column<string>(nullable: true),
                    Account_State = table.Column<string>(nullable: true),
                    C_Name = table.Column<string>(nullable: true),
                    Groupe_Name = table.Column<string>(nullable: true),
                    M_Name = table.Column<string>(nullable: true),
                    MainAccount_Id = table.Column<double>(nullable: false),
                    Rank_Name = table.Column<string>(nullable: true),
                    Type_Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MainAccounts", x => x.Account_Id);
                    table.ForeignKey(
                        name: "FK_MainAccounts_accountsGroupes_Groupe_Name",
                        column: x => x.Groupe_Name,
                        principalTable: "accountsGroupes",
                        principalColumn: "Groupe_Name",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MainAccounts_Moneys_M_Name",
                        column: x => x.M_Name,
                        principalTable: "Moneys",
                        principalColumn: "M_Name",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MainAccounts_AccountsRanks_Rank_Name",
                        column: x => x.Rank_Name,
                        principalTable: "AccountsRanks",
                        principalColumn: "Rank_Name",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MainAccounts_AccountsTypes_Type_Name",
                        column: x => x.Type_Name,
                        principalTable: "AccountsTypes",
                        principalColumn: "Type_Name",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Banks",
                columns: table => new
                {
                    Bnk_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AccountsAccount_Id = table.Column<int>(nullable: true),
                    BakArabic_Name = table.Column<string>(nullable: true),
                    BakEnglish_Name = table.Column<string>(nullable: true),
                    Bak_MainAccountNB = table.Column<int>(nullable: false),
                    Bak_Netuarl = table.Column<string>(nullable: true),
                    Bak_State = table.Column<string>(nullable: true),
                    Bak_Type = table.Column<string>(nullable: true),
                    MoneysM_Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Banks", x => x.Bnk_Id);
                    table.ForeignKey(
                        name: "FK_Banks_MainAccounts_AccountsAccount_Id",
                        column: x => x.AccountsAccount_Id,
                        principalTable: "MainAccounts",
                        principalColumn: "Account_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Banks_Moneys_MoneysM_Name",
                        column: x => x.MoneysM_Name,
                        principalTable: "Moneys",
                        principalColumn: "M_Name",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Boxs",
                columns: table => new
                {
                    Box_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BoxArabic_Name = table.Column<string>(nullable: true),
                    BoxEnglish_Name = table.Column<string>(nullable: true),
                    Box_MainAccountNB = table.Column<int>(nullable: false),
                    Box_Netuarl = table.Column<string>(nullable: true),
                    Box_State = table.Column<string>(nullable: true),
                    Box_Type = table.Column<string>(nullable: true),
                    MainAccountsAccount_Id = table.Column<int>(nullable: true),
                    MoneysM_Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Boxs", x => x.Box_Id);
                    table.ForeignKey(
                        name: "FK_Boxs_MainAccounts_MainAccountsAccount_Id",
                        column: x => x.MainAccountsAccount_Id,
                        principalTable: "MainAccounts",
                        principalColumn: "Account_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Boxs_Moneys_MoneysM_Name",
                        column: x => x.MoneysM_Name,
                        principalTable: "Moneys",
                        principalColumn: "M_Name",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CostCenters",
                columns: table => new
                {
                    C_Name = table.Column<string>(nullable: false),
                    Account_Id = table.Column<int>(nullable: false),
                    Center_Id = table.Column<int>(nullable: false),
                    Groupe = table.Column<string>(nullable: true),
                    Rank_Name = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CostCenters", x => x.C_Name);
                    table.ForeignKey(
                        name: "FK_CostCenters_MainAccounts_Account_Id",
                        column: x => x.Account_Id,
                        principalTable: "MainAccounts",
                        principalColumn: "Account_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Emp_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AccountsNBAccount_Id = table.Column<int>(nullable: true),
                    Emp_BankAccountNB = table.Column<int>(nullable: false),
                    Emp_Card = table.Column<int>(nullable: false),
                    Emp_Center = table.Column<string>(nullable: true),
                    Emp_City = table.Column<string>(nullable: true),
                    Emp_CostCenter = table.Column<string>(nullable: true),
                    Emp_Country = table.Column<string>(nullable: true),
                    Emp_History = table.Column<DateTime>(nullable: false),
                    Emp_InclusionCard = table.Column<int>(nullable: false),
                    Emp_InclusionNB = table.Column<int>(nullable: false),
                    Emp_InclusionName = table.Column<string>(nullable: true),
                    Emp_Job = table.Column<string>(nullable: true),
                    Emp_MainAccountNB = table.Column<int>(nullable: false),
                    Emp_Name = table.Column<string>(nullable: true),
                    Emp_Netural = table.Column<string>(nullable: true),
                    Emp_Phone = table.Column<int>(nullable: false),
                    Emp_PushingMethod = table.Column<string>(nullable: true),
                    Emp_Qualification = table.Column<string>(nullable: true),
                    Emp_Rank = table.Column<string>(nullable: true),
                    Emp_Salery = table.Column<double>(nullable: false),
                    Emp_State = table.Column<string>(nullable: true),
                    Emp_WStateHis = table.Column<DateTime>(nullable: false),
                    Emp_WorkArea = table.Column<string>(nullable: true),
                    Emp_WorkTime = table.Column<int>(nullable: false),
                    Emp_address = table.Column<string>(nullable: true),
                    MoneysM_Name = table.Column<string>(nullable: true),
                    SalesAreasA_Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Emp_Id);
                    table.ForeignKey(
                        name: "FK_Employees_MainAccounts_AccountsNBAccount_Id",
                        column: x => x.AccountsNBAccount_Id,
                        principalTable: "MainAccounts",
                        principalColumn: "Account_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employees_Moneys_MoneysM_Name",
                        column: x => x.MoneysM_Name,
                        principalTable: "Moneys",
                        principalColumn: "M_Name",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employees_SalesAreas_SalesAreasA_Id",
                        column: x => x.SalesAreasA_Id,
                        principalTable: "SalesAreas",
                        principalColumn: "A_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Summations",
                columns: table => new
                {
                    S_Name = table.Column<string>(nullable: false),
                    Adddress = table.Column<string>(nullable: true),
                    History = table.Column<DateTime>(nullable: false),
                    MainAccountsAccount_Id = table.Column<int>(nullable: true),
                    Phone = table.Column<int>(nullable: false),
                    S_Id = table.Column<int>(nullable: false),
                    SalesAreasA_Id = table.Column<int>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Summations", x => x.S_Name);
                    table.ForeignKey(
                        name: "FK_Summations_MainAccounts_MainAccountsAccount_Id",
                        column: x => x.MainAccountsAccount_Id,
                        principalTable: "MainAccounts",
                        principalColumn: "Account_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Summations_SalesAreas_SalesAreasA_Id",
                        column: x => x.SalesAreasA_Id,
                        principalTable: "SalesAreas",
                        principalColumn: "A_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Employee_Lower",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Communique = table.Column<string>(nullable: true),
                    Emp_Name = table.Column<string>(nullable: true),
                    EmployeesEmp_Id = table.Column<int>(nullable: true),
                    FromHistory = table.Column<DateTime>(nullable: false),
                    History = table.Column<DateTime>(nullable: false),
                    LowerHigh = table.Column<double>(nullable: false),
                    LowerLess = table.Column<double>(nullable: false),
                    State = table.Column<string>(nullable: true),
                    ToHistory = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee_Lower", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employee_Lower_Employees_EmployeesEmp_Id",
                        column: x => x.EmployeesEmp_Id,
                        principalTable: "Employees",
                        principalColumn: "Emp_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Cust_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Account_Id = table.Column<int>(nullable: false),
                    City = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    Cust_Address = table.Column<string>(nullable: true),
                    Cust_DebtorsTime = table.Column<string>(nullable: true),
                    Cust_DebtorsTop = table.Column<double>(nullable: false),
                    Cust_History = table.Column<DateTime>(nullable: false),
                    Cust_MainAccountNB = table.Column<int>(nullable: false),
                    Cust_Name = table.Column<string>(nullable: true),
                    Cust_Netuarl = table.Column<string>(nullable: true),
                    Cust_Rank = table.Column<string>(nullable: true),
                    Cust_SaleMoney = table.Column<string>(nullable: true),
                    Cust_SalePrice = table.Column<string>(nullable: true),
                    Cust_State = table.Column<string>(nullable: true),
                    Cust_Type = table.Column<string>(nullable: true),
                    Cust_phone = table.Column<double>(nullable: false),
                    M_Name = table.Column<int>(nullable: false),
                    MoneysM_Name = table.Column<string>(nullable: true),
                    SalesAreasA_Id = table.Column<int>(nullable: true),
                    SummationS_Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Cust_Id);
                    table.ForeignKey(
                        name: "FK_Customers_MainAccounts_Account_Id",
                        column: x => x.Account_Id,
                        principalTable: "MainAccounts",
                        principalColumn: "Account_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Customers_customersTypes_Cust_Type",
                        column: x => x.Cust_Type,
                        principalTable: "customersTypes",
                        principalColumn: "Cust_Type",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Customers_Moneys_MoneysM_Name",
                        column: x => x.MoneysM_Name,
                        principalTable: "Moneys",
                        principalColumn: "M_Name",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Customers_SalesAreas_SalesAreasA_Id",
                        column: x => x.SalesAreasA_Id,
                        principalTable: "SalesAreas",
                        principalColumn: "A_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Customers_Summations_SummationS_Name",
                        column: x => x.SummationS_Name,
                        principalTable: "Summations",
                        principalColumn: "S_Name",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    Sup_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Account_Id = table.Column<int>(nullable: false),
                    Country = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    M_Name = table.Column<string>(nullable: true),
                    SalesAreasA_Id = table.Column<int>(nullable: true),
                    Summation = table.Column<string>(nullable: true),
                    SummationS_Name = table.Column<string>(nullable: true),
                    Sup_Address = table.Column<string>(nullable: true),
                    Sup_DebtorsTime = table.Column<string>(nullable: true),
                    Sup_DebtorsTop = table.Column<double>(nullable: false),
                    Sup_History = table.Column<DateTime>(nullable: false),
                    Sup_MainAccountNB = table.Column<int>(nullable: false),
                    Sup_Name = table.Column<string>(nullable: true),
                    Sup_Netuarl = table.Column<string>(nullable: true),
                    Sup_Rank = table.Column<string>(nullable: true),
                    Sup_SaleMoney = table.Column<string>(nullable: true),
                    Sup_SalePrice = table.Column<string>(nullable: true),
                    Sup_State = table.Column<string>(nullable: true),
                    Sup_Type = table.Column<int>(nullable: false),
                    Sup_phone = table.Column<double>(nullable: false),
                    SupllierTypeSup_Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.Sup_Id);
                    table.ForeignKey(
                        name: "FK_Suppliers_MainAccounts_Account_Id",
                        column: x => x.Account_Id,
                        principalTable: "MainAccounts",
                        principalColumn: "Account_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Suppliers_Moneys_M_Name",
                        column: x => x.M_Name,
                        principalTable: "Moneys",
                        principalColumn: "M_Name",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Suppliers_SalesAreas_SalesAreasA_Id",
                        column: x => x.SalesAreasA_Id,
                        principalTable: "SalesAreas",
                        principalColumn: "A_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Suppliers_Summations_SummationS_Name",
                        column: x => x.SummationS_Name,
                        principalTable: "Summations",
                        principalColumn: "S_Name",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Suppliers_SupllierType_SupllierTypeSup_Type",
                        column: x => x.SupllierTypeSup_Type,
                        principalTable: "SupllierType",
                        principalColumn: "Sup_Type",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Banks_AccountsAccount_Id",
                table: "Banks",
                column: "AccountsAccount_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Banks_MoneysM_Name",
                table: "Banks",
                column: "MoneysM_Name");

            migrationBuilder.CreateIndex(
                name: "IX_Boxs_MainAccountsAccount_Id",
                table: "Boxs",
                column: "MainAccountsAccount_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Boxs_MoneysM_Name",
                table: "Boxs",
                column: "MoneysM_Name");

            migrationBuilder.CreateIndex(
                name: "IX_CostCenters_Account_Id",
                table: "CostCenters",
                column: "Account_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_Account_Id",
                table: "Customers",
                column: "Account_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_Cust_Type",
                table: "Customers",
                column: "Cust_Type");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_MoneysM_Name",
                table: "Customers",
                column: "MoneysM_Name");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_SalesAreasA_Id",
                table: "Customers",
                column: "SalesAreasA_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_SummationS_Name",
                table: "Customers",
                column: "SummationS_Name");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_Lower_EmployeesEmp_Id",
                table: "Employee_Lower",
                column: "EmployeesEmp_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_AccountsNBAccount_Id",
                table: "Employees",
                column: "AccountsNBAccount_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_MoneysM_Name",
                table: "Employees",
                column: "MoneysM_Name");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_SalesAreasA_Id",
                table: "Employees",
                column: "SalesAreasA_Id");

            migrationBuilder.CreateIndex(
                name: "IX_MainAccounts_Groupe_Name",
                table: "MainAccounts",
                column: "Groupe_Name");

            migrationBuilder.CreateIndex(
                name: "IX_MainAccounts_M_Name",
                table: "MainAccounts",
                column: "M_Name");

            migrationBuilder.CreateIndex(
                name: "IX_MainAccounts_Rank_Name",
                table: "MainAccounts",
                column: "Rank_Name");

            migrationBuilder.CreateIndex(
                name: "IX_MainAccounts_Type_Name",
                table: "MainAccounts",
                column: "Type_Name");

            migrationBuilder.CreateIndex(
                name: "IX_Summations_MainAccountsAccount_Id",
                table: "Summations",
                column: "MainAccountsAccount_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Summations_SalesAreasA_Id",
                table: "Summations",
                column: "SalesAreasA_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Suppliers_Account_Id",
                table: "Suppliers",
                column: "Account_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Suppliers_M_Name",
                table: "Suppliers",
                column: "M_Name");

            migrationBuilder.CreateIndex(
                name: "IX_Suppliers_SalesAreasA_Id",
                table: "Suppliers",
                column: "SalesAreasA_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Suppliers_SummationS_Name",
                table: "Suppliers",
                column: "SummationS_Name");

            migrationBuilder.CreateIndex(
                name: "IX_Suppliers_SupllierTypeSup_Type",
                table: "Suppliers",
                column: "SupllierTypeSup_Type");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Banks");

            migrationBuilder.DropTable(
                name: "Boxs");

            migrationBuilder.DropTable(
                name: "CostCenters");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Employee_Lower");

            migrationBuilder.DropTable(
                name: "Suppliers");

            migrationBuilder.DropTable(
                name: "customersTypes");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Summations");

            migrationBuilder.DropTable(
                name: "SupllierType");

            migrationBuilder.DropTable(
                name: "MainAccounts");

            migrationBuilder.DropTable(
                name: "SalesAreas");

            migrationBuilder.DropTable(
                name: "accountsGroupes");

            migrationBuilder.DropTable(
                name: "Moneys");

            migrationBuilder.DropTable(
                name: "AccountsRanks");

            migrationBuilder.DropTable(
                name: "AccountsTypes");
        }
    }
}
