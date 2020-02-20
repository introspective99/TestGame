using Microsoft.EntityFrameworkCore.Migrations;

namespace GrindQuest.Migrations
{
    public partial class CreateTable_CharacterReferenceTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CharacterMasterTable",
                columns: table => new
                {
                    CharacterId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CharacterName = table.Column<string>(nullable: true),
                    CharacterLevel = table.Column<int>(nullable: false),
                    CharacterStrength = table.Column<int>(nullable: false),
                    CharacterIntellect = table.Column<int>(nullable: false),
                    CharacterAgility = table.Column<int>(nullable: false),
                    CharacterStamina = table.Column<int>(nullable: false),
                    CharacterSpeed = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterMasterTable", x => x.CharacterId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CharacterMasterTable");
        }
    }
}
