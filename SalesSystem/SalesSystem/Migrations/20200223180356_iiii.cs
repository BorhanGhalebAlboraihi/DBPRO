using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SalesSystem.Migrations
{
    public partial class iiii : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Rank_Name",
                table: "CostCenters",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CostCenters_Rank_Name",
                table: "CostCenters",
                column: "Rank_Name");

            migrationBuilder.AddForeignKey(
                name: "FK_CostCenters_AccountsRanks_Rank_Name",
                table: "CostCenters",
                column: "Rank_Name",
                principalTable: "AccountsRanks",
                principalColumn: "Rank_Name",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CostCenters_AccountsRanks_Rank_Name",
                table: "CostCenters");

            migrationBuilder.DropIndex(
                name: "IX_CostCenters_Rank_Name",
                table: "CostCenters");

            migrationBuilder.AlterColumn<string>(
                name: "Rank_Name",
                table: "CostCenters",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
