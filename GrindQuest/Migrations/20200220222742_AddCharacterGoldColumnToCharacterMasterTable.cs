using Microsoft.EntityFrameworkCore.Migrations;

namespace GrindQuest.Migrations
{
    public partial class AddCharacterGoldColumnToCharacterMasterTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CharacterGold",
                table: "CharacterMasterTable",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CharacterGold",
                table: "CharacterMasterTable");
        }
    }
}
