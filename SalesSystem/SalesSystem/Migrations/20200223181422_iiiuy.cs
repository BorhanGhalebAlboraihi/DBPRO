using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SalesSystem.Migrations
{
    public partial class iiiuy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CostCenters_MainAccounts_Account_Id",
                table: "CostCenters");

            migrationBuilder.DropIndex(
                name: "IX_CostCenters_Account_Id",
                table: "CostCenters");

            migrationBuilder.DropColumn(
                name: "Account_Id",
                table: "CostCenters");

            migrationBuilder.AlterColumn<string>(
                name: "C_Name",
                table: "MainAccounts",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_MainAccounts_C_Name",
                table: "MainAccounts",
                column: "C_Name");

            migrationBuilder.AddForeignKey(
                name: "FK_MainAccounts_CostCenters_C_Name",
                table: "MainAccounts",
                column: "C_Name",
                principalTable: "CostCenters",
                principalColumn: "C_Name",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MainAccounts_CostCenters_C_Name",
                table: "MainAccounts");

            migrationBuilder.DropIndex(
                name: "IX_MainAccounts_C_Name",
                table: "MainAccounts");

            migrationBuilder.AlterColumn<string>(
                name: "C_Name",
                table: "MainAccounts",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Account_Id",
                table: "CostCenters",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_CostCenters_Account_Id",
                table: "CostCenters",
                column: "Account_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CostCenters_MainAccounts_Account_Id",
                table: "CostCenters",
                column: "Account_Id",
                principalTable: "MainAccounts",
                principalColumn: "Account_Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
