using Microsoft.EntityFrameworkCore.Migrations;

namespace GrindQuest.Migrations
{
    public partial class CreateTable_PlayerChars : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PlayerChars",
                columns: table => new
                {
                    PlayerCharID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlayerCharName = table.Column<string>(nullable: true),
                    PlayerCharSpec = table.Column<int>(nullable: false),
                    InventoryID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerChars", x => x.PlayerCharID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlayerChars");
        }
    }
}
