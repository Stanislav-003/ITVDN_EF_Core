using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HW_1._2.Migrations
{
    /// <inheritdoc />
    public partial class ProductMigration2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_products",
                table: "products");

            migrationBuilder.RenameTable(
                name: "products",
                newName: "Product");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Product",
                newName: "ProductId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Product",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Product",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Product",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "Product",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Product",
                table: "Product",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Product",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "Product");

            migrationBuilder.RenameTable(
                name: "Product",
                newName: "products");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "products",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "products",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "products",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(1000)",
                oldMaxLength: 1000);

            migrationBuilder.AddPrimaryKey(
                name: "PK_products",
                table: "products",
                column: "Id");
        }
    }
}
