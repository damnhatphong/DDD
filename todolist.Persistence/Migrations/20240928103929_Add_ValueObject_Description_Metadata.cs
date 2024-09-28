using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoList.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Add_ValueObject_Description_Metadata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description_Contributors",
                table: "TodoItems",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description_Description",
                table: "TodoItems",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Metadata_Author",
                table: "TodoItems",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Metadata_CreatedDate",
                table: "TodoItems",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Metadata_LastModifiedDate",
                table: "TodoItems",
                type: "datetime2",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description_Contributors",
                table: "TodoItems");

            migrationBuilder.DropColumn(
                name: "Description_Description",
                table: "TodoItems");

            migrationBuilder.DropColumn(
                name: "Metadata_Author",
                table: "TodoItems");

            migrationBuilder.DropColumn(
                name: "Metadata_CreatedDate",
                table: "TodoItems");

            migrationBuilder.DropColumn(
                name: "Metadata_LastModifiedDate",
                table: "TodoItems");
        }
    }
}
