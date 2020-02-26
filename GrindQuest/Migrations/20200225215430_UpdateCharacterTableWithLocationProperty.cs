using Microsoft.EntityFrameworkCore.Migrations;

namespace GrindQuest.Migrations
{
    public partial class UpdateCharacterTableWithLocationProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CurrentTileLocation",
                table: "CharacterMasterTable",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CurrentTileLocation",
                table: "CharacterMasterTable");
        }
    }
}
