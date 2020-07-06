using Microsoft.EntityFrameworkCore.Migrations;

namespace Inventory.Data.Migrations
{
    public partial class NomeFantasia : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Company",
                newName: "CompanyName");

            migrationBuilder.AddColumn<string>(
                name: "FantasyName",
                table: "Company",
                maxLength: 25,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FantasyName",
                table: "Company");

            migrationBuilder.RenameColumn(
                name: "CompanyName",
                table: "Company",
                newName: "Name");
        }
    }
}
