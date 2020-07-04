using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Inventory.Data.Migrations
{
    public partial class NewModelEquipmentType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Manufacturer",
                table: "Equipment");

            migrationBuilder.DropColumn(
                name: "Model",
                table: "Equipment");

            migrationBuilder.AddColumn<int>(
                name: "EquipmentTypeId",
                table: "Equipment",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "EquipmentType",
                columns: table => new
                {
                    EquipmentTypeId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Type = table.Column<string>(maxLength: 20, nullable: false),
                    Manufacturer = table.Column<string>(maxLength: 25, nullable: false),
                    Model = table.Column<string>(maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipmentType", x => x.EquipmentTypeId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Equipment_EquipmentTypeId",
                table: "Equipment",
                column: "EquipmentTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Equipment_EquipmentType_EquipmentTypeId",
                table: "Equipment",
                column: "EquipmentTypeId",
                principalTable: "EquipmentType",
                principalColumn: "EquipmentTypeId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Equipment_EquipmentType_EquipmentTypeId",
                table: "Equipment");

            migrationBuilder.DropTable(
                name: "EquipmentType");

            migrationBuilder.DropIndex(
                name: "IX_Equipment_EquipmentTypeId",
                table: "Equipment");

            migrationBuilder.DropColumn(
                name: "EquipmentTypeId",
                table: "Equipment");

            migrationBuilder.AddColumn<string>(
                name: "Manufacturer",
                table: "Equipment",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "Equipment",
                nullable: true);
        }
    }
}
