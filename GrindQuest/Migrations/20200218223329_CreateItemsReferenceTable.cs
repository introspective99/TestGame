using Microsoft.EntityFrameworkCore.Migrations;

namespace GrindQuest.Migrations
{
    public partial class CreateItemsReferenceTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            /*migrationBuilder.DropTable(
                name: "PlayerChars");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MasterItemsTable",
                table: "MasterItemsTable");

            migrationBuilder.CreateTable(
                name: "ItemsReferenceTable",
                columns: table => new
                {
                    ItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemMaxStack = table.Column<int>(type: "int", nullable: false),
                    ItemName = table.Column<string>(type: "varchar(50)", nullable: false),
                    ItemEffect = table.Column<string>(type: "varchar(50)", nullable: false),
                    ItemType = table.Column<string>(type: "varchar(50)", nullable: false),
                });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItemsReferenceTable",
                table: "ItemsReferenceTable",
                column: "ItemId");*/
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            /*migrationBuilder.DropPrimaryKey(
                name: "PK_ItemsReferenceTable",
                table: "ItemsReferenceTable");

            migrationBuilder.RenameTable(
                name: "ItemsReferenceTable",
                newName: "MasterItemsTable");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MasterItemsTable",
                table: "MasterItemsTable",
                column: "ItemID");

            migrationBuilder.CreateTable(
                name: "PlayerChars",
                columns: table => new
                {
                    PlayerCharID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlayerCharName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlayerCharSpec = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerChars", x => x.PlayerCharID);
                });*/
        }
    }
}
