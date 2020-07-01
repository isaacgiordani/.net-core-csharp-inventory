using Microsoft.EntityFrameworkCore.Migrations;

namespace Inventory.Data.Migrations
{
    public partial class OnDelete : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Company_CompanyId",
                table: "Employee");

            migrationBuilder.DropForeignKey(
                name: "FK_Equipment_Employee_EmployeeId",
                table: "Equipment");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Company",
                maxLength: 60,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Company_CompanyId",
                table: "Employee",
                column: "CompanyId",
                principalTable: "Company",
                principalColumn: "CompanyId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Equipment_Employee_EmployeeId",
                table: "Equipment",
                column: "EmployeeId",
                principalTable: "Employee",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Company_CompanyId",
                table: "Employee");

            migrationBuilder.DropForeignKey(
                name: "FK_Equipment_Employee_EmployeeId",
                table: "Equipment");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Company",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 60);

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Company_CompanyId",
                table: "Employee",
                column: "CompanyId",
                principalTable: "Company",
                principalColumn: "CompanyId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Equipment_Employee_EmployeeId",
                table: "Equipment",
                column: "EmployeeId",
                principalTable: "Employee",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
