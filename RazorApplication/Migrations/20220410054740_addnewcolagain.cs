using Microsoft.EntityFrameworkCore.Migrations;

namespace RazorApplication.Migrations
{
    public partial class addnewcolagain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Avaibility",
                table: "Book",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Price",
                table: "Book",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Avaibility",
                table: "Book");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Book");
        }
    }
}
