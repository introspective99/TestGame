using Microsoft.EntityFrameworkCore.Migrations;

namespace GrindQuest.Migrations
{
    public partial class EditTables_AddGoldValueColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "WeaponGoldValue",
                table: "WeaponReferenceTable",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ItemGoldValue",
                table: "ItemsReferenceTable",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ArmourGoldValue",
                table: "ArmourReferenceTable",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WeaponGoldValue",
                table: "WeaponReferenceTable");

            migrationBuilder.DropColumn(
                name: "ItemGoldValue",
                table: "ItemsReferenceTable");

            migrationBuilder.DropColumn(
                name: "ArmourGoldValue",
                table: "ArmourReferenceTable");
        }
    }
}
